using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domashnee_Zadanie.Animals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Multicellular> multicellular = new List<Multicellular>();  // mnogokletochnye 

            multicellular.Add(new LandAnimals(4,new List<IPredator>())     //nazemnye zhivotnye   
            {
                Id = 547,
                Name = "elephant",
                Story = "Very sad",
                Age = 3.4f
            });
            multicellular.Add(new LandAnimals(4,new List<Multicellular>()) // peredayu parametr hishnika
            {
              Id = 457,
              Name = "lion",
              Story = "Very sad",
              Age = 2.4f
            });
            multicellular.Add(new LandAnimals(4, new List<Multicellular>())
            {
                Id = 489,
                Name = "tiger",
                Story = "Very sad",
                Age = 1.4f
            });
            multicellular.Add(new Fish(new TimeSpan(6875432), new List<Multicellular>(), new List<IPredator>())
            {
                Id = 678,
                Name = "shark",             // akula
                Story = "Very sad",
                Age = 190.4f,
                
            });
            multicellular.Add(new Fish(new TimeSpan(56743), new List<Multicellular>(), new List<IPredator>())
            {
                Id =675,
                Name = "salmon",            // solomon
                Story = "Very sad",
                Age = 17.4f

            });
            multicellular.Add(new Snake(100, new List<Multicellular>())     //tol'ko hishnik
            {
                Id = 47,
                Name = "viper",             // gadyuka
                Story = "Very sad",
                Age = 50.4f,               
            });
            
                dataGridView1.DataSource = multicellular;            //pomestil list v datagrideView

            // otobrala vseh mnogokletochnyh, kotorye realizuyut interface predator i ne ravno null
            var k = multicellular
                .Where(t => t is IPredator && ((IPredator) t).FavoriteDishes() != null);

            dataGridView2.DataSource = k.ToList();

            var p = multicellular
                .Where(t => t is IGraminivorous && ((IGraminivorous)t).Enemies() != null);

            dataGridView3.DataSource = p.ToList();
        }
    }
}
