using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Anagram
{
    class Program
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length == 0 && t.Length == 0)
            {
                return true;
            }

            if (s.Length < t.Length)
            {
                var temp = s;
                s = t;
                t = temp;
            }

            Dictionary<char, int> dic = new Dictionary<char, int>();
           
            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i],1);
                }
                else
                {
                    dic[s[i]]++;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (dic.ContainsKey(t[i]))
                {
                    if (dic[t[i]] > 1)
                    {
                        dic[t[i]]--;
                    }
                    else
                    {
                        dic.Remove(t[i]);
                    }
                }
            }

            if (dic.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        static void Main(string[] args)
        {
            IsAnagram("a", "ab");
        }
    }
}
