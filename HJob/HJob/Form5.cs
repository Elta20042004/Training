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
    public partial class Form5 : Form
    {
        public Func<int[], int> fnc { get; set; }
        public Form5()
        {
            InitializeComponent();
        }

        private List<int> numbers;

        public void button1_Click(object sender, EventArgs e)
        {
            int[] k = Init();
            int p = fnc(k);

            label2.Text = p.ToString();
        }

        public int[] Init()
        {
            string objTextBox = textBox1.Text;
            string[] k = objTextBox.Split(' ');
            int[] numbers = k.Select(ch => int.Parse(ch.ToString())).ToArray();
            return numbers;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

    }
}
