using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Domashnee_Zadanie.Shapes
{
    class Poly
    {

        public Poly()
        {
            Points = new List<Point>();
        }

        //private List<Point> points;

        private List<Point> Points
        {
            get; set; 
        }

        public Color Color { get; set; }

        public void Add(int x, int y)
        {
            Add(new Point(x, y));
        }

        public void Add(Point point)
        {
            Points.Add(point);
        }

        public void Draw(PictureBox pic, int width, int height)
        {
            //var bit = new Bitmap(width, height);  // sozdaet novuyu
            Image bit;
            if (pic.Image == null)
            {
                bit = new Bitmap(width, height);
            }
            else
            {
                bit = pic.Image;                    //Ispol'zuet uzhe sushestvuyushuyu kartinku
            }
            
            var g = Graphics.FromImage(bit);

            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var brush = new SolidBrush(Color);

            g.FillPolygon(brush, Points.ToArray());

            pic.Image = bit;
        }

    }
}
