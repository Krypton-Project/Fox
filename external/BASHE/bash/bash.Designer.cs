namespace bash
{
    partial class bashGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bashGUI));
            this.formToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bottomFrame = new System.Windows.Forms.StatusStrip();
            this.frame = new System.Windows.Forms.MenuStrip();
            this.closeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.bashEmulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.shell1 = new bash.shell();
            this.frame.SuspendLayout();
            this.SuspendLayout();
            // 
            // formToolTip
            // 
            this.formToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.formToolTip.ToolTipTitle = "Bash Emulator";
            // 
            // bottomFrame
            // 
            this.bottomFrame.BackgroundImage = global::bash.Properties.Resources.gradient1;
            this.bottomFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottomFrame.Location = new System.Drawing.Point(0, 371);
            this.bottomFrame.Name = "bottomFrame";
            this.bottomFrame.Size = new System.Drawing.Size(587, 22);
            this.bottomFrame.TabIndex = 1;
            this.bottomFrame.Text = "statusStrip1";
            // 
            // frame
            // 
            this.frame.AutoSize = false;
            this.frame.BackColor = System.Drawing.Color.Silver;
            this.frame.BackgroundImage = global::bash.Properties.Resources.gradient1;
            this.frame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.frame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeWindow,
            this.maximizeWindow,
            this.minimizeWindow,
            this.bashEmulatorToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripSeparator1});
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.frame.Size = new System.Drawing.Size(587, 39);
            this.frame.TabIndex = 0;
            this.frame.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frame_MouseDoubleClick);
            this.frame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frame_MouseDown);
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.Color.Transparent;
            this.closeWindow.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow.ForeColor = System.Drawing.Color.White;
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(30, 35);
            this.closeWindow.Text = "&X";
            this.closeWindow.ToolTipText = "Exit Bash Emulator";
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // maximizeWindow
            // 
            this.maximizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.maximizeWindow.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizeWindow.ForeColor = System.Drawing.Color.White;
            this.maximizeWindow.Name = "maximizeWindow";
            this.maximizeWindow.Size = new System.Drawing.Size(31, 35);
            this.maximizeWindow.Text = "+";
            this.maximizeWindow.Click += new System.EventHandler(this.maximizeWindow_Click);
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.minimizeWindow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeWindow.ForeColor = System.Drawing.Color.White;
            this.minimizeWindow.Name = "minimizeWindow";
            this.minimizeWindow.Size = new System.Drawing.Size(26, 35);
            this.minimizeWindow.Text = "-";
            this.minimizeWindow.Click += new System.EventHandler(this.minimizeWindow_Click);
            // 
            // bashEmulatorToolStripMenuItem
            // 
            this.bashEmulatorToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bashEmulatorToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.bashEmulatorToolStripMenuItem.Image = global::bash.Properties.Resources.window_icon;
            this.bashEmulatorToolStripMenuItem.Name = "bashEmulatorToolStripMenuItem";
            this.bashEmulatorToolStripMenuItem.Size = new System.Drawing.Size(193, 35);
            this.bashEmulatorToolStripMenuItem.Text = "Bash Emulator Alpha 1";
            this.bashEmulatorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bashEmulatorToolStripMenuItem.ToolTipText = "BASH (Bourne Again Shell) Windows emulator.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // shell1
            // 
            this.shell1.BackColor = System.Drawing.Color.White;
            this.shell1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shell1.Location = new System.Drawing.Point(0, 39);
            this.shell1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shell1.Name = "shell1";
            this.shell1.Size = new System.Drawing.Size(587, 332);
            this.shell1.TabIndex = 2;
            this.shell1.Load += new System.EventHandler(this.shell1_Load);
            // 
            // bashGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 393);
            this.Controls.Add(this.shell1);
            this.Controls.Add(this.bottomFrame);
            this.Controls.Add(this.frame);
            this.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.frame;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "bashGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.frame.ResumeLayout(false);
            this.frame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frame;
        private System.Windows.Forms.ToolStripMenuItem closeWindow;
        private System.Windows.Forms.StatusStrip bottomFrame;
        private System.Windows.Forms.ToolTip formToolTip;
        private System.Windows.Forms.ToolStripMenuItem maximizeWindow;
        private System.Windows.Forms.ToolStripMenuItem bashEmulatorToolStripMenuItem;
        private shell shell1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem minimizeWindow;
    }
}

