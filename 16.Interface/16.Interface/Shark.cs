using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Interface
{
    class Shark : Fish, IHunt
    {
     
        public Shark()
        {
            Console.WriteLine("Shark constructor");
        }
        public void Hunt()
        {
            Console.WriteLine("Hunting");
        }
    }
}
