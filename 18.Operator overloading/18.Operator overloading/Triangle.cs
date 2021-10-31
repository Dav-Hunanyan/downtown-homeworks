using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Operator_overloading
{
    class Triangle
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public void Print()
        {
            Console.WriteLine("A = " + A + "\tB = " + B + "\tC = " + C + "\tArea = " + this.Area());

        }

        public static double operator +(Triangle triangle, Triangle triangle1)
        {
            return triangle.Area() + triangle1.Area();
        }
        public static Triangle operator +(Triangle triangle, double value)
        {
            return new Triangle(triangle.A + value, triangle.B + value, triangle.C + value);
        }

        public static bool operator >(Triangle triangle, Triangle triangle1)
        {
            return triangle.Area() > triangle1.Area();
        }
        public static bool operator <(Triangle triangle, Triangle triangle1)
        {
            return triangle.Area() < triangle1.Area();
        }


    }
}
