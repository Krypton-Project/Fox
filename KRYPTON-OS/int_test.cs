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
    public partial class int_test : Form
    {
        public int_test()
        {
            InitializeComponent();
            
        }

        private void int_test_Load(object sender, EventArgs e)
        {
            int n = 1;

            while (n < 6)
            {
                Console.WriteLine("Current value of n is {0}", n);
                n++;
            }
        }
    }
}
