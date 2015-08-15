using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domashnee_Zadanie.TvTeka;

namespace Domashnee_Zadanie
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Animals.Form1());
            
            Adults adi = new Adults();
            adi.TakeIt();
        }
    }
}
