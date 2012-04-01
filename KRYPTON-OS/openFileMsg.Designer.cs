namespace krypto_os
{
    partial class openFileMsg
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.phantomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.directory_ = new System.Windows.Forms.Button();
            this.file_ = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = global::krypto_os.Properties.Resources.gradient_2_1024x768;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.phantomToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(511, 34);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip_MouseDown);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.xToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(36, 30);
            this.xToolStripMenuItem.Text = "&X";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(36, 30);
            this.toolStripMenuItem1.Text = "+";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // phantomToolStripMenuItem
            // 
            this.phantomToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.phantomToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phantomToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.phantomToolStripMenuItem.Name = "phantomToolStripMenuItem";
            this.phantomToolStripMenuItem.Size = new System.Drawing.Size(88, 30);
            this.phantomToolStripMenuItem.Text = "OpenFile";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.file_);
            this.panel1.Controls.Add(this.directory_);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 179);
            this.panel1.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelBtn.Location = new System.Drawing.Point(406, 219);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(93, 31);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okBtn.Location = new System.Drawing.Point(312, 219);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(88, 31);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // directory_
            // 
            this.directory_.AutoSize = true;
            this.directory_.BackgroundImage = global::krypto_os.Properties.Resources.diagram_13;
            this.directory_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.directory_.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.directory_.Location = new System.Drawing.Point(3, 0);
            this.directory_.Name = "directory_";
            this.directory_.Size = new System.Drawing.Size(96, 115);
            this.directory_.TabIndex = 4;
            this.directory_.Text = "%s";
            this.directory_.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.directory_.UseVisualStyleBackColor = true;
            this.directory_.Visible = false;
            // 
            // file_
            // 
            this.file_.BackgroundImage = global::krypto_os.Properties.Resources.blank_document;
            this.file_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.file_.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.file_.Location = new System.Drawing.Point(105, 0);
            this.file_.Name = "file_";
            this.file_.Size = new System.Drawing.Size(96, 115);
            this.file_.TabIndex = 17;
            this.file_.Text = "%s";
            this.file_.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.file_.UseVisualStyleBackColor = true;
            this.file_.Visible = false;
            // 
            // openFileMsg
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 258);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "openFileMsg";
            this.Text = "openFileMsg";
            this.Load += new System.EventHandler(this.openFileMsg_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem phantomToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button directory_;
        private System.Windows.Forms.Button file_;
    }
}