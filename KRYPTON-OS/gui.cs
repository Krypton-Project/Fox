/**
 *  Copyright © Edward Chernysh 
 * 
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.

 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.

 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
**/

#define DATA_AVAILABLE
#define CANNOT_LOAD_FILES

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.IO;
using bash;

namespace krypto_os
{
    public partial class gui : Form
    {        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public string MyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public string SYS_PREFS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/options/";
        public int fileStage = 0;
        public string root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/fox/filesystem";
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public bool Dragging;
        public int mousex;        
        public int mousey;
        public gui() { InitializeComponent(); }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bash.bashGUI.BASH();
        }

        private void gui_Load(object sender, EventArgs e)
        {
            DateTimer.Start();      /* Start Never Ending timer that controls the time label */

            try
            {

                this.BringToFront();
                this.BackgroundImage = null;
                this.BackColor = Color.SteelBlue;
                this.newfile.DoubleClick += new EventHandler(newfile_DoubleClick);

                /* Check for Directories */

                if (Directory.Exists(MyDocs + "/krypton/") != true)
                {
                    /* Create 1st wave of directories */
                    (new about()).Show(this);
                    Directory.CreateDirectory(MyDocs + "/krypton");
                    Directory.CreateDirectory(MyDocs + "/krypton/fox");
                    Directory.CreateDirectory(MyDocs + "/krypton/fox/filesystem");
                    Directory.CreateDirectory(MyDocs + "/krypton/options");
                    Directory.CreateDirectory(MyDocs + "/krypton/options/desktop");
                    Directory.CreateDirectory(root + "/docs");
                    Directory.CreateDirectory(root + "/images");
                    Directory.CreateDirectory(root + "/music");
                    Directory.CreateDirectory(root + "/private");
                    Directory.CreateDirectory(root + "/private/applications");
                    Directory.CreateDirectory(root + "/private/bin");
                    Directory.CreateDirectory(root + "/private/core");
                    Directory.CreateDirectory(root + "/private/lib");
                    Directory.CreateDirectory(root + "/private/storage");
                    Directory.CreateDirectory(root + "/private/winlibs");       // This directory will only be created for the on-top GUI

                    /* Create 1st wave of files (Standard Library) [.stdl] */

                    File.Create(MyDocs + "/krypton/options/desktop/prefs.stdl");
                    File.Create(MyDocs + "/krypton/options/desktop/img.stdl");

                    /* Add default values */

                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(MyDocs + "/krypton/options/desktop/wallpaper.stdl"))
                    {
                        sw.WriteLine("default.png");
                        sw.WriteLine("Stretch");
                        sw.Dispose();
                    }

                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(MyDocs + "/krypton/options/desktop/font.stdl"))
                    {
                        sw.WriteLine(this.Font.Name);
                        sw.WriteLine("8");
                        sw.Dispose();
                    }

                    Directory.CreateDirectory(MyDocs + "/krypton/options/explorer");

                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(MyDocs + "/krypton/options/explorer/style.stdl"))
                    {
                        sw.WriteLine("Details");
                        sw.Dispose();
                    }
                }
                else
                {
                    /// <summary>
                    ///  From here on (before the closing syntax) the code will load the user's preferences
                    ///  this code is quite badly written. And it not "to the point".
                    ///  This code is an exception to the license. You may use and modify the
                    ///  following code freely. Without even stating where you got it from.
                    ///  ~ Edward Chernysh
                    /// </summary>
                    using (StreamReader sr = new StreamReader(SYS_PREFS + "/desktop/faont.stdl"))
                    {
                        sr.Dispose();
                    }

                }

               
            }
            catch
            {
               /* MasterKillSwitch(
                "Krypton Operating System Fox " + Application.ProductName.ToString() + 
               " " + Application.ProductVersion.ToString() +
                " has encountered a fatal error.\nFox entered this state to protect your system."
                + "\nDrivers have been disabled and opened files have been saved." +
                "\nThis error was caused by a overflow in the Graphical User Interface.");  */
            }
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void docWriterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new office_writer()).Show(panel1);
        }

        private void phantomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new phantom()).Show(panel1);
        }

        private void gui_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new filesystem()).Show(panel1);
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            startMenu.Visible = true;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToolStripSeparator separate = new ToolStripSeparator();
            taskbar.Items.Add(separate);
            ToolStripButton terminalBtn = new ToolStripButton();
            taskbar.Items.Add(terminalBtn);
            terminalBtn.Text = "Terminal";
            terminalBtn.Click += new EventHandler(terminalBtn_Click);
            bash.bashGUI.BASH();  
        }

        void terminalBtn_Click(object sender, EventArgs e)
        {
            
            foreach (Form form in OwnedForms)
            {
                if (form.Name == "terminal.cs")
                {
                    form.BringToFront();
                    form.Select();
                    return;
                }
            } 
        }

        void gui_Deactivate(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new office_writer()).ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new about()).Show(panel1);
        }

        private void aPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new error_msg()).ShowDialog();
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //
            tileItem.Checked = false;
            zoomItem.Checked = false;
            stretchItem.Checked = false;
            noneItem.Checked = false;
            //
            tileItem.Checked = true;

        }

        private void zoomItem_Click(object sender, EventArgs e)
        {
            
            //
            tileItem.Checked = false;
            zoomItem.Checked = false;
            stretchItem.Checked = false;
            noneItem.Checked = false;
            //
            zoomItem.Checked = true;

        }

        private void stretchItem_Click(object sender, EventArgs e)
        {
            
            //
            tileItem.Checked = false;
            zoomItem.Checked = false;
            stretchItem.Checked = false;
            noneItem.Checked = false;
            //
            stretchItem.Checked = true;
        }

        private void noneItem_Click(object sender, EventArgs e)
        {
           
            tileItem.Checked = false;
            zoomItem.Checked = false;
            stretchItem.Checked = false;
            noneItem.Checked = false;
            //
            noneItem.Checked = true;
        }

        private void kryptonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new confirm_update()).ShowDialog();
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button txtFile1 = new Button();
            txtFile1.Text = "textfile";
            txtFile1.FlatStyle = example.FlatStyle;
            txtFile1.BackgroundImage = example.BackgroundImage;

        }
       
        private void terminalBtn_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_MouseDown(object sender, MouseEventArgs e)
        {
            //Add the the <control_name_here>.MouseDown() event:
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 100);
                toolStripMenuItem2.Enabled = true;               
                
            }
            this.Dock = DockStyle.Fill;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.toolStripMenuItem2.Enabled = false;            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripStatusLabel3_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void toolStripStatusLabel3_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            startMenu.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Select();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (startMenu.Visible == false)
            {
                startMenu.Visible = true;
                startMenu.Select();
            }

            else startMenu.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            (new filesystem()).Show(panel1);
            startMenu.Visible = false;
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bash.bashGUI.BASH();
            startMenu.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (sys_managers.NUMBER_OF_LOADED_DESKTOPS < 1)
                this.Close();
            else Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*(new phantom()).Show(panel1);
            startMenu.Visible = false;
             * */
         
        }       

        private void button5_Click(object sender, EventArgs e)
        {
            (new office_writer()).Show(panel1);
        }

        private void legalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            legal();
        }

        private static void return_error()
        {
            (new error_msg()).ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            phantom.phantom_client("http://code.google.com/atomic-dev");
        }

        private static void legal()
        {
            (new disclaimer()).ShowDialog();
        }

        private static void virtual_m()
        {
            (new virtual_()).ShowDialog();
        }

        private static void no_iso()
        {
            (new install_iso_error()).ShowDialog();
        }

        private void gui_Deactivate_1(object sender, EventArgs e)
        {
            menuStrip.BringToFront();
        }

        private void wallpaperCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new wallpapercredits()).ShowDialog();
        }

        private void aboutTHISOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new virtual_()).ShowDialog();
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new html()).Show(this);
        }

        private void welcome_Click(object sender, EventArgs e)
        {
            office_writer.loadTextStrings(richTextBox1.Text);
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            phantom.phantom_client("http://krypton-project.webs.com");
        }

        private void workbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new amethyst()).Show(this);
        }

        private void newfile_MouseDown(object sender, MouseEventArgs e)
        {
            //Add the the <control_name_here>.MouseDown() event:
            if (e.Button == MouseButtons.Left)
            {
                Dragging = true;
                mousex = -e.X;
                mousey = -e.Y;
                
                int clipleft = this.PointToClient(MousePosition).X - newfile.Location.X;
                int cliptop = this.PointToClient(MousePosition).Y - newfile.Location.Y;
                int clipwidth = this.ClientSize.Width - (newfile.Width - clipleft);
                int clipheight = this.ClientSize.Height - (newfile.Height - cliptop);
                Cursor.Clip = this.RectangleToScreen(new Rectangle(clipleft, cliptop, clipwidth, clipheight));
                newfile.Invalidate();
            }
        }

        private void newfile_Click(object sender, EventArgs e)
        {
            if (Dragging)
                this.newfile.Enabled = false;
            else
            {
                amethyst.loadText("== Heading == ");
            }
            
        }

        private void newfile_DoubleClick(object sender, EventArgs e)
        {
            amethyst.loadText("== Heading == ");
        }

        private void textFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (fileStage == 0)
            {
                newfile.Visible = true;
                fileStage++;
            }
            else if (fileStage < 0)
            {
                
            }
        }

        private void newfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point MPosition = new Point();
                MPosition = this.PointToClient(MousePosition);
                MPosition.Offset(mousex, mousey);
                newfile.Location = MPosition;
            } 
        }

        private void newfile_MouseUp(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Dragging = false;
                Cursor.Clip = System.Drawing.Rectangle.Empty;
                newfile.Invalidate();
            }
            else if (!Dragging)
            {
                newfile.Enabled = true;
                amethyst.loadText("== Heading == ");
            }
            else
            {
                newfile.Enabled = true;
            }
            newfile.Enabled = true;
        }

        public void create_file()
        {

        }

        private void newfile_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void DateTime_Tick(object sender, EventArgs e)
        {
            /* Clock */

            this.dateTimeLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new prefs()).ShowDialog(this);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorer.launch(SYS_PREFS);
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gui_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sys_managers.NUMBER_OF_LOADED_DESKTOPS < 1)
                this.Close();
            else Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new prefs()).Show(this);
        }

        private void foxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            explorer.launch(root + "/");
        }

        public virtual void MasterKillSwitch(string MESSAGE)
        {
            /**
             * 
             *  This should never be called externally or statically!
             *  This is only used in the case of a FATAL (deadly, catastrophic, destructive, disastrous...) errors!
             *  MasterKillSwitch() removes all internal and external controls sitting on-top
             *  of the Graphical User Interface and flashes a STRING of text onto the "screen of death".
             *  
             *  To exit this realm of Krypton Operating System Fox restart the System (or the Application assuming the
             *  user is running Krypton Operating System Fox ON-TOP of an existing Windows System). If Krypton Operating System Fox loads 
             *  this screen again consider the following:
             *      - Uninstalling the program that was installed before any of this started.
             *      - Seek help online
             *      - Boot Command-Line and try and resolve the problem[s] (developers and experts only! You may do more damage than good!).
             *      - Reinstalling the Operating System and/or Application.
             *
            **/
            this.Controls.Clear();      // Remove ALL controls from the GUI (panel)
            RichTextBox lbl = new RichTextBox();    // Declare a new RichTextBox as lbl. ?? I know.
            lbl.ReadOnly = true;                // Boring and obvious stuff {
            lbl.Multiline = true;               // ...   
            lbl.Font = new Font(lbl.Font.FontFamily, (float)16.25,      // ...
lbl.Font.Style);        // ...
            lbl.Text = "== Krypton Operating System Fox Crash Recovery ==\n\n"; // ...
            lbl.Text += MESSAGE;             // ...
            lbl.Dock = DockStyle.Fill;           // ...
            lbl.BackColor = Color.SteelBlue;             // ...

            lbl.ShortcutsEnabled = false;        // ...

            lbl.Font = new Font(lbl.Font.FontFamily, (float)11.25,       // ...
lbl.Font.Style);                     // ...
            lbl.Text += "\n\nConsider the folowing:\n- Uninstalling the program that was installed before any of this started.\n- Seek help online\n- Boot Command-Line and try and resolve the problem[s] (developers and experts only! You may do more damage than good!).\n- Reinstalling the Operating System and/or Application.\n";            // ...
            this.Controls.Add(lbl);     // };
        }

        private void createUserDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       
    }
}
