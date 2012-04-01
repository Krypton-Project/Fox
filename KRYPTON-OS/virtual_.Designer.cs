namespace krypto_os
{
    partial class virtual_
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
            this.legalRtf = new System.Windows.Forms.MenuStrip();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.legalRtf.SuspendLayout();
            this.SuspendLayout();
            // 
            // legalRtf
            // 
            this.legalRtf.BackgroundImage = global::krypto_os.Properties.Resources.gradient_2_1024x768;
            this.legalRtf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.legalRtf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.toolStripSeparator9});
            this.legalRtf.Location = new System.Drawing.Point(0, 0);
            this.legalRtf.Name = "legalRtf";
            this.legalRtf.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.legalRtf.Size = new System.Drawing.Size(573, 28);
            this.legalRtf.TabIndex = 1;
            this.legalRtf.Text = "MenuStrip";
            this.legalRtf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.legalRtf_MouseDown);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(31, 24);
            this.xToolStripMenuItem.Text = "&X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 24);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "The OS Version is: Krypton Fox Public BETA 1\r\n";
            // 
            // virtual_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 129);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.legalRtf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "virtual_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "virtual_";
            this.legalRtf.ResumeLayout(false);
            this.legalRtf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip legalRtf;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.Label label1;
    }
}