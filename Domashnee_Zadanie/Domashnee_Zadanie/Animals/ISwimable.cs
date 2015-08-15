using System;

namespace Domashnee_Zadanie.Animals
{
    interface ISwimable : IMovable //plavayushij
    {
        TimeSpan MaxTimeUnderWater();  //maksimal'noe vremya pod vodoj
    }
}