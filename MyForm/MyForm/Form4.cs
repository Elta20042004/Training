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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Color[] ceva = new Color[] { Color.Green, Color.HotPink, Color.Orange, Color.Navy, Color.Maroon };
        private int i;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i <= ceva.Length-1)
            {
                label1.BackColor = ceva[i];
                i++;
            }
            else
            {
                i = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((i > 0)&&(i<ceva.Length))
            {
                label1.BackColor = ceva[i];
                i--;
            }          
        }
    }
}
