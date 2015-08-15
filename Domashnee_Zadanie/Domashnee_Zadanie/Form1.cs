using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domashnee_Zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Shapes.Poly kvadrat = new Shapes.Poly();                    
            int size = 200;

            kvadrat.Add(0 , 0);
            kvadrat.Add(size, 0);
            kvadrat.Add(size, size);
            kvadrat.Add(0, size);
            kvadrat.Color = Color.Green;

            kvadrat.Draw(pictureBox1, size, size);

            Shapes.Poly romb = new Shapes.Poly();
            size = 200;

            romb.Add(size / 2, 0);
            romb.Add(size, size / 2);
            romb.Add(size / 2, size);
            romb.Add(0, size / 2);
            romb.Color = Color.Black;
            romb.Draw(pictureBox1, size, size);
        }
    }
}
