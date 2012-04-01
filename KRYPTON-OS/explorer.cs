using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;


namespace krypto_os
{
    public partial class explorer : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public static string launch_directory;
        public string SYS_PREFS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/options/";
        public explorer()
        {
            InitializeComponent();
            using (System.IO.StreamReader sr = new System.IO.StreamReader(SYS_PREFS + "explorer/style.stdl"))
            {
                var vr = sr.ReadLine();
                if (vr == "Details")
                    this.listView1.View = View.Details;
                else if (vr == "SmallIcon")
                    this.listView1.View = View.SmallIcon;
                else if (vr == "LargeIcon")
                    this.listView1.View = View.LargeIcon;
                else if (vr == "List")
                    this.listView1.View = View.List;
                else if (vr == "Tile")
                    this.listView1.View = View.Tile;

                sr.Dispose();
            }                    
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(launch_directory);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        void treeView1_NodeMouseClick(object sender,
    TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
            {new ListViewItem.ListViewSubItem(item, "Directory"), 
             new ListViewItem.ListViewSubItem(item, 
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);                
                subItems = new ListViewItem.ListViewSubItem[]
            { new ListViewItem.ListViewSubItem(item, "File"), 
             new ListViewItem.ListViewSubItem(item, 
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void explorer_Load(object sender, EventArgs e)
        {
            this.treeView1.NodeMouseClick +=
    new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            PopulateTreeView();  
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

        public static void launch(string directory)
        {
            explorer t_explorer = new explorer();
            launch_directory = directory;
            t_explorer.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
