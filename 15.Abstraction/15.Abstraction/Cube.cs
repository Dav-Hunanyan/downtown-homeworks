using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Abstraction
{
    class Cube : Square
    {
        private double side;
        public Cube(double side) : base(side)
        {
            this.side = side;
        }
        public double Get_Side()
        {
            return side;
        }

        public override double Area()
        {
            return side * side * 6;
        }

        public override double Perimeter()
        {
            return 4 * side * 6;
        }

        public override double Volume()
        {
            return side * side * side;
        }

        public override void Print()
        {
            Console.WriteLine("Cube Perimeter: " + this.Perimeter());
            Console.WriteLine("Cube Area: " + this.Area());
            Console.WriteLine("Cube Volume: " + this.Volume());
        }
    }
}
