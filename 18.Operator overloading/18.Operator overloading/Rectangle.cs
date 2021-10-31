using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Operator_overloading
{
    class Rectangle
    {
        public double A { get; private set; }
        public double B { get; private set; }


        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public void Print()
        {
            Console.WriteLine("A = "+A+"\tB = "+B+"\tArea = "+this.Area());
            
        }

        public static Rectangle operator +(Rectangle rectangle, double value)
        {
            return new Rectangle(rectangle.A + value, rectangle.B + value);
        }
        public static Rectangle operator -(Rectangle rectangle, double value)
        {
            if (value < rectangle.A && value < rectangle.B)
            {
                return new Rectangle(rectangle.A + value, rectangle.B + value);
            }
            return rectangle;
        }

        public static bool operator ==(Rectangle rectangle, Rectangle rectangle1)
        {

            return rectangle.Area() == rectangle1.Area();
        }

        public static bool operator !=(Rectangle rectangle, Rectangle rectangle1)
        {

            return rectangle.Area() != rectangle1.Area();
        }

        public static double operator +(Rectangle rectangle,Rectangle rectangle1)
        {
            return rectangle.Area() + rectangle1.Area();
        }
    }
}
