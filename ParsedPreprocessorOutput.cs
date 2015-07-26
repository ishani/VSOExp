using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VSOExp
{
  public class PreproTreeNode : Aga.Controls.Tree.Node
  {
    public PreproNode DataNode;

    private string _line;
    public virtual string Line
    {
      get { return _line; }
      set
      {
        if (_line != value)
        {
          _line = value;
          NotifyModel();
        }
      }
    }

    private string _lineDelta;
    public virtual string LineDelta
    {
      get { return _lineDelta; }
      set
      {
        if (_lineDelta != value)
        {
          _lineDelta = value;
          NotifyModel();
        }
      }
    }
  }

  public class PreproNode
  {
    public string Path;
    public Int64 LineCounter;
    public Int64 LineDelta;

    public Int32 LinearIndex;
    public Int32 Depth;
    public PreproNode Parent;
    public List<PreproNode> Children;

    public Boolean UIVisible;
    public Boolean UIExpanded;

    public PreproNode()
    {
      Path = "";
      LineCounter = 1;
      LineDelta = 0;

      LinearIndex = -1;
      Depth = 0;
      Parent = null;
      Children = new List<PreproNode>();

      UIVisible = true;
      UIExpanded = false;
    }

    public PreproNode Add(string path)
    {
      PreproNode NewNode = new PreproNode();

      NewNode.Parent = this;
      NewNode.Path = path;

      PreproNode ParentWalk = NewNode.Parent;
      while (ParentWalk != null)
      {
        NewNode.Depth++;
        ParentWalk = ParentWalk.Parent;
      }

      Children.Add(NewNode);

      return NewNode;
    }

  }

  public class ParsedPreprocessorOutput
  {
    public PreproNode RootNode;
    public Int32 NumFiles;
    public Int32 TotalLines;

    public List<PreproNode> LinearNodeList;

    public ParsedPreprocessorOutput()
    {
    }

    public async Task<bool> ParseFromFile(string filename)
    {
      RootNode = new PreproNode();
      NumFiles = 0;
      TotalLines = 0;

      PreproNode lNode = RootNode;

      int lLastLineNumber = -1;
      string lLastLinePath = "";

      LinearNodeList = new List<PreproNode>();
      Dictionary<String, Queue<PreproNode>> NodePathLookup = new Dictionary<string, Queue<PreproNode>>();

      foreach (string line in File.ReadLines(filename))
      {
        TotalLines++;

        string InputLine = line.Trim().Replace("\\\\", "\\").Replace("\\", "/");
        if (InputLine.Length == 0)
          continue;

        if (InputLine.StartsWith("#line "))
        {
          var lStringBits = InputLine.Split(new char[] { ' ' }, 3);

          int lLineNum = Int32.Parse(lStringBits[1]);

          string lFilePath = lStringBits[2].Trim(new char[] { ' ', '\"' }).ToLower();

          if (lLineNum == 1)
          {
            lNode = lNode.Add(lFilePath);
            NumFiles++;

            lNode.LinearIndex = LinearNodeList.Count;
            LinearNodeList.Add(lNode);

            lNode.LineCounter = TotalLines;

            if (NodePathLookup.ContainsKey(lFilePath))
            {
              NodePathLookup[lFilePath].Enqueue(lNode);
            }
            else
            {
              Queue<PreproNode> lNewQ = new Queue<PreproNode>();
              lNewQ.Enqueue(lNode);

              NodePathLookup.Add(lFilePath, lNewQ);

              await Task.Yield();
            }
          }
          else
          {
            lNode = NodePathLookup[lFilePath].Peek();
          }

          lLastLinePath = lFilePath;
          lLastLineNumber = lLineNum;
        }
        else
        {
          lLastLinePath = "";
          lLastLineNumber = -1;
        }
      }

      SumUpDeltas(RootNode);

      return true;
    }

    internal void SumUpDeltas( PreproNode ppNode )
    {
      ppNode.LineDelta = (TotalLines - ppNode.LineCounter);
      
      foreach (PreproNode ppSearch in LinearNodeList)
      {
        if (ppSearch.Depth == 1)
          ppSearch.UIExpanded = true;

        if ( ppSearch.Depth <= ppNode.Depth )
        {
          if ( ppSearch.LineCounter > ppNode.LineCounter )
          {
            ppNode.LineDelta = (ppSearch.LineCounter - ppNode.LineCounter);
            break;
          }
        }
      }

      foreach( PreproNode ppChildNode in ppNode.Children )
      {
        SumUpDeltas(ppChildNode);
      }
    }

  }
}
