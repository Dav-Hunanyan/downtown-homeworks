using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Operator_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 15);
            rectangle.Print();
            Rectangle rectangle1 = rectangle + 3;
            rectangle1.Print();
            double Area = rectangle + rectangle1;
            Console.WriteLine(Area);


            Triangle triangle = new Triangle(3, 4, 5);
            triangle.Print();

            Triangle triangle1 = triangle + 5;
            triangle1.Print();

            if (triangle > triangle1)
            {
                Console.WriteLine("1");
            }
            if (triangle < triangle1)
            {
                Console.WriteLine("2");
            }


        }
    }
}
