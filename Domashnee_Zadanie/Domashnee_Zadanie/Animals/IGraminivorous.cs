using System.Collections.Generic;

namespace Domashnee_Zadanie.Animals
{
    interface IGraminivorous       //travoyadnoe
    {
        IEnumerable<IPredator> Enemies();   // vragi travoyadnyh
    }
}