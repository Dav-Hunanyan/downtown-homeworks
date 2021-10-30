using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Interface
{
    class Eagle:Bird,IHunt
    {
        public Eagle()
        {
            Console.WriteLine("Eagle constructor");
        }

        public void Hunt()
        {
            Console.WriteLine("Hunting");
        }
    }
}
