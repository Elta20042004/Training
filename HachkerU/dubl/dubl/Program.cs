using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dubl
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = "Before the age of computers many mathematicians formed tables of primes.";
            char[] glassnye = new char[] {'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y'};
            int count = 0;
            

            for (var i = 0; i <= input.Length - 1; i++)
            {
                var j = 0;
                while ((j<glassnye.Length-1)&&(input[i]!=glassnye[j]))
                {                  
                    j++;                        
                }

                if (j == glassnye.Length-1)
                {
                    Console.Write(input[i]);
                }
                
            }

            Console.ReadLine();

        }               
        
        
        
        
        
        
        
        
        
        static void Main2(string[] args)
        {
            string[] input = new string[] {"aaa", "bbb", "aab", "bbb", "baa", "sdd", "aaa"};

            
            for (var i = 0; i <= input.Length - 1; i++)
            {

                for (var j = i+1; j <= input.Length - 1; j++)
                {
                    if (input[i] == input[j])
                    {
                        input[j] = "";
                    }

                }
                


            }
                Console.WriteLine(input);
                Console.ReadLine();

        }               
                
    }
}
