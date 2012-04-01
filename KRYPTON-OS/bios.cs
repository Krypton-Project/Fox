using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using admin;

namespace krypto_os
{
    public partial class bios : Form
    {
        public bios()
        {
            InitializeComponent();
        }

        private void bios_Load(object sender, EventArgs e)
        {                           
            guiLabel.Select();
            button5.Visible = false;
        }

        private void bios_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void linkLabel1_Enter(object sender, EventArgs e)
        {
            cliLabel.BackColor = Color.Gray;
            guiLabel.BackColor = Color.Transparent;
        }

        private void linkLabel1_Leave(object sender, EventArgs e)
        {
            cliLabel.BackColor = Color.Transparent;
            guiLabel.Select();
        }

        private void linkLabel2_Enter(object sender, EventArgs e)
        {
            guiLabel.BackColor = Color.Gray;
            cliLabel.BackColor = Color.Transparent;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new gui()).Show();
            this.Close();
        }

        private void bootBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void guiLabel_Click(object sender, EventArgs e)
        {

        }

        private void cliLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var x = new admin.Program();
            
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
                   new System.Diagnostics.ProcessStartInfo(cmd);

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
