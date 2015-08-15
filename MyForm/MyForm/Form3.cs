using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private int global = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            global++;
            if (global > 5)
            {
                global = 1;
            }
            label1.Text = global.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            global--;
            if (global < 1)
            {
                global = 1;
            }
            label1.Text = global.ToString();
        }

    }
}
