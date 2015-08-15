using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domashnee_Zadanie.TvTeka
{
    public abstract class Movie
    {
        public int count;
        public string title;
        public TimeSpan time;
        public string description;
        public int year;
        public string genre;

        public bool TakeIt()  //esli ya znayu, shto metod delaet, on ne dolzhen byt' abstract
        {
            if (count > 0)
            {
                count--;
                return true;
            }

            return false;

        }
    }
}
