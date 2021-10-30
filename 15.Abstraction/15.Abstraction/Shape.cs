using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Abstraction
{
    abstract class Shape
    {
        public abstract double Perimeter();
        public abstract double Area();        
        public virtual double Volume()
        {
            return 0;
        }
        public abstract void Print();
    }
}
