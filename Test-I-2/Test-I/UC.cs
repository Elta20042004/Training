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
    public partial class UC : UserControl
    {

        public UC()
        {
            InitializeComponent();
        }

        public Action DoSomething
        {
            get; set;
        }
        

        private void UC_Click(object sender, EventArgs e)
        {
            DoSomething();
        }

        public void SetColor(Color c)
        {
            this.BackColor = c;
        }
    }
}
