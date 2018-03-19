namespace VSOExp
{
  partial class LayoutForm
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
            Aga.Controls.Tree.TreeColumn treeColumn1 = new Aga.Controls.Tree.TreeColumn();
            Aga.Controls.Tree.TreeColumn treeColumn2 = new Aga.Controls.Tree.TreeColumn();
            Aga.Controls.Tree.TreeColumn treeColumn3 = new Aga.Controls.Tree.TreeColumn();
            Aga.Controls.Tree.TreeColumn treeColumn4 = new Aga.Controls.Tree.TreeColumn();
            Aga.Controls.Tree.TreeColumn treeColumn5 = new Aga.Controls.Tree.TreeColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutForm));
            this.hwObjectTree = new Aga.Controls.Tree.TreeViewAdv();
            this.NameNode = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.SizeNode = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.PaddingNode = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.GapsNode = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.TypeNode = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            this.hwSortBy = new System.Windows.Forms.ComboBox();
            this.hwSortLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hwObjectTree
            // 
            this.hwObjectTree.BackColor = System.Drawing.SystemColors.Window;
            treeColumn1.Header = "Name";
            treeColumn1.Width = 500;
            treeColumn2.Header = " Size";
            treeColumn2.Width = 70;
            treeColumn3.Header = "Pad Bytes";
            treeColumn3.Width = 70;
            treeColumn4.Header = "Gaps";
            treeColumn4.Width = 70;
            treeColumn5.Header = "Type";
            treeColumn5.Width = 300;
            this.hwObjectTree.Columns.Add(treeColumn1);
            this.hwObjectTree.Columns.Add(treeColumn2);
            this.hwObjectTree.Columns.Add(treeColumn3);
            this.hwObjectTree.Columns.Add(treeColumn4);
            this.hwObjectTree.Columns.Add(treeColumn5);
            this.hwObjectTree.Cursor = System.Windows.Forms.Cursors.Default;
            this.hwObjectTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hwObjectTree.DragDropMarkColor = System.Drawing.Color.Black;
            this.hwObjectTree.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwObjectTree.FullRowSelect = true;
            this.hwObjectTree.KeepNodesExpanded = true;
            this.hwObjectTree.LineColor = System.Drawing.SystemColors.ControlDark;
            this.hwObjectTree.Location = new System.Drawing.Point(0, 40);
            this.hwObjectTree.Model = null;
            this.hwObjectTree.Name = "hwObjectTree";
            this.hwObjectTree.NodeControls.Add(this.NameNode);
            this.hwObjectTree.NodeControls.Add(this.SizeNode);
            this.hwObjectTree.NodeControls.Add(this.PaddingNode);
            this.hwObjectTree.NodeControls.Add(this.GapsNode);
            this.hwObjectTree.NodeControls.Add(this.TypeNode);
            this.hwObjectTree.SelectedNode = null;
            this.hwObjectTree.Size = new System.Drawing.Size(1064, 457);
            this.hwObjectTree.TabIndex = 2;
            this.hwObjectTree.UseColumns = true;
            this.hwObjectTree.NodeMouseDoubleClick += new System.EventHandler<Aga.Controls.Tree.TreeNodeAdvMouseEventArgs>(this.hwObjectTree_NodeMouseDoubleClick);
            // 
            // NameNode
            // 
            this.NameNode.DataPropertyName = "Text";
            this.NameNode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SizeNode
            // 
            this.SizeNode.Column = 1;
            this.SizeNode.DataPropertyName = "Size";
            this.SizeNode.Font = new System.Drawing.Font("Courier New", 8.25F);
            // 
            // PaddingNode
            // 
            this.PaddingNode.Column = 2;
            this.PaddingNode.DataPropertyName = "Padding";
            this.PaddingNode.Font = new System.Drawing.Font("Courier New", 8.25F);
            // 
            // GapsNode
            // 
            this.GapsNode.Column = 3;
            this.GapsNode.DataPropertyName = "Gaps";
            this.GapsNode.Font = new System.Drawing.Font("Courier New", 8.25F);
            // 
            // TypeNode
            // 
            this.TypeNode.Column = 4;
            this.TypeNode.DataPropertyName = "TypeName";
            this.TypeNode.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // hwSortBy
            // 
            this.hwSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hwSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hwSortBy.FormattingEnabled = true;
            this.hwSortBy.Items.AddRange(new object[] {
            "Name",
            "Size",
            "Padding",
            "Gaps"});
            this.hwSortBy.Location = new System.Drawing.Point(835, 10);
            this.hwSortBy.Name = "hwSortBy";
            this.hwSortBy.Size = new System.Drawing.Size(219, 21);
            this.hwSortBy.TabIndex = 3;
            this.hwSortBy.SelectedIndexChanged += new System.EventHandler(this.hwSortBy_SelectedIndexChanged);
            // 
            // hwSortLabel
            // 
            this.hwSortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hwSortLabel.AutoSize = true;
            this.hwSortLabel.Location = new System.Drawing.Point(797, 13);
            this.hwSortLabel.Name = "hwSortLabel";
            this.hwSortLabel.Size = new System.Drawing.Size(32, 13);
            this.hwSortLabel.TabIndex = 4;
            this.hwSortLabel.Text = "Sort :";
            // 
            // LayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 497);
            this.Controls.Add(this.hwSortLabel);
            this.Controls.Add(this.hwSortBy);
            this.Controls.Add(this.hwObjectTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LayoutForm";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Aga.Controls.Tree.TreeViewAdv hwObjectTree;
    private Aga.Controls.Tree.NodeControls.NodeTextBox NameNode;
    private Aga.Controls.Tree.NodeControls.NodeTextBox SizeNode;
    private Aga.Controls.Tree.NodeControls.NodeTextBox PaddingNode;
    private Aga.Controls.Tree.NodeControls.NodeTextBox TypeNode;
        private Aga.Controls.Tree.NodeControls.NodeTextBox GapsNode;
        private System.Windows.Forms.ComboBox hwSortBy;
        private System.Windows.Forms.Label hwSortLabel;
    }
}