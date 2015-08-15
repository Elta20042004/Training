using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HJob
{
    public partial class Globaly : Form
    {
        public Globaly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var k = new Form1();
            k.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var k = new Form2();
            k.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var k = new Form3();
            k.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var k = new Form4();
            k.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var k = new Form6();
            k.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var k = new Form8();
            k.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var k = new Form10();
            k.Show();
        }
    }
}
