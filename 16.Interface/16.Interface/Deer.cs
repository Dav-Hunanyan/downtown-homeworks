using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Interface
{
    class Deer : Terrestrial, IEscape
    {
        public Deer()
        {
            Console.WriteLine("Deer Constructor");
        }

        public void Escape()
        {
            Console.WriteLine("Escaping");
        }
    }
}
