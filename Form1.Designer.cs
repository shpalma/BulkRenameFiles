namespace BFRMain
{
   partial class frmBFR
   {
	  /// <summary>
	  ///  Required designer variable.
	  /// </summary>
	  private System.ComponentModel.IContainer components = null;

	  /// <summary>
	  ///  Clean up any resources being used.
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
	  ///  Required method for Designer support - do not modify
	  ///  the contents of this method with the code editor.
	  /// </summary>
	  private void InitializeComponent()
	  {
		 grpbSelection = new GroupBox();
		 rdbImg = new RadioButton();
		 rdbText = new RadioButton();
		 rdbVideo = new RadioButton();
		 lblFolder = new Label();
		 lblSelectedFolder = new Label();
		 rdbRegEx = new RadioButton();
		 txtbRegEx = new TextBox();
		 grpbSelection.SuspendLayout();
		 SuspendLayout();
		 // 
		 // grpbSelection
		 // 
		 grpbSelection.Controls.Add(txtbRegEx);
		 grpbSelection.Controls.Add(rdbRegEx);
		 grpbSelection.Controls.Add(lblSelectedFolder);
		 grpbSelection.Controls.Add(lblFolder);
		 grpbSelection.Controls.Add(rdbVideo);
		 grpbSelection.Controls.Add(rdbText);
		 grpbSelection.Controls.Add(rdbImg);
		 grpbSelection.Location = new Point(2, 4);
		 grpbSelection.Name = "grpbSelection";
		 grpbSelection.Size = new Size(786, 138);
		 grpbSelection.TabIndex = 0;
		 grpbSelection.TabStop = false;
		 grpbSelection.Text = "Selection";
		 // 
		 // rdbImg
		 // 
		 rdbImg.AutoSize = true;
		 rdbImg.Location = new Point(9, 22);
		 rdbImg.Name = "rdbImg";
		 rdbImg.Size = new Size(58, 19);
		 rdbImg.TabIndex = 0;
		 rdbImg.TabStop = true;
		 rdbImg.Text = "Image";
		 rdbImg.UseVisualStyleBackColor = true;
		 // 
		 // rdbText
		 // 
		 rdbText.AutoSize = true;
		 rdbText.Location = new Point(9, 49);
		 rdbText.Name = "rdbText";
		 rdbText.Size = new Size(46, 19);
		 rdbText.TabIndex = 1;
		 rdbText.TabStop = true;
		 rdbText.Text = "Text";
		 rdbText.UseVisualStyleBackColor = true;
		 // 
		 // rdbVideo
		 // 
		 rdbVideo.AutoSize = true;
		 rdbVideo.Location = new Point(8, 76);
		 rdbVideo.Name = "rdbVideo";
		 rdbVideo.Size = new Size(55, 19);
		 rdbVideo.TabIndex = 2;
		 rdbVideo.TabStop = true;
		 rdbVideo.Text = "Video";
		 rdbVideo.UseVisualStyleBackColor = true;
		 // 
		 // lblFolder
		 // 
		 lblFolder.AutoSize = true;
		 lblFolder.Location = new Point(7, 106);
		 lblFolder.Name = "lblFolder";
		 lblFolder.Size = new Size(93, 15);
		 lblFolder.TabIndex = 3;
		 lblFolder.Text = "Selected Folder: ";
		 // 
		 // lblSelectedFolder
		 // 
		 lblSelectedFolder.AutoSize = true;
		 lblSelectedFolder.Location = new Point(106, 106);
		 lblSelectedFolder.Name = "lblSelectedFolder";
		 lblSelectedFolder.Size = new Size(24, 15);
		 lblSelectedFolder.TabIndex = 4;
		 lblSelectedFolder.Text = "[...]";
		 // 
		 // rdbRegEx
		 // 
		 rdbRegEx.AutoSize = true;
		 rdbRegEx.Location = new Point(103, 25);
		 rdbRegEx.Name = "rdbRegEx";
		 rdbRegEx.Size = new Size(57, 19);
		 rdbRegEx.TabIndex = 5;
		 rdbRegEx.TabStop = true;
		 rdbRegEx.Text = "RegEx";
		 rdbRegEx.UseVisualStyleBackColor = true;
		 rdbRegEx.CheckedChanged += rdbRegEx_CheckedChanged;
		 // 
		 // txtbRegEx
		 // 
		 txtbRegEx.Location = new Point(166, 22);
		 txtbRegEx.Name = "txtbRegEx";
		 txtbRegEx.Size = new Size(235, 23);
		 txtbRegEx.TabIndex = 6;
		 txtbRegEx.Visible = false;
		 // 
		 // frmBFR
		 // 
		 AutoScaleDimensions = new SizeF(7F, 15F);
		 AutoScaleMode = AutoScaleMode.Font;
		 ClientSize = new Size(800, 450);
		 Controls.Add(grpbSelection);
		 MaximizeBox = false;
		 Name = "frmBFR";
		 Text = "Bulk file rename";
		 Load += frmBFR_Load;
		 grpbSelection.ResumeLayout(false);
		 grpbSelection.PerformLayout();
		 ResumeLayout(false);
	  }

	  #endregion

	  private GroupBox grpbSelection;
	  private TextBox txtbRegEx;
	  private RadioButton rdbRegEx;
	  private Label lblSelectedFolder;
	  private Label lblFolder;
	  private RadioButton rdbVideo;
	  private RadioButton rdbText;
	  private RadioButton rdbImg;
   }
}
