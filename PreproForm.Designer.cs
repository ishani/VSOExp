namespace VSOExp
{
  partial class PreproForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      Aga.Controls.Tree.TreeColumn treeColumn1 = new Aga.Controls.Tree.TreeColumn();
      Aga.Controls.Tree.TreeColumn treeColumn2 = new Aga.Controls.Tree.TreeColumn();
      Aga.Controls.Tree.TreeColumn treeColumn3 = new Aga.Controls.Tree.TreeColumn();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreproForm));
      this.hwBackingPanel = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.hwCollapse = new System.Windows.Forms.Button();
      this.hwExpand = new System.Windows.Forms.Button();
      this.hwFilterBox = new System.Windows.Forms.TextBox();
      this.hwFilePathSel = new System.Windows.Forms.TextBox();
      this.hwStats = new System.Windows.Forms.Label();
      this.hwPreproTree = new Aga.Controls.Tree.TreeViewAdv();
      this.PathNode = new Aga.Controls.Tree.NodeControls.NodeTextBox();
      this.LineNode = new Aga.Controls.Tree.NodeControls.NodeTextBox();
      this.DeltaNode = new Aga.Controls.Tree.NodeControls.NodeTextBox();
      this.hwFilterTimer = new System.Windows.Forms.Timer(this.components);
      this.hwBackingPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // hwBackingPanel
      // 
      this.hwBackingPanel.Controls.Add(this.label1);
      this.hwBackingPanel.Controls.Add(this.hwCollapse);
      this.hwBackingPanel.Controls.Add(this.hwExpand);
      this.hwBackingPanel.Controls.Add(this.hwFilterBox);
      this.hwBackingPanel.Controls.Add(this.hwFilePathSel);
      this.hwBackingPanel.Controls.Add(this.hwStats);
      this.hwBackingPanel.Controls.Add(this.hwPreproTree);
      this.hwBackingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.hwBackingPanel.Location = new System.Drawing.Point(0, 0);
      this.hwBackingPanel.Name = "hwBackingPanel";
      this.hwBackingPanel.Padding = new System.Windows.Forms.Padding(0, 60, 0, 40);
      this.hwBackingPanel.Size = new System.Drawing.Size(1091, 638);
      this.hwBackingPanel.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 609);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Filter String :";
      // 
      // hwCollapse
      // 
      this.hwCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.hwCollapse.Location = new System.Drawing.Point(839, 606);
      this.hwCollapse.Name = "hwCollapse";
      this.hwCollapse.Size = new System.Drawing.Size(117, 23);
      this.hwCollapse.TabIndex = 6;
      this.hwCollapse.Text = "Collapse All Visible";
      this.hwCollapse.UseVisualStyleBackColor = true;
      this.hwCollapse.Click += new System.EventHandler(this.hwCollapse_Click);
      // 
      // hwExpand
      // 
      this.hwExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.hwExpand.Location = new System.Drawing.Point(962, 606);
      this.hwExpand.Name = "hwExpand";
      this.hwExpand.Size = new System.Drawing.Size(117, 23);
      this.hwExpand.TabIndex = 5;
      this.hwExpand.Text = "Expand All Visible";
      this.hwExpand.UseVisualStyleBackColor = true;
      this.hwExpand.Click += new System.EventHandler(this.hwExpand_Click);
      // 
      // hwFilterBox
      // 
      this.hwFilterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.hwFilterBox.Location = new System.Drawing.Point(83, 606);
      this.hwFilterBox.Name = "hwFilterBox";
      this.hwFilterBox.Size = new System.Drawing.Size(325, 20);
      this.hwFilterBox.TabIndex = 4;
      this.hwFilterBox.TextChanged += new System.EventHandler(this.filterBox_TextChanged);
      // 
      // hwFilePathSel
      // 
      this.hwFilePathSel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.hwFilePathSel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.hwFilePathSel.Location = new System.Drawing.Point(12, 30);
      this.hwFilePathSel.Name = "hwFilePathSel";
      this.hwFilePathSel.ReadOnly = true;
      this.hwFilePathSel.Size = new System.Drawing.Size(1067, 20);
      this.hwFilePathSel.TabIndex = 3;
      // 
      // hwStats
      // 
      this.hwStats.AutoSize = true;
      this.hwStats.Location = new System.Drawing.Point(12, 9);
      this.hwStats.Name = "hwStats";
      this.hwStats.Size = new System.Drawing.Size(35, 13);
      this.hwStats.TabIndex = 2;
      this.hwStats.Text = "label1";
      // 
      // hwPreproTree
      // 
      this.hwPreproTree.BackColor = System.Drawing.SystemColors.Window;
      treeColumn1.Header = "Path";
      treeColumn1.Width = 900;
      treeColumn2.Header = " Line";
      treeColumn2.Width = 75;
      treeColumn3.Header = " Delta";
      treeColumn3.Width = 75;
      this.hwPreproTree.Columns.Add(treeColumn1);
      this.hwPreproTree.Columns.Add(treeColumn2);
      this.hwPreproTree.Columns.Add(treeColumn3);
      this.hwPreproTree.Cursor = System.Windows.Forms.Cursors.Default;
      this.hwPreproTree.Dock = System.Windows.Forms.DockStyle.Fill;
      this.hwPreproTree.DragDropMarkColor = System.Drawing.Color.Black;
      this.hwPreproTree.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.hwPreproTree.FullRowSelect = true;
      this.hwPreproTree.KeepNodesExpanded = true;
      this.hwPreproTree.LineColor = System.Drawing.SystemColors.ControlDark;
      this.hwPreproTree.Location = new System.Drawing.Point(0, 60);
      this.hwPreproTree.Model = null;
      this.hwPreproTree.Name = "hwPreproTree";
      this.hwPreproTree.NodeControls.Add(this.PathNode);
      this.hwPreproTree.NodeControls.Add(this.LineNode);
      this.hwPreproTree.NodeControls.Add(this.DeltaNode);
      this.hwPreproTree.SelectedNode = null;
      this.hwPreproTree.Size = new System.Drawing.Size(1091, 538);
      this.hwPreproTree.TabIndex = 1;
      this.hwPreproTree.UseColumns = true;
      this.hwPreproTree.SelectionChanged += new System.EventHandler(this.hwPreproTree_SelectionChanged);
      this.hwPreproTree.Expanded += new System.EventHandler<Aga.Controls.Tree.TreeViewAdvEventArgs>(this.hwPreproTree_Expanded);
      // 
      // PathNode
      // 
      this.PathNode.DataPropertyName = "Text";
      // 
      // LineNode
      // 
      this.LineNode.Column = 1;
      this.LineNode.DataPropertyName = "Line";
      // 
      // DeltaNode
      // 
      this.DeltaNode.Column = 2;
      this.DeltaNode.DataPropertyName = "LineDelta";
      // 
      // hwFilterTimer
      // 
      this.hwFilterTimer.Interval = 1000;
      this.hwFilterTimer.Tick += new System.EventHandler(this.hwFilterTimer_Tick);
      // 
      // PreproForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1091, 638);
      this.Controls.Add(this.hwBackingPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "PreproForm";
      this.hwBackingPanel.ResumeLayout(false);
      this.hwBackingPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel hwBackingPanel;
    private Aga.Controls.Tree.TreeViewAdv hwPreproTree;
    private Aga.Controls.Tree.NodeControls.NodeTextBox PathNode;
    private Aga.Controls.Tree.NodeControls.NodeTextBox LineNode;
    private System.Windows.Forms.Label hwStats;
    private Aga.Controls.Tree.NodeControls.NodeTextBox DeltaNode;
    private System.Windows.Forms.TextBox hwFilePathSel;
    private System.Windows.Forms.TextBox hwFilterBox;
    private System.Windows.Forms.Timer hwFilterTimer;
    private System.Windows.Forms.Button hwCollapse;
    private System.Windows.Forms.Button hwExpand;
    private System.Windows.Forms.Label label1;
  }
}