/** Copyright 
 * © Edward Chernysh (kryptonX)
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
    public partial class Krypton_update : UserControl
    {
        Timer updater = new Timer();
        public Krypton_update()
        {
            InitializeComponent();
        }

        private void Krypton_update_Load(object sender, EventArgs e)
        {
            updater.Tick += new EventHandler(updater_Tick);
            updater.Enabled = true;
        }

        void updater_Tick(object sender, EventArgs e)
        {
            updater.Enabled = false;
            if (progressBar1.Value == 100)
            {
                this.Visible = false;
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 10;
                updater.Enabled = true;
            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            
        }
    }
}
