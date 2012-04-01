/** Copyright 
 * (c) Edward Chernysh (kryptonX)
 * 
    *This program is free software: you can redistribute it and/or modify
    *it under the terms of the GNU General Public License as published by
    *the Free Software Foundation, either version 3 of the License, or
    *(at your option) any later version.

    *This program is distributed in the hope that it will be useful,
    *but WITHOUT ANY WARRANTY; without even the implied warranty of
    *MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    *GNU General Public License for more details.

    *You should have received a copy of the GNU General Public License
    *along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
  **/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace krypto_os
{
    public partial class security : Form
    {
        public security()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "at0mic")
            {
                timer1.Enabled = true;
                               
                
            }
            else
            {
                MessageBox.Show("You entered the wrong password." +
                       "\nIf you do not know the password and believe you should contact @kryptonX",
               "Krypton OS Virtual Machine",
                       MessageBoxButtons.OK,
           MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.ServiceNotification);
                textBox1.Text = "";
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void security_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.textBox1.Text == "at0mic")
            {

            }
            else
            {
                Application.Exit();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.ShowInTaskbar = false;
            this.Visible = false;
            (new gui()).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
