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
    public partial class phantom : Form
    {
        string url;
        private int childFormNumber = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public phantom()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
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
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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

        private void phantom_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;            
        }

        private void phantom_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Enabled = true;
            webBrowser1.BringToFront();
            this.AcceptButton = searchBtn;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            comboBox1.Text = "" + webBrowser1.Url;

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            // add browser tab
            TabPage newBrowserTab = new TabPage();

            // add an underlying browser
            WebBrowser newBrowser = new WebBrowser();
            newBrowser.Dock = DockStyle.Fill;
            newBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

            // add tab and a browser to the tab control/*
            newBrowserTab.Controls.Add(newBrowser);
            this.tabControl1.TabPages.Add(newBrowserTab);
            newBrowserTab.Name = comboBox1.Text;

            // navigate and focus new tab
            newBrowserTab.Select();
            newBrowser.Navigate("http://krypton-project.webs.com/start");
            newBrowser.Name = "webBrowser2";
            newBrowserTab.Controls.Add(statusStrip1);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        public void navigate(string url)
        {
            this.webBrowser1.Navigate(url);
        }

        public static void phantom_client(string url)
        {
            phantom x = new phantom();
            x.navigate(url);
            x.Show();
            x.navigate(url);
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            // add browser tab
            TabPage newBrowserTab = new TabPage();

            // add an underlying browser
            WebBrowser newBrowser = new WebBrowser();
            newBrowser.Dock = DockStyle.Fill;
            newBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

            // add tab and a browser to the tab control/*
            newBrowserTab.Controls.Add(newBrowser);
            this.tabControl1.TabPages.Add(newBrowserTab);
            newBrowserTab.Name = comboBox1.Text;

            // navigate and focus new tab
            newBrowserTab.Select();
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(((WebBrowser)
                tabControl1.SelectedTab.Controls[0]).StatusText);
            newBrowser.Name = "webBrowser2";
            e.Cancel = true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(comboBox1.Text);
            UrlBox.Text = comboBox1.Text;
                        //comboBox1.Items.Add(URLbox.Text);
            comboBox1.AutoCompleteCustomSource.Add(comboBox1.Text);
            comboBox1.Items.Add(UrlBox.Text);

            ///testing here <here>

            // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
            // You can modify the path if necessary.

            // Example #1: Write an array of strings to a file.
            // Create a string array that consists of three lines.
            //  string[] lines = {"comboBox1"};
            //System.IO.File.WriteAllLines(@"C:\Users\Utilisateur\Desktop\History.log", lines);


            // Example #2: Write one string to a text file.
            //string text = "A class is the most powerful data type in C#. Like structures, " +
            //  "a class defines the data and behavior of the data type. ";
            // System.IO.File.WriteAllText(@"C:\Users\Utilisateur\Desktop\History.log", text);

            // Example #3: Write only some strings in an array to a file.
            //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Utilisateur\Desktop\History.log"))
            {
                //  foreach (string line in lines)
                {
                    //  if (line.Contains("Second") == false)

                    {
                        //        file.WriteLine(comboBox1.Items);
                    }
                }
            }

            // Example #4: Append new text to an existing file
            //   using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Utilisateur\Desktop\History.log", true))
            {
                //file.WriteLine("This is a proto-type, if you haven't been authorized to use this proto-type, please get rid of it. A public release will be be on March 21st ~~kryptonX");
            }



            string text = comboBox1.Text;
            if (text != "")

                if (comboBox1.Items.Contains(comboBox1.Text))
                    if (comboBox1.FindString(text) != -1)

                        comboBox1.Text = (string)comboBox1.Items[comboBox1.FindString(text)];


            int diff_idx = comboBox1.Text.Length - text.Length;
            if (diff_idx > 0)

                comboBox1.Select(text.Length, diff_idx);
        }

        private void comboBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void fowardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void viewSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pagesource.launch_pagesource(((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentText);
        }

        public static void loadDocumentText(string documentText)
        {
            phantom x = new phantom();           
            x.Show();
            x.webBrowser1.DocumentText = documentText;
            x.webBrowser1.Refresh();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 1)
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);

            
        }
    }
}
