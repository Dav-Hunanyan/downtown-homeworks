using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Interface
{
    class Lion : Terrestrial, IHunt,ISwim
    {
        
        public Lion()
        {
            Console.WriteLine("Lion constuctor");
        }
        public void Hunt()
        {
            Console.WriteLine("Hunting");
        }

        public void Swim()
        {
            Console.WriteLine("Swimming");
        }
    }
}
