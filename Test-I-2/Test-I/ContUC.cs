using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_I
{
    public partial class ContUC : UserControl
    {
        public Func<Control> F { get; set; }

        public ContUC()
        {
            InitializeComponent();
        }

        private void ContUC_Load(object sender, EventArgs e)
        {
           
        }

        public  void Init()
        {
             for (int i = 0; i < 10; i++)
            {
                var control = F();
                 AddControl(control);
            }
        }

        void AddControl(Control k)
        {            
            flowLayoutPanel1.Controls.Add(k);           
        }

    }
}
