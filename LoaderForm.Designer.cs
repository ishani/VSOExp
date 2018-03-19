namespace VSOExp
{
  partial class LoaderForm
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
            this.hwLoadPrepro = new System.Windows.Forms.Button();
            this.hwLoadLayout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hwOpenFilePrepro = new System.Windows.Forms.OpenFileDialog();
            this.hwOpenFileLayout = new System.Windows.Forms.OpenFileDialog();
            this.hwProgress = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // hwLoadPrepro
            // 
            this.hwLoadPrepro.Location = new System.Drawing.Point(330, 215);
            this.hwLoadPrepro.Name = "hwLoadPrepro";
            this.hwLoadPrepro.Size = new System.Drawing.Size(206, 36);
            this.hwLoadPrepro.TabIndex = 0;
            this.hwLoadPrepro.Text = "Load Preprocessor Output...";
            this.hwLoadPrepro.UseVisualStyleBackColor = true;
            this.hwLoadPrepro.Click += new System.EventHandler(this.hwLoadPrepro_Click);
            // 
            // hwLoadLayout
            // 
            this.hwLoadLayout.Location = new System.Drawing.Point(330, 215);
            this.hwLoadLayout.Name = "hwLoadLayout";
            this.hwLoadLayout.Size = new System.Drawing.Size(206, 36);
            this.hwLoadLayout.TabIndex = 1;
            this.hwLoadLayout.Text = "Load Object Layout Diagnostic...";
            this.hwLoadLayout.UseVisualStyleBackColor = true;
            this.hwLoadLayout.Click += new System.EventHandler(this.hwLoadLayout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Harry Denholm / ishani.org";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VSOExp.Properties.Resources.Binary_tree_icon;
            this.pictureBox1.Location = new System.Drawing.Point(598, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // hwOpenFilePrepro
            // 
            this.hwOpenFilePrepro.DefaultExt = "i";
            this.hwOpenFilePrepro.Filter = "Preprocessor Files|*.i|All Files|*.*";
            this.hwOpenFilePrepro.Title = "Open Preprocessor Output";
            // 
            // hwOpenFileLayout
            // 
            this.hwOpenFileLayout.DefaultExt = "txt";
            this.hwOpenFileLayout.Filter = "Class Layout Output|*.txt|All Files|*.*";
            // 
            // hwProgress
            // 
            this.hwProgress.Location = new System.Drawing.Point(598, 267);
            this.hwProgress.MarqueeAnimationSpeed = 32;
            this.hwProgress.Name = "hwProgress";
            this.hwProgress.Size = new System.Drawing.Size(128, 24);
            this.hwProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.hwProgress.TabIndex = 4;
            this.hwProgress.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::VSOExp.Properties.Resources.howto_prepro;
            this.pictureBox2.Location = new System.Drawing.Point(9, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(527, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 283);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.hwLoadPrepro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Preprocessor Output";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Find resulting .i files in the build output directory (next to your .obj output)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To generate, File -> Properties -> C/C++ -> Preprocessor :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.hwLoadLayout);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Object Layout Diagnostic";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Result is written to Output pane; copy/paste into a text file";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "To generate, File -> Properties -> C/C++ -> Command Line :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::VSOExp.Properties.Resources.howto_d1rep;
            this.pictureBox3.Location = new System.Drawing.Point(9, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(527, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(598, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 47);
            this.label6.TabIndex = 7;
            this.label6.Text = "VSOExp";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 304);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.hwProgress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Studio Output Explorer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button hwLoadPrepro;
    private System.Windows.Forms.Button hwLoadLayout;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.OpenFileDialog hwOpenFilePrepro;
    private System.Windows.Forms.OpenFileDialog hwOpenFileLayout;
    private System.Windows.Forms.ProgressBar hwProgress;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
    }
}

