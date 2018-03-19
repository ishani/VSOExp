using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace VSOExp
{
    public class ClassMember
    {
        public String Name = null;
        public String Type = null;
        public Int32 Offset = -1;
        public Int32 Size = -1;
    }

    public class BaseClass
    {
        public BaseClass(string _name) 
        {
            Name = _name;
        }

        public String Name { get; protected set; }
        public String Size { get; set; }
    }

    public class ClassLayout
    {
        public String Name;
        public Int32 Size;

        public List<BaseClass> BaseClasses = new List<BaseClass>();

        public Int32 TotalAlignmentEntries = 0;
        public Int32 TotalAlignmentPadding = 0;

        public List<ClassMember> Members = new List<ClassMember>();
    }

    public class LayoutLoaderOutput
    {
        public LayoutLoaderOutput( Dictionary<string, ClassLayout> Data )
        {
            Classes = Data;
        }
        public Dictionary<string, ClassLayout> Classes;
    }

    class LayoutLoader
    {
        // class CEntityComponentSubstitution    size(96):
        internal Regex ClassLayoutStartRegex = new Regex(@"[\W]*class ([^ ]+)[\W]+size\(([\d]+)\):", RegexOptions.Compiled | RegexOptions.Singleline);

        //  +---
        // 0    | +--- (base class IEntitySubstitutionComponent)
        // 0    | | +--- (base class IEntityComponent)
        // 0    | | | +--- (base class ICryUnknown)
        // 0    | | | | {vfptr}
        //  | | | +---
        internal Regex ExtractBaseClass = new Regex(@"[^(]*\(base class ([^)]+)", RegexOptions.Compiled | RegexOptions.Singleline);

        //  36  | control
        //      | <alignment member> (size=3)
        internal Regex ExtractClassMember = new Regex(@"[\W]*([\d]+)[\W]*\|(.*)$", RegexOptions.Compiled | RegexOptions.Singleline);

        internal Regex ExtractAlignmentMember = new Regex(@"alignment member> \(size=([\d]+)\)", RegexOptions.Compiled | RegexOptions.Singleline);

        internal StringBuilder UnDecoratedSymbol = new StringBuilder(255);

        Dictionary<string, ClassLayout> Classes = new Dictionary<string, ClassLayout>(4096);

        public LayoutLoaderOutput Result
        {
            get { return new LayoutLoaderOutput( Classes ); }
        }

        public LayoutLoader()
        {
        }

        public async Task<bool> ParseFromFile( string filename )
        {
            const Int32 BufferSize = 1024 * 4;
            using ( var fileStream = File.OpenRead( filename ) )
            {
                using ( var InputStreamReader = new StreamReader( fileStream, Encoding.UTF8, true, BufferSize ) )
                {
                    String line;
                    while ( ( line = InputStreamReader.ReadLine() ) != null )
                    {
                        line = line.Substring( line.IndexOf( '>' ) + 1 );
                        line = line.Trim();
                        if ( line.Length == 0 )
                            continue;

                        var StartMatch = ClassLayoutStartRegex.Match(line);
                        if ( StartMatch.Success )
                        {
                            string DecoratedSymbol = StartMatch.Groups[1].ToString();

                            SafeNativeMethods.UnDecorateSymbolName( DecoratedSymbol, UnDecoratedSymbol, UnDecoratedSymbol.Capacity, SafeNativeMethods.UnDecorateFlags.UNDNAME_COMPLETE );
                            string ClassSymbol = UnDecoratedSymbol.ToString();

                            Int32 ClassSize = Int32.Parse(StartMatch.Groups[2].ToString());

                            ClassLayout ClassResult = new ClassLayout();

                            // only save the result if its the first time we have seen the name
                            if ( !Classes.ContainsKey( ClassSymbol ) )
                            {
                                ClassResult.Name = ClassSymbol;
                                ClassResult.Size = ClassSize;

                                Classes.Add( ClassSymbol, ClassResult );
                            }

                            // consume this layout descriptor
                            ParseClass( ClassResult, InputStreamReader );

                            await Task.Yield();
                        }

                    }
                }
            }

            PostLoadProcess();

            return true;
        }

        internal void ParseClass( ClassLayout ClassResult, StreamReader InputStreamReader )
        {
            ClassMember PreviousMemberAlignSkip = null;
            ClassMember PreviousMember = null;

            String Line;
            while ( ( Line = InputStreamReader.ReadLine() ) != null )
            {
                Line = Line.Substring( Line.IndexOf( '>' ) + 1 );
                Line = Line.Trim();

                if ( Line.Length == 0 )
                    break;

                // catch and store the base classes, eg
                //      | | +---( base class IEntityComponent)
                //
                var BaseClassMatch = ExtractBaseClass.Match(Line);
                if ( BaseClassMatch.Success )
                {
                    string BaseClassNameString = BaseClassMatch.Groups[1].ToString();
                    Int32 BaseInheritDepth = Line.Count(f => f == '|');

                    ClassResult.BaseClasses.Add( new BaseClass(BaseClassNameString) );
                    continue;
                }


                var ClassMemberMatch = ExtractClassMember.Match(Line);
                if ( ClassMemberMatch.Success )
                {
                    string MemberOffsetString = ClassMemberMatch.Groups[1].ToString();
                    Int32 MemberOffset = Int32.Parse(MemberOffsetString);

                    string MemberName = ClassMemberMatch.Groups[2].ToString().Trim();
                    string MemberType = null;

                    if ( MemberName.IndexOf( ' ' ) > 0 )
                    {
                        string[] MemberTypeAndName = MemberName.Split(' ');
                        string DecMemberType = MemberTypeAndName[0].Trim();
                        MemberName = MemberTypeAndName[1].Trim();

                        if ( SafeNativeMethods.UnDecorateSymbolName( DecMemberType, UnDecoratedSymbol, UnDecoratedSymbol.Capacity, SafeNativeMethods.UnDecorateFlags.UNDNAME_COMPLETE ) > 0 )
                        {
                            MemberType = UnDecoratedSymbol.ToString();
                        }
                        else
                        {
                            MemberType = DecMemberType;
                        }
                    }

                    if ( PreviousMember != null )
                    {
                        if ( PreviousMemberAlignSkip != null )
                        {
                            PreviousMemberAlignSkip.Size = MemberOffset - ( PreviousMemberAlignSkip.Offset + PreviousMember.Size );
                        }
                        else
                        {
                            PreviousMember.Size = MemberOffset - PreviousMember.Offset;
                        }
                    }

                    ClassMember NewMember = new ClassMember();
                    NewMember.Type = MemberType;
                    NewMember.Name = MemberName;
                    NewMember.Offset = MemberOffset;
                    NewMember.Size = -1;

                    PreviousMember = NewMember;
                    PreviousMemberAlignSkip = null;

                    ClassResult.Members.Add( NewMember );
                }

                // special alignment-space, representing compiler-added padding
                var AlignmentMemberMatch = ExtractAlignmentMember.Match(Line);
                if ( AlignmentMemberMatch.Success )
                {
                    string MemberSizeString = AlignmentMemberMatch.Groups[1].ToString();
                    Int32 MemberSize = Int32.Parse(MemberSizeString);

                    ClassMember NewMember = new ClassMember();
                    NewMember.Name = null;
                    NewMember.Offset = -1;
                    NewMember.Size = MemberSize;

                    PreviousMemberAlignSkip = PreviousMember;
                    PreviousMember = NewMember;

                    ClassResult.TotalAlignmentEntries++;
                    ClassResult.TotalAlignmentPadding += MemberSize;

                    ClassResult.Members.Add( NewMember );
                }
            }

            if ( PreviousMember != null && PreviousMember.Name != null )
            {
                PreviousMember.Size = ClassResult.Size - PreviousMember.Offset;
            }
        }

        internal void PostLoadProcess()
        {
            foreach ( var loadedClass in Classes )
            {
                foreach ( var loadedBaseClass in loadedClass.Value.BaseClasses )
                {
                    if ( Classes.ContainsKey( loadedBaseClass.Name ) )
                    {
                        loadedBaseClass.Size = Classes[loadedBaseClass.Name].Size.ToString();
                    }
                    else
                    {
                        loadedBaseClass.Size = "< ?? >";
                    }
                }
            }

            GC.Collect();
        }
    }
}
