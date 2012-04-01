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

using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using krypto_os;

namespace krypto_os
{
    public partial class Form1 : Form
    {
        static Timer _timer;
        public string MyDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public string SYS_PREFS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/options/";
        private static string CONSOLEPATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/kadmin/";
        /// <summary>
        /// This is the string declarations for the filesytem.
        /// This code will only work when the GUI is run on-top of a Windows system.
        /// Different GUI code is required when run as a stand-alone
        /// </summary>
        public string root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/fox/filesystem";
        public int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            button5.SendToBack();
            this.BringToFront();
            this.textBox1.DeselectAll();
           
            this.textBox1.Text = "";
            system_check();
            timer1.Enabled = true;               
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.BackgroundImage = null;           
            this.BackColor = Color.Gray;
            this.pictureBox1.Visible = false;
            button1.Enabled = true;
            button1.Visible = true;
            button1.BringToFront();
            button2.Visible = true;
            button3.Visible = true;            
            (new gui()).Show(this);
            this.textBox1.Hide();
            //this.label1.Hide();
            if (!Directory.Exists(CONSOLEPATH))
            {
                ExecCmd("admin.exe");
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sys_managers.NUMBER_OF_LOADED_DESKTOPS++;
            (new gui()).Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            (new bios()).Show();
        }

        private void dots_Tick(object sender, EventArgs e)
        {
            
            if (i < 9)
            {
                if (i == 0 ||
                    i == 3 ||
                    i == 6)
                {
                    this.textBox1.Text = null;
                    this.textBox1.Text += ".";
                }
                else if (i == 1 || i == 4 || i == 7)
                    this.textBox1.Text += ".";
                else if (i == 2 || i == 5
                    || i == 8)
                    this.textBox1.Text += ".";
                else { this.textBox1.Text += "."; }
                
            }

            i++;
            this.dots.Stop();
            this.dots.Start();
            
        }

        public int system_check()
        {
           
            int ret = 0;
           
            this.textBox1.Text += "Checking ";
            this.textBox1.ForeColor = Color.Cyan;
            this.textBox1.Text += "public ";
            this.textBox1.ForeColor = Color.White;
            this.textBox1.Text += "directories...";

            if (Directory.Exists(MyDocs) == true)
            {
                ;
            }
            else
            {
                this.textBox1.Text += "\nFATAL ERROR!\n";                
            }
           
            this.timer2.Enabled = true;
            this.textBox1.Text += "\nChecking cache...\n";
            
            this.timer2.Enabled = true;
            if (Directory.Exists(MyDocs + "/krypton") == true)
            {
                ;
            }
            else
            {
                this.textBox1.Text += "\nCould not load cache! This may be your first time with Krypton!?\n";
            }

            if (Directory.Exists(MyDocs + "/krypton/options") == true)
                ;
             else
            {
                this.textBox1.Text += "\nCould not load options! This may be your first time with Krypton!?\n";
            }

            if (Directory.Exists(MyDocs + "/krypton/options/desktop") == true)
                ;
             else
            {
                this.textBox1.Text += "\nCould not load options! This may be your first time with Krypton!?\n";
            }

            if (Directory.Exists(MyDocs + "/krypton/fox/filesystem") == true)
                ;
             else
            {
                this.textBox1.Text += "\nCould not mount the filesystem!\n";
                create_filesystem();
            }

            this.textBox1.Text += "Executing disk check...\n";
            this.textBox1.Text += "Main check...\n\n";
            this.textBox1.Text += "!" + Environment.Version.ToString() + "!\n";
            this.textBox1.Text += "!" + Environment.SystemPageSize + "!\n\n";
            this.textBox1.Text += "* The Machine ID is: " + Environment.MachineName.ToString() + " *\n";
            this.textBox1.Text += "* This Machine has a PROCESSOR COUNT OF: " + Environment.ProcessorCount.ToString() + " RAM *\n";
            this.textBox1.Text += "\nMounting RAM...\n";
            this.textBox1.Text += "\nSuccessful!\n\n";
            this.textBox1.Text += "* Revision " + Environment.OSVersion.Version + " *\n";
            this.textBox1.Text += "\n\n** Welcome to Krypton OS Fox! **\n";
            this.textBox1.Text += "Loading " + Application.ProductName + "...\n";

            return ret;
        }

        public void create_filesystem()
        {
           // Directory.CreateDirectory(root);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
        }

        public static string ExecCmd(string cmd)
        {
            /**
             * http://www.codeproject.com/KB/cs/Execute_Command_in_CSharp.aspx
             * 
             * Thanks to CodeProject!
             * 
             */

            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.
                System.Diagnostics.ProcessStartInfo procStartInfo =
                   new System.Diagnostics.ProcessStartInfo("cmd", "/c " + cmd);

                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                return result;

            }
            catch (Exception objException)
            {
                // Log the exception
                return "caught " + objException.ToString();
            }

        }
    }
}
