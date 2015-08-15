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
    public partial class Form6 : Form
    {
        public Action<string> F { get; set; }

        public Form6()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            var k = new Form7();
            k.Show();
            Action<string> a = s =>
                       {
                           labelForAlex.Text=s;
                       };
            k.F = a;
            F = k.Recieve;

        }

        public void SendFromAlex_Click(object sender, EventArgs e)
        {
            F(textBoxAlex.Text);
        }
    }
}
