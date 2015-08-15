using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DetectHTMLlinks
{
    class Program
    {

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string[] k = new string[t];
            for (int i = 0; i < k.Length; i++)
            {
                k[i] = Console.ReadLine();
            }

            string temp = @"href=.(?<link>[a-zA-Z:_\.\/\?\=\;\:\&0-9]{0,}).+[>]{1}(?<text>[ a-zA-Z0-9_\.]{1,})[<\/\.a>]{1}";
            var regex = new Regex(temp);
            for (int i = 0; i < k.Length; i++)
            {
                var matchs = regex.Matches(k[i]);
                foreach (var r in matchs)
                {
                    var match = (Match)r;
                    if (match.Success)
                    {
                        string linc = match.Groups["link"].Value;
                        string body = match.Groups["text"].Value;
                        Console.WriteLine(linc + ',' + body);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
///wiki/Orval_Overall,Orval Overall
///wiki/List_of_Major_League_Baseball_pitchers_who_have_struck_out_four_batters_in_one_inning,Major League Baseball player to strike out four batters in one inning
///wiki/World_Series,World Series
///wiki/West_Triangle_Economic_Zone,West Triangle Economic Zone
///wiki/Kismet_(1943_film),Kismet
///wiki/Gyan_Mukherjee,Gyan Mukherjee
///wiki/Roxy_Cinema_(Kolkata),Roxy, Kolkata
///wiki/Vauix_Carter,Vauix Carter
///wiki/1882_Navy_Midshipmen_football_team,1882 Navy Midshipmen football team
///wiki/Zhu_Chenhao,Zhu Chenhao
///wiki/Slow_slicing,slow slicing
///wiki/Prince_of_Ning_rebellion,Prince of Ning rebellion
///wiki/Ming_Dynasty,Ming Dynasty
///wiki/Zhengde_Emperor,emperor Zhengde
///wiki/Mirza_Adeeb,Mirza Adeeb
///wiki/Urdu,Urdu
///wiki/La%C3%9Ft_uns_sorgen,_la%C3%9Ft_uns_wachen,_BWV_213,Die Wahl des Herkules
///wiki/Wikipedia:Recent_additions,Archive
///wiki/Wikipedia:Your_first_article,Start a new article
///wiki/Template_talk:Did_you_know,Nominate an article