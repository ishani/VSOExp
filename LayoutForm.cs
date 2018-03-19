using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aga.Controls.Tree;

namespace VSOExp
{
    public partial class LayoutForm : Form
    {
        LayoutLoaderOutput LayoutOutput;

        private TreeModel _model;
        private Dictionary<string, LayoutTreeNode> _classNameBackpt;

        public LayoutForm( LayoutLoaderOutput llOutput )
        {
            LayoutOutput = llOutput;

            InitializeComponent();

            hwSortBy.SelectedItem = "Size";

            BuildModelFromOutput();

            hwObjectTree.KeepNodesExpanded = true;
        }

        internal void BuildModelFromOutput()
        {
            _model = new TreeModel();
            _classNameBackpt = new Dictionary<string, LayoutTreeNode>( LayoutOutput.Classes.Count );

            IOrderedEnumerable< KeyValuePair<string, VSOExp.ClassLayout> >   SortedDict;

            switch ( hwSortBy.SelectedItem.ToString() )
            {
                default:
                case "Name": SortedDict = LayoutOutput.Classes.OrderBy( key => key.Value.Name ); break;
                case "Size": SortedDict = LayoutOutput.Classes.OrderByDescending( key => key.Value.Size );  break;
                case "Padding": SortedDict = LayoutOutput.Classes.OrderByDescending( key => key.Value.TotalAlignmentPadding ); break;
                case "Gaps": SortedDict = LayoutOutput.Classes.OrderByDescending( key => key.Value.TotalAlignmentEntries ); break;
            }

            
            foreach ( var nameLayoutPair in SortedDict )
            {
                if ( nameLayoutPair.Value.Members.Count > 0 && nameLayoutPair.Value.Size > 0 )
                {
                    LayoutTreeNode NewNode = new LayoutTreeNode();
                    NewNode.Text = nameLayoutPair.Key;

                    NewNode.Size = nameLayoutPair.Value.Size.ToString();
                    NewNode.Padding = nameLayoutPair.Value.TotalAlignmentPadding.ToString();
                    NewNode.Gaps = nameLayoutPair.Value.TotalAlignmentEntries.ToString();


                    _classNameBackpt.Add( NewNode.Text, NewNode );
                    _model.Root.Nodes.Add( NewNode );

                    
                    foreach ( var BaseClassItem in nameLayoutPair.Value.BaseClasses)
                    {
                        LayoutTreeNode MemberNode = new LayoutTreeNode();
                        MemberNode.Text = "Base Class";

                        MemberNode.TypeName = BaseClassItem.Name;
                        MemberNode.Size = BaseClassItem.Size;

                        NewNode.Nodes.Add( MemberNode );
                    }

                    foreach ( var LayoutClassMember in nameLayoutPair.Value.Members )
                    {
                        LayoutTreeNode MemberNode = new LayoutTreeNode();
                        MemberNode.Text = LayoutClassMember.Name;
                        MemberNode.Size = LayoutClassMember.Size.ToString();

                        string MemberType = LayoutClassMember.Type;
                        if ( MemberType != null )
                        {
                            if ( LayoutOutput.Classes.ContainsKey( MemberType ) )
                            {
                                MemberNode.Padding = "(" + LayoutOutput.Classes[MemberType].TotalAlignmentPadding + ")";
                            }

                            MemberNode.TypeName = MemberType;
                        }

                        NewNode.Nodes.Add( MemberNode );
                    }
                }

            }

            hwObjectTree.Model = _model;
        }

        private void hwSortBy_SelectedIndexChanged( object sender, EventArgs e )
        {
            BuildModelFromOutput();
        }

        private void hwObjectTree_NodeMouseDoubleClick( object sender, TreeNodeAdvMouseEventArgs e )
        {
            LayoutTreeNode ltn = e.Node.Tag as LayoutTreeNode;
            if ( ltn != null && ltn.TypeName.Length > 0 )
            {
                if ( _classNameBackpt.ContainsKey( ltn.TypeName ) )
                {
                    var foundTree = hwObjectTree.FindNode( new TreePath( _classNameBackpt[ltn.TypeName] ) );
                    if (foundTree != null)
                    {
                        hwObjectTree.ScrollTo( foundTree );
                        hwObjectTree.SelectedNode = foundTree;
                    }
                }
            }
        }
    }
}
