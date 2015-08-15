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
    public partial class Form2 : Form
    {
        private int globolSumm;
        private int counter;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            globolSumm = int.Parse(textBox1.Text) + globolSumm;
            if (counter == 4)
            {
                label1.Text = globolSumm.ToString();
            }
        }
    }
}
