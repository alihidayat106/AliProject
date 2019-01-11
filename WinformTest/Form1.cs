using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Part is Association");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 2000;
            int v = 2000;

            int res = x + v;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is testing!");
        }
    }
}
