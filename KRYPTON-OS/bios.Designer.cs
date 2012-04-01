namespace krypto_os
{
    partial class bios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guiLabel = new System.Windows.Forms.LinkLabel();
            this.cliLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.guiLabel);
            this.groupBox1.Controls.Add(this.cliLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Univers", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(133, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KryptiX";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // guiLabel
            // 
            this.guiLabel.AutoSize = true;
            this.guiLabel.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.guiLabel.Location = new System.Drawing.Point(190, 111);
            this.guiLabel.Name = "guiLabel";
            this.guiLabel.Size = new System.Drawing.Size(297, 23);
            this.guiLabel.TabIndex = 2;
            this.guiLabel.TabStop = true;
            this.guiLabel.Text = "1: GUI (Graphical User Interface)";
            this.guiLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            this.guiLabel.Click += new System.EventHandler(this.guiLabel_Click);
            this.guiLabel.Enter += new System.EventHandler(this.linkLabel2_Enter);
            // 
            // cliLabel
            // 
            this.cliLabel.AutoSize = true;
            this.cliLabel.ForeColor = System.Drawing.Color.Snow;
            this.cliLabel.LinkColor = System.Drawing.Color.White;
            this.cliLabel.Location = new System.Drawing.Point(190, 164);
            this.cliLabel.Name = "cliLabel";
            this.cliLabel.Size = new System.Drawing.Size(293, 23);
            this.cliLabel.TabIndex = 1;
            this.cliLabel.TabStop = true;
            this.cliLabel.Text = "2: CLI (Command Line Interface)";
            this.cliLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cliLabel_LinkClicked);
            this.cliLabel.Enter += new System.EventHandler(this.linkLabel1_Enter);
            this.cliLabel.Leave += new System.EventHandler(this.linkLabel1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select Your Interface (Tab to navigate)";
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(2, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(10, 10);
            this.button5.TabIndex = 6;
            this.button5.TabStop = false;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(666, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 39);
            this.button4.TabIndex = 10;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(490, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "Shutdown";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(290, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reboot";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(89, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 39);
            this.button6.TabIndex = 7;
            this.button6.Text = "New Desktop";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            // 
            // bios
            // 
            this.AcceptButton = this.button5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(937, 573);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.bios_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bios_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel guiLabel;
        private System.Windows.Forms.LinkLabel cliLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
    }
}