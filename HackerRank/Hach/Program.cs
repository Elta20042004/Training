using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hach
{
    class HashTable
    {
        private List<string>[] myCharKey;
        private List<int>[] myCharValue;

        public HashTable()
        {
            myCharKey = new List<string>[1000000];
            myCharValue = new List<int>[1000000];
        }

        public int GetValue(string key)
        {
            bool nashel = false;
            int value = -1;
            int temp = GetIndex(key);

            if (myCharKey[temp] == null)
            {
                return value;
            }
            for (int i = 0; i < myCharKey[temp].Count() && !nashel; i++)
            {
                if (myCharKey[temp][i] == key)
                {
                    value = myCharValue[temp][i];
                    nashel = true;
                }
            }
            return value;
        }

        public void SetValue(string key, int value)
        {
            bool nashel = false;
            int temp = GetIndex(key);

            if (myCharKey[temp] == null)
            {
                myCharKey[temp] = new List<string>();
                myCharValue[temp] = new List<int>();
            }

            for (int i = 0; i < myCharKey[temp].Count && !nashel; i++)
            {
                if (myCharKey[temp][i] == key)
                {
                    myCharValue[temp][i] = value;
                    nashel = true;
                }
            }
            if (nashel == false)
            {
                myCharKey[temp].Add(key);
                myCharValue[temp].Add(value);
            }
        }

        public List<string> GetKeys()
        {
            List<string> myKey = new List<string>();

            for (int i = 0; i < myCharKey.Count(); i++)
            {
                if (myCharKey[i] != null)
                {
                    myKey.AddRange(myCharKey[i]);
                }              
            }
            return myKey;
        }

        private int GetIndex(string str)
        {
            int result = (int)(((uint)str.GetHashCode()) % (uint)myCharKey.Length);
            return result;
        }
    }
    // >> d:\out.txt
    internal class Program
    {

        //static List<string> myKey = new List<string>(100000);
        //static List<int> myValue = new List<int>(100000);       

        //public static void zapolnenieListov(string slovo, int value)
        //{           
        //    bool nashel = false;

        //    for (int i = 0; i < myKey.Count && !nashel; i++)
        //    {
        //        if (myKey[i] == slovo)
        //        {
        //            myValue[i] = myValue[i] + value;
        //            nashel = true;
        //        }
        //    }
        //    if (nashel == false)
        //    {
        //        myKey.Add(slovo);
        //        myValue.Add(value);
        //    }

        //}

        //static List<string>[] myCharKey = new List<string>[26];
        //static List<int>[] myCharValue = new List<int>[26];
        //public static void zapolnenieListov2(string slovo, int value)
        //{
        //    bool nashel = false;
        //    int index = slovo[0] - 'A';
        //    if (myCharKey[index] == null)
        //    {
        //        myCharKey[index] = new List<string>();
        //        myCharValue[index] = new List<int>();
        //    }

        //    for (int i = 0; i < myCharKey[index].Count && !nashel; i++)
        //    {
        //        if (myCharKey[index][i] == slovo)
        //        {
        //            myCharValue[index][i] = myCharValue[index][i] + value;
        //            nashel = true;
        //        }
        //    }
        //    if (nashel == false)
        //    {
        //        myCharKey[index].Add(slovo);
        //        myCharValue[index].Add(value);
        //    }


        //}

        //static Dictionary<string, int> keyValue = new Dictionary<string, int>();
        //public static void zapolnenieListov2(string slovo, int value)
        //{
        //    if (!keyValue.ContainsKey(slovo))
        //    {
        //        keyValue.Add(slovo, 0);
        //    }
        //    keyValue[slovo] += value;
        //}

        static HashTable HT = new HashTable();
        public static void zapolnenieListov3(string slovo, int value)
        {
            if (HT.GetValue(slovo) < 0)
            {
                HT.SetValue(slovo, value);
            }
            else
            {
                int k = HT.GetValue(slovo);
                k = k + value;
                HT.SetValue(slovo, k);
            }
        }

        public static void raspil(string a)
        {

            int i = 0;
            int j = a.Length - 1;
            string slovo = "";
            string znachenie = "";

            while (a[i] != ' ')
            {
                slovo = slovo + a[i];
                i++;
            }
            j = i + 1;
            while (j <= a.Length - 1)
            {
                znachenie = znachenie + a[j];
                j++;
            }

            int k = int.Parse(znachenie);

            zapolnenieListov3(slovo, k);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string k = Console.ReadLine();
                raspil(k);
            }
            int summ = 0;
            foreach (var key in HT.GetKeys())
            {
                summ += HT.GetValue(key);
            }

            //int summ = 0;
            //for (int j = 0; j < myCharKey.Count(); j++)
            //{
            //    if (myCharKey[j] != null)
            //    {
            //        for (int i = 0; i < myCharKey[j].Count; i++)
            //        {
            //            //Console.WriteLine("{0} {1}", myCharKey[j][i], myCharValue[j][i].ToString());
            //            summ = summ + myCharValue[j][i];
            //        }
            //    }

            //}
            Console.WriteLine(summ);

        }
    }
}
