using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_I
{
    public partial class Form1 : Form
    {
        private int counter;

        public Form1()
        {
            InitializeComponent();
        }

        int Counter
        {
            get
            {
                return this.counter;
            }
            set
            {
                this.counter = value;
                label2.Text = value.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            Action a = () =>
            {
                Counter++;
            };
            uc1.DoSomething = a;

            uc2.DoSomething = a;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            uc1.DoSomething = () =>
            {
                int next = rand.Next();
                uc2.SetColor(Color.FromArgb(next));
            };

            uc2.DoSomething = () =>
            {
                int next = rand.Next();
                uc1.SetColor(Color.FromArgb(next));
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
