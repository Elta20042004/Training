using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domashnee_Zadanie.Animals
{
    public interface IPredator          // hishnik
    {
        IEnumerable<Multicellular> FavoriteDishes();   // lyubimye blyuda
    }
}
