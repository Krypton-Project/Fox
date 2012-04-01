using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace krypto_os
{
    public partial class amethyst : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        int index = 0;
        public int column;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public amethyst()
        {
            InitializeComponent();
            this.line.Text = "Ln: 0";
            this.col.Text =  "Col: 0";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) 
        {
            this.WindowState = FormWindowState.Maximized;
            this.toolStripMenuItem1.Enabled = false;  
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            //Add the the <control_name_here>.MouseDown() event:
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 100);

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new amethyst()).Show(this.Parent);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void loadText(string text)
        {
            amethyst x = new amethyst();
            x.ShowDialog();
            x.textBox1.Text = text;
        }

        public static void loadNotice(string notice)
        {
            amethyst x = new amethyst();
            x.textBox1.ReadOnly = true;
            x.ShowDialog();
            x.textBox1.Text = notice;            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            index = textBox1.SelectionStart;
            string lline = textBox1.GetLineFromCharIndex(index).ToString();
            this.line.Text = "Ln: " + lline.ToString();

            /* Columns */
            int firstChar = textBox1.GetFirstCharIndexFromLine(index);
            column = index - firstChar;
            col.Text = "Col: " + column.ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void col_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
