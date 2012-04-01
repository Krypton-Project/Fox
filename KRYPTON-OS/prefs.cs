using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace krypto_os
{
    public partial class prefs : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public string MyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public int fileStage = 0;
        public string fontLib = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/options/desktop/font.stdl";
        public string toggleLib = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/options/desktop/toggles.stdl";
        public string expStyle = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/options/explorer/style.stdl";
        public bool fontChanged = false;
        public bool basicToggleChanged = false;
        public bool explorer_changed = false;
        public string SYS_PREFS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/options/";

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public prefs()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader(SYS_PREFS + "explorer/style.stdl");
            this.expViewStyle.Text = sr.ReadLine();
            sr.Dispose();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            //Add the the <control_name_here>.MouseDown() event:
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 100);               

            }
            this.Dock = DockStyle.Fill;
        }

        private void prefs_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(MyDocs + "/krypton/options/desktop/font.stdl"))
            {
                string ft = sr.ReadLine();
                this.fontSelection.Text = (string)ft;
                sr.Dispose();
            }            
            this.fontSizeItems.Value = (decimal)this.Font.SizeInPoints;
            for (int i = 0; i < fonts.Families.Length; i++)
            {
                this.fontSelection.Items.Add(fonts.Families[i].GetName(i));
            }

            this.applyButton.Enabled = false;
            fontChanged = false;
            basicToggleChanged = false;
        }

       

        private void applyButton_Click(object sender, EventArgs e)
        {
            
        }

        private void applyButton_Click_1(object sender, EventArgs e)
        {
            if (fontChanged == true)        /* Write to font.stdl */
            {
                File.Delete(fontLib);       /* Clear file from Hard Disk */
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fontLib))
                {
                    InstalledFontCollection fonts = new InstalledFontCollection();
                    string ffr = fontSelection.Text;
                    sw.WriteLine(ffr);
                    sw.WriteLine(fontSizeItems.Value.ToString());
                    sw.Dispose();
                }

                
            }

            if (basicToggleChanged == true)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(toggleLib))
                {
                    sw.Write(altSysF.CheckState);
                    sw.Dispose();
                }
            }

            if (this.explorer_changed == true)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(expStyle))
                {
                    sw.Write(expViewStyle.Text);
                    sw.Dispose();
                }
            }

            this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontSelection_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fontChanged = true;
            if (applyButton.Enabled == false)
                applyButton.Enabled = true;
        }

        private void fontSizeItems_ValueChanged_1(object sender, EventArgs e)
        {
            fontChanged = true;
            if (applyButton.Enabled == false)
                applyButton.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void altSysF_CheckedChanged_1(object sender, EventArgs e)
        {
            basicToggleChanged = true;
            if (applyButton.Enabled == false)
                applyButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void explorerSettings_Click(object sender, EventArgs e)
        {

        }

        private void expViewStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.explorer_changed = true;
            this.applyButton.Enabled = true;
        }
    }
}
