using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = { new Square(8), new Triangle(4, 6, 5), new Circle(5), new Cube(6), new Bowl(4) };
            for (int i = 0; i < shape.Length; i++)
            {
                shape[i].Print();
                Console.WriteLine();
            }

            Square square = (Square)shape[0];
            Console.WriteLine(square.Square_Area());
            Console.WriteLine(square.Square_Perimeter());
            Circle circle = (Circle)shape[2];
            Console.WriteLine(circle.Circle_Perimeter());
            Console.WriteLine(circle.Circle_Area());

            Cube cube = new Cube(10);
            Console.WriteLine(cube.Cube_Volume() + "\t" + cube.Cube_Area() + "\t" + cube.Cube_Perimeter());
            Bowl bowl = new Bowl(3);
            Console.WriteLine(bowl.Bowl_Area() + " \t" + bowl.Bowl_Volume());
         
           
        }
    }
}
