/**
 * Copyright (c) 2011 Edward Chernysh
 * 
 * This file is part of Krypton.

Krypton is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Krypton is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Krypton.  If not, see <http://www.gnu.org/licenses/>.

**/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using krypto_os.Properties;

namespace krypto_os
{
    public partial class office_writer : Form
    {
        private int childFormNumber = 0;
        public string root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/fox/filesystem";
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static string main_text;


        SaveFileDialog saveFile = new SaveFileDialog();
        string path;

        string fileTxtVal;

        public office_writer()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            office_writer childForm = new office_writer();
            childForm.Show(this);            
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Krypton Rich Files (*.krf)|*.krf";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                mainTextBox.LoadFile(FileName);
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            saveFile.Filter = "Krypton Rich Files (*.krf)|*.krf| RTF (*.rtf)|*.rtf";
            if (saveFile.ShowDialog(this) == DialogResult.OK)
            {
                path = saveFile.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                toolStripMenuItem1.Enabled = false;
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            main_text = mainTextBox.Text;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainTextBox.SelectAll();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new disclaimer()).Show(this);
        }

        private void office_writer_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void legalRtf_MouseDown(object sender, MouseEventArgs e)
        {
            //Add the the <control_name_here>.MouseDown() event:
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 100);
                toolStripMenuItem1.Enabled = true;
                
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            (new disclaimer()).Show(this);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            WebBrowser printer = new WebBrowser();
            printer.DocumentText = mainTextBox.Text;
            printer.Refresh();
            printer.Print();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainTextBox.Text = richTextBox2.Text;
        }

        private void legalRtf_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 100);
                

            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

            office_writer childForm = new office_writer();
            childForm.Show(this);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Krypton Rich Files (*.krf)|*.krf";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                mainTextBox.LoadFile(FileName);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            (new saveFileDialog()).ShowDialog();
        }

        public static string getText()
        {
            return main_text;
        }

        public string _getTxt()
        {
            string publicTxt = fileTxtVal;
            return publicTxt;
        }

        private void printToolStripButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
       
        public void loadDocument(string doc)
        {
            
        }

        public static void loadTextStrings(string docText)
        {
            office_writer x = new office_writer();            
            x.mainTextBox.Text += docText;
            x.ShowDialog();
            x.mainTextBox.ReadOnly = true;
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                mainTextBox.SaveFile(path);
            }
            else if (path == null)
            {
                saveFile.Filter = "Krypton Rich Files (*.krf)|*.krf| RTF (*.rtf)|*.rtf";
                if (saveFile.ShowDialog(this) == DialogResult.OK)
                {
                    path = saveFile.FileName;
                }
            }
        }


       
    }
}
