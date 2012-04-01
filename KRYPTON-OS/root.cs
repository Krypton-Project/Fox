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
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace krypto_os
{
    public partial class root : UserControl
    {
        public root()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 0;
            this.Height = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "alpine")
            {
                this.Visible = false;
            }
            else
            {
                textBox1.Text = "";
                label1.Text = "You entered a wrong password";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}
