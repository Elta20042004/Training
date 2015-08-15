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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var k = sender as Button;
            if (k == null)
            {
                return;
            }
            if (k.BackColor == SystemColors.Control)
            {
                k.BackColor = Color.Green;
            }
            else
            {
                k.BackColor = SystemColors.Control;
            }
            

        }
      
    }
}
