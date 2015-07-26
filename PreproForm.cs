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
  public partial class PreproForm : Form
  {
    ParsedPreprocessorOutput PreproOutput;

    private TreeModel _model = new TreeModel();

    public PreproForm(ParsedPreprocessorOutput ppOutput)
    {
      PreproOutput = ppOutput;

      InitializeComponent();

      BuildModelFromOutput();

      hwPreproTree.Model = _model;
      hwPreproTree.KeepNodesExpanded = true;
    }

    internal void BuildModelFromOutput()
    {
      _model.Nodes.Clear();

      _model.Root.Text = PreproOutput.RootNode.Path;

      foreach (PreproNode ppChildNode in PreproOutput.RootNode.Children)
      {
        ConvertPPNodeToTreeNode(ppChildNode, _model.Root);
      }

      hwStats.Text = String.Format("Files found : {0}", PreproOutput.NumFiles);
    }

    public TreePath GetPath(PreproTreeNode node)
    {
      {
        Stack<object> stack = new Stack<object>();
        while (node != null)
        {
          stack.Push(node);
          node = node.Parent as PreproTreeNode;
        }
        return new TreePath(stack.ToArray());
      }
    }

    internal void ConvertPPNodeToTreeNode(PreproNode ppNode, Node treeNode)
    {
      if ( ppNode.UIVisible )
      {
        PreproTreeNode NewNode = new PreproTreeNode();

        NewNode.DataNode = ppNode;
        NewNode.Text = ppNode.Path;
        NewNode.Line = ppNode.LineCounter.ToString();
        NewNode.LineDelta = ppNode.LineDelta.ToString();

        treeNode.Nodes.Add(NewNode);
        hwPreproTree.Model = _model;

        var poot = hwPreproTree.FindNode(GetPath(NewNode));
        poot.IsExpanded = ppNode.UIExpanded;

        foreach (PreproNode ppChildNode in ppNode.Children)
        {
          ConvertPPNodeToTreeNode(ppChildNode, NewNode);
        }
      }
    }

    private void hwPreproTree_SelectionChanged(object sender, EventArgs e)
    {
      var NodeSelection = hwPreproTree.SelectedNode;
      if (NodeSelection != null)
      {
        hwFilePathSel.Text = (NodeSelection.Tag as PreproTreeNode).Text;
      }
      else
      {
        hwFilePathSel.Text = "";
      }
    }

    internal void UpdateFilter()
    {
      string MatchString = hwFilterBox.Text.ToLower();
      bool DoMatch = MatchString.Length > 0;

      foreach (PreproNode ppChildNode in PreproOutput.LinearNodeList)
      {
        if (!DoMatch || ppChildNode.Path.Contains(MatchString))
        {
          PreproNode ppNode = ppChildNode;
          while (ppNode != null)
          {
            ppNode.UIVisible = true;
            ppNode = ppNode.Parent;
          }
        }
        else
        {
          ppChildNode.UIVisible = false;
        }
      }

      BuildModelFromOutput();
    }

    private void hwFilterTimer_Tick(object sender, EventArgs e)
    {
      UpdateFilter();
      hwFilterTimer.Stop();
    }

    private void filterBox_TextChanged(object sender, EventArgs e)
    {
      hwFilterTimer.Stop();
      hwFilterTimer.Start();
    }

    private void hwPreproTree_Expanded(object sender, TreeViewAdvEventArgs e)
    {
      PreproTreeNode ppNode = e.Node.Tag as PreproTreeNode;
      if ( ppNode != null )
      {
        ppNode.DataNode.UIExpanded = e.Node.IsExpanded;
      }

    }

    private void hwExpand_Click(object sender, EventArgs e)
    {
      foreach (PreproNode ppChildNode in PreproOutput.LinearNodeList)
      {
        if (ppChildNode.UIVisible)
          ppChildNode.UIExpanded = true;
      }
      BuildModelFromOutput();
    }

    private void hwCollapse_Click(object sender, EventArgs e)
    {
      foreach (PreproNode ppChildNode in PreproOutput.LinearNodeList)
      {
        if (ppChildNode.UIVisible)
          ppChildNode.UIExpanded = false;
      }
      BuildModelFromOutput();
    }
  }
}
