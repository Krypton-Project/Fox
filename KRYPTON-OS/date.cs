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
    public partial class date : UserControl
    {
        public date()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void date_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
