using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgrammaIry
{
    class Program
    {
        static WebClient client = new WebClient();

        static string DownloadString(string url)
        {
            try
            {
                Uri uri = new Uri(url);

                var result = client.DownloadString(uri);

                return result;
            }
            catch (Exception)
            {
                return "";
            }

        }

        static string[] ManualParse(string content)
        {
            List<string> reusltsStr = new List<string>();
            int j = content.IndexOf("href=");
            while (j > 0)
            {
                j += 5;
                if (content[j + 1] == '\'' || content[j + 1] == '\"')
                {
                    j++;
                }
                int f = j;
                while (content[j + 1] != '\'' &&
                       content[j + 1] != '\"' &&
                       content[j + 1] != ' ' &&
                       content[j + 1] != '>')
                {
                    j++;
                }
                string resultStr = content.Substring(f, j - f);
                reusltsStr.Add(resultStr);
                j = content.IndexOf("href=", j);
            }
            return reusltsStr.ToArray();
        }

        static string[] Parse(string content)
        {
            Regex r = new Regex("href=[\'\"]?([^\'\" >]+)");

            var matches = r.Matches(content);

            string[] result = new string[matches.Count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = matches[i].Result("$1");
            }
            return result;
        }

        static List<string> urlList = new List<string>();

        static void Crawl(string url)
        {
            if (urlList.Count > 7000)
            {
                return;
            }
            string test = DownloadString(url);
            string[] temp = Parse(test);
            urlList.AddRange(temp);
            for (var i = 0; i < temp.Length; i++)
            {
                Crawl(temp[i]);
            }
        }

        static void Main(string[] args)
        {
            string url =
                "http://www.asos.com/women/new-in-clothing/cat/pgecategory.aspx?cid=2623&via=top#parentID=-1&pge=2&pgeSize=36&sort=-1";

            Crawl(url);

        }
    }
}
