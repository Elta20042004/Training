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
    public partial class UsButton : UserControl
    {
        public UsButton()
        {
            InitializeComponent();
        }

        public Action<bool> OnChange { get; set; }

        private void UsButton_Load(object sender, EventArgs e)
        {

        }

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
                OnChange(true);
            }
            else
            {
                k.BackColor = SystemColors.Control;
                OnChange(false);
            }



        }

    }
}
