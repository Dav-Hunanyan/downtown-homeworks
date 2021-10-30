using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Interface
{
    class Bird:Animal,IEat,IFly
    {
        public Bird()
        {
            Console.WriteLine("Bird Constructor");
        }

        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
