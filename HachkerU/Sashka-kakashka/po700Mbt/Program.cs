using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po700Mbt
{
    class Program
    {
        static List<string> urlList = new List<string>();
        private static void Recursiya(string path)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] fiArr = di.GetFiles();
                foreach (FileInfo fi in fiArr)
                {
                    if (fi.Length > 700*1024*1024)
                    {
                        urlList.Add(fi.FullName);

                    }
                    
                }
                string[] files = Directory.GetDirectories(path);
                for (var i = 0; i <= files.Length - 1; i++)
                {
                    Recursiya(files[i]);
                }

            }
            catch (Exception) { }
        }

        static void Main(string[] args)
        {
            Recursiya(@"D:\");
            Recursiya(@"E:\");
            Recursiya(@"G:\");
            Recursiya(@"H:\");
            Recursiya(@"M:\");


            int counter = 0;
            for (var i = 0; i < urlList.Count; i++)
            {
                Console.WriteLine(urlList[i]);
                counter++;
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
