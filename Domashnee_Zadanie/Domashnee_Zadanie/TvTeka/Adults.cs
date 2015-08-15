using System;
using System.Windows.Forms;

namespace Domashnee_Zadanie.TvTeka
{
    public class Adults : Movie
    {
        
        public override string ToString()
        {
            return string.Format("{0}, {1} 18+", title, time);
        }

        public bool TakeIt(DateTime year)    //god rozhdeniya pokupatelya
        {
            DateTime now = DateTime.Now;
            if (now - year<18)
            {
                TakeIt();
                return true;
            }
            return false;
        }
      
    }
}