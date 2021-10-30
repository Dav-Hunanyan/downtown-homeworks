using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Interface
{
    class Terrestrial:Animal,IEat,IRun
    {
        public Terrestrial()
        {
            Console.WriteLine("Terrestrial Constructor");
        }

        public void Run()
        {
            Console.WriteLine("Runing");
        }
    }
}
