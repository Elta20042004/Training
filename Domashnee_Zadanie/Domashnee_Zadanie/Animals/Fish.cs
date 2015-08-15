using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashnee_Zadanie.Animals
{
    public class Fish : Multicellular, ISwimable, IPredator, IGraminivorous      //ryba : dvigaetsya : plavayushij
    {
        private readonly TimeSpan _maxTimeUnderWater;
        private readonly IEnumerable<Multicellular> _favoriteDishes;
        private readonly IEnumerable<IPredator> _enemies;
        
        public Fish(TimeSpan maxTimeUnderWater, IEnumerable<Multicellular> favoriteDishes, IEnumerable<IPredator> enemies)           //ctor - konstruktor
        {
            _maxTimeUnderWater = maxTimeUnderWater;
            _favoriteDishes = favoriteDishes;
            _enemies = enemies;
        }

        public void Move()
        {
           
        }

        public TimeSpan MaxTimeUnderWater()
        {
            return _maxTimeUnderWater;
        }


        public IEnumerable<Multicellular> FavoriteDishes()
        {
            return _favoriteDishes;
        }

        public IEnumerable<IPredator> Enemies()
        {
            return _enemies;           
        }
    }
}
