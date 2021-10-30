using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Abstraction
{
    class Bowl:Shape
    {
        private const double PI = 3.1428;
        private double radius;

        public Bowl(double r)
        {
            radius = r;
        }
        public double Get_Radius()
        {
            return radius;
        }
        public override double Perimeter()
        {
            return 0;
        }
        public override double Area()
        {
            return 4 * PI * radius * radius;
        }
        public override double Volume()
        {
            return  ( PI * radius * radius * radius)*4/3;
        }

        public override void Print()
        {
            
            Console.WriteLine("Bowl Area: " + this.Area());
            Console.WriteLine("Bowl Volume: " + this.Volume());
        }
    }
}
