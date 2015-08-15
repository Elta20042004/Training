using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class myexce : Exception
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new myexce();
            }            
            catch (Exception)
            {
                
                throw;
            }
            catch (myexce myx)
            {
                int gg = 7;
            }

        }
    }
}
