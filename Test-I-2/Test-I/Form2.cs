using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_I
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int counter;


        int Counter
        {
            get
            {
                return this.counter;
            }
            set
            {
                this.counter = value;
                label1.Text = value.ToString();
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Action<bool> a = (complete) =>
            {
                if (complete)
                {
                     Counter++;
                }
                else
                {
                    Counter--;
                }

                if (Counter%5==0)
                {
                    label1.BackColor = Color.Chocolate;

                }
                else
                {
                    label1.BackColor =SystemColors.Control;
                }

            };

            usButton1.OnChange = a;
            usButton2.OnChange = a;
            usButton3.OnChange = a;
            usButton4.OnChange = a;
            usButton5.OnChange = a;
            usButton6.OnChange = a;
            usButton7.OnChange = a;
            usButton8.OnChange = a;
            usButton9.OnChange = a;
            usButton10.OnChange = a;
            usButton11.OnChange = a;
            usButton12.OnChange = a;
            usButton13.OnChange = a;
            usButton14.OnChange = a;
            usButton15.OnChange = a;
            usButton16.OnChange = a;
            
        }


    }
}
