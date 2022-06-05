namespace Note_Taking
{
    partial class frmNote
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSaveText = new System.Windows.Forms.ToolStripMenuItem();
            this.panNotearea = new System.Windows.Forms.Panel();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.ofdNote = new System.Windows.Forms.OpenFileDialog();
            this.sfdNote = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panNotearea.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewText,
            this.tsmOpenText,
            this.tsmSaveText});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(46, 24);
            this.tsmFile.Text = "File";
            // 
            // tsmNewText
            // 
            this.tsmNewText.Name = "tsmNewText";
            this.tsmNewText.Size = new System.Drawing.Size(224, 26);
            this.tsmNewText.Text = "New";
            this.tsmNewText.Click += new System.EventHandler(this.tsmNewText_Click);
            // 
            // tsmOpenText
            // 
            this.tsmOpenText.Name = "tsmOpenText";
            this.tsmOpenText.Size = new System.Drawing.Size(224, 26);
            this.tsmOpenText.Text = "Open";
            // 
            // tsmSaveText
            // 
            this.tsmSaveText.Name = "tsmSaveText";
            this.tsmSaveText.Size = new System.Drawing.Size(224, 26);
            this.tsmSaveText.Text = "Save";
            this.tsmSaveText.Click += new System.EventHandler(this.tsmSaveText_Click);
            // 
            // panNotearea
            // 
            this.panNotearea.Controls.Add(this.txtNote);
            this.panNotearea.Location = new System.Drawing.Point(30, 46);
            this.panNotearea.Name = "panNotearea";
            this.panNotearea.Size = new System.Drawing.Size(690, 438);
            this.panNotearea.TabIndex = 1;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(54, 51);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(602, 354);
            this.txtNote.TabIndex = 0;
            this.txtNote.Text = "";
            // 
            // ofdNote
            // 
            this.ofdNote.FileName = "ofdNote";
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.panNotearea);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNote";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmNote_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panNotearea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmNewText;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenText;
        private System.Windows.Forms.ToolStripMenuItem tsmSaveText;
        private System.Windows.Forms.Panel panNotearea;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.OpenFileDialog ofdNote;
        private System.Windows.Forms.SaveFileDialog sfdNote;
    }
}

