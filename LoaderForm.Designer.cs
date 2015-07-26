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
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // hwLoadPrepro
      // 
      this.hwLoadPrepro.Location = new System.Drawing.Point(12, 12);
      this.hwLoadPrepro.Name = "hwLoadPrepro";
      this.hwLoadPrepro.Size = new System.Drawing.Size(206, 36);
      this.hwLoadPrepro.TabIndex = 0;
      this.hwLoadPrepro.Text = "Load Preprocessor Output...";
      this.hwLoadPrepro.UseVisualStyleBackColor = true;
      this.hwLoadPrepro.Click += new System.EventHandler(this.hwLoadPrepro_Click);
      // 
      // hwLoadLayout
      // 
      this.hwLoadLayout.Location = new System.Drawing.Point(12, 54);
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
      this.label1.Location = new System.Drawing.Point(291, 143);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(133, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Harry Denholm / ishani.org";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::VSOExp.Properties.Resources.Binary_tree_icon;
      this.pictureBox1.Location = new System.Drawing.Point(293, 12);
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
      this.hwProgress.Location = new System.Drawing.Point(12, 96);
      this.hwProgress.MarqueeAnimationSpeed = 32;
      this.hwProgress.Name = "hwProgress";
      this.hwProgress.Size = new System.Drawing.Size(206, 14);
      this.hwProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.hwProgress.TabIndex = 4;
      this.hwProgress.Visible = false;
      // 
      // LoaderForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(433, 169);
      this.Controls.Add(this.hwProgress);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.hwLoadLayout);
      this.Controls.Add(this.hwLoadPrepro);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "LoaderForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Visual Studio Output Explorer";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
  }
}

