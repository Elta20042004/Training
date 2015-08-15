namespace Domashnee_Zadanie.TvTeka
{
    public class Teens:Movie
    {
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", title, time, genre);
        }
    }
}