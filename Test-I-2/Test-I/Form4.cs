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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Func<Control> a = () =>
            {
                Button btn = new Button();
                btn.Text = "hi";
                return btn;
            };

            contUC1.F = a;
            contUC1.Init();
        }


    }
}
