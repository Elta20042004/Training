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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
          
        }

        private string[] titles =
        {
            "hello","world","whats","up"
        };


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                string text = titles[i];
                AddButton(text);
            }
        }

        void AddButton(string text)
        {
            Button btn = new Button();
            btn.Text = text;
            flowLayoutPanel1.Controls.Add(btn);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text + "!!!");
        }
    }
}
