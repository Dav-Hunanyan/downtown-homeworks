using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Abstraction
{
    class Triangle : Shape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw Exception("There is no Triangle with those sides");

            }
            side1 = a;
            side2 = b;
            side3 = c;
        }

        private Exception Exception(string v)
        {
            throw new Exception("There is no Triangle with those sides"); ;
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }
        public override double Area()
        {
            double temp = this.Perimeter() / 2;
            return Math.Sqrt(temp * (temp - side1) * (temp - side2) * (temp - side3));
        }

        public override void Print()
        {
            if (side1 == side2 && side1 == side3)
            {
                Console.WriteLine("Triangle is Equal");
            }
            Console.WriteLine("Triangle Perimeter: " + this.Perimeter());
            Console.WriteLine("Triangle Area: " + this.Area());
        }
    }
}
