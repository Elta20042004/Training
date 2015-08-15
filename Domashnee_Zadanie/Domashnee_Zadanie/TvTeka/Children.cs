namespace Domashnee_Zadanie.TvTeka
{
    public class Children:Movie
    {
        public override string ToString()
        {
            return string.Format("{0}, {1}", title, time);
        }
    }
}