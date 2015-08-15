using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashnee_Zadanie.Animals
{
    public class LandAnimals : Multicellular, IWalkable, IPredator, IGraminivorous  //Nazemnye zhivotnue  : hodyachie , ya hishnik
    {
        private readonly int _getLegsCount;
        private readonly IEnumerable<IPredator> _enemies;
        private readonly IEnumerable<Multicellular> _favoriteDishes;

        protected LandAnimals(int getLegsCount)  //obshij konstruktor
        {
            _getLegsCount = getLegsCount;
        }
        
        public LandAnimals(int getLegsCount, IEnumerable<Multicellular> favoriteDishes)
            :this(getLegsCount) //konstruktor dlya hishnikov ... this - vyzov obshego konstruktora
        {         
            _favoriteDishes = favoriteDishes;
        }

        public LandAnimals(int getLegsCount, IEnumerable<IPredator> enemies)
            : this(getLegsCount)   //konstruktor dlya travoyadnyh... this - vyzov obshego konstruktora
        {           
            _enemies = enemies;
        }

        public void Move()
        {
           
        }

        public int GetLegsCount()
        {
            return _getLegsCount;
        }

        void IMovable.Move()                                   //IMovable
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Multicellular> FavoriteDishes()        // hishnik
        {
            return _favoriteDishes;
        }

        public IEnumerable<IPredator> Enemies()                 // vragi dlya travoyadnyh                       
        {
            return _enemies;
        }
    }
}
