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
    public partial class clock : UserControl
    {
        public clock()
        {
            InitializeComponent();
        }

        private void clock_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
