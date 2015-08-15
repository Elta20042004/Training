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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var t = new Form5();
            if (RBSumma.Checked)
            {
                t.fnc = summa;
            }
            else if (RBUmnozhenie.Checked)
            {
                t.fnc = umnozhenie;
            }
            else
            {
                t.fnc = max;
            }

            t.Show();

        }

        public int summa(int[] k)
        {
            int sum = 0;
            for (int i = 0; i < k.Length; i++)
            {
                sum = sum + k[i];
            }
            return sum;
        }

        public int umnozhenie(int[] k)
        {
            int umn = 1;
            for (int i = 0; i < k.Length; i++)
            {
                umn = umn * k[i];
            }
            return umn;
        }

        public int max(int[] k)
        {
            Array.Sort(k);
            int max = k[k.Length-1];
            return max;
        }

        public void Form4_Load(object sender, EventArgs e)
        {
        }

    }
}
