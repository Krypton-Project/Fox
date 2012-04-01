using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Windows.Forms.ComponentModel.Com2Interop;
using System.Windows.Forms.Design;
using System.Windows.Forms.Layout;
using System.Windows.Forms.PropertyGridInternal;
using System.Windows.Forms.VisualStyles;
using System.Web;
using System.Diagnostics.CodeAnalysis;
using System.Net.Cache;
using System.Net.Security;
using System.Net.NetworkInformation;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.Design.Serialization;
using System.Configuration.Assemblies;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.ProviderBase;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.Dynamic;
using System.Security.AccessControl;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Security.Util;
using System.Media;
using System.Net.Cache;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using System;
using System.Runtime.InteropServices;

namespace krypto_os
{
    public partial class saveFileDialog : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public static string root_dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/fox/";
        
        public saveFileDialog()
        {            
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {            
            _saveFile(fileName.Text, office_writer.getText());            
            this.Close();
        }

        public static void _saveFile(string file, string textToSave)
        {
            // Example #3: Write only some strings in an array to a file.
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(root_dir + file))
            {
                sw.Write(textToSave);
                sw.Dispose();
            }

        }

        private void menuStrip1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 100);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void xToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
