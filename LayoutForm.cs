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
    
    private TreeModel _model = new TreeModel();

    public LayoutForm(LayoutLoaderOutput llOutput)
    {
      LayoutOutput = llOutput;

      InitializeComponent();

      BuildModelFromOutput();

      hwObjectTree.Model = _model;
      hwObjectTree.KeepNodesExpanded = true;
    }

    internal void BuildModelFromOutput()
    {
      _model.Nodes.Clear();

      var SortedDict = LayoutOutput.Classes.OrderByDescending(key => key.Value.Size);

      foreach (var nameLayoutPair in SortedDict)
      {
        if (nameLayoutPair.Value.Members.Count > 0 && nameLayoutPair.Value.Size > 0)
        {
          LayoutTreeNode NewNode = new LayoutTreeNode();
          NewNode.Text = nameLayoutPair.Key;

          NewNode.Size = nameLayoutPair.Value.Size.ToString();
          NewNode.Padding = nameLayoutPair.Value.TotalAlignmentPadding.ToString();

          _model.Root.Nodes.Add(NewNode);

          foreach ( var LayoutClassMember in nameLayoutPair.Value.Members )
          {
            LayoutTreeNode MemberNode = new LayoutTreeNode();
            MemberNode.Text = LayoutClassMember.Name;
            MemberNode.Size = LayoutClassMember.Size.ToString();

            string MemberType = LayoutClassMember.Type;
            if ( MemberType != null )
            {
              if (LayoutOutput.Classes.ContainsKey(MemberType))
              {
                MemberNode.Padding = "(" + LayoutOutput.Classes[MemberType].TotalAlignmentPadding + ")";
              }

              MemberNode.TypeName = MemberType;
            }


            NewNode.Nodes.Add(MemberNode);
          }
        }

      }
    }
  }
}
