using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Abstraction
{
    class Circle:Shape
    {
        private const double PI = 3.1428;
        private double radius;

        public Circle(double r)
        {
            radius = r;
        }
        public double Radius { get{return radius; } }
        public override double Area()
        {
            return PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * PI * radius;
        }

        public override void Print()
        {
            Console.WriteLine("Circle Perimeter: " + this.Perimeter());
            Console.WriteLine("Circle Area: " + this.Area());
        }
    }
}
