using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashnee_Zadanie.Animals
{
    class Snake : Multicellular, ICreepble, IPredator   // zmeya : dvigaetsya : polzayushij, hishniki
    {
        private readonly int _elasticDegree;
        private readonly IEnumerable<Multicellular> _favoriteDishes;

        public Snake(int elasticDegree, IEnumerable<Multicellular> favoriteDishes)      // konstruktor
        {
            _elasticDegree = elasticDegree;
            _favoriteDishes = favoriteDishes;
        }

        public void Move()
        {
           
        }

        public int GetElasticDegree()
        {
            return _elasticDegree;
        }

        public IEnumerable<Multicellular> FavoriteDishes()
        {
            return _favoriteDishes;
        }
    }
}
