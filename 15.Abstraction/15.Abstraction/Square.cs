using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Abstraction
{
    class Square : Shape
    {
        private double side;
        public Square(double side)
        {
            this.side = side; 
        } 
        public double Get_Side()
        {
            return side;
        }
        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }

        public override void Print()
        {
            Console.WriteLine("Square Perimeter: "+this.Perimeter());
            Console.WriteLine("Square Area: "+this.Area());
        }
    }
}
