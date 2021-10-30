using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Interface
{
    class Animal:IEat
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }

      
       
    }
}
