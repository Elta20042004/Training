using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    interface IRunnable
    {
        void Run();
    }

    class People : IRunnable
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
