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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Action a = () =>
            {
                uc1.BackColor = Color.Brown;
            };
            Action b = () =>
            {
                uc1.BackColor = SystemColors.Control;
            };


            usButtonFormIII1.OnPlug = a;
            usButtonFormIII2.OnPlug = a;
            usButtonFormIII3.OnPlug = a;
            usButtonFormIII1.OnUnPlug = b;
            usButtonFormIII2.OnUnPlug = b;
            usButtonFormIII3.OnUnPlug = b;
        }
    }
}
