using System;
using System.CodeDom.Compiler;
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
    public partial class UsButtonFormIII : UserControl
    {
        public Action OnPlug { get; set; }
        //public Action OnChange { get; set; }
        public Action OnUnPlug { get; set; }

        public UsButtonFormIII()
        {
            InitializeComponent();
        }

        private int summ;

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
                summ++;
            }
            else
            {
                k.BackColor = SystemColors.Control;
                summ--;
            }

            if (summ == 4)
            {
                OnPlug();
            }
            else
            {
                OnUnPlug();
            }
        }
    }
}
