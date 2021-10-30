using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Abstraction
{
    static class Extension
    {
        public static double Square_Area(this Square square)
        {
            Console.Write("Square area: ");
            return square.Get_Side() * square.Get_Side();
        }
        public static double Square_Perimeter(this Square square)
        {
            Console.Write("Square perimeter: ");
            return 4 * square.Get_Side();
        }

        public static double Circle_Area(this Circle circle)
        {
            Console.Write("Circle area: ");
            return circle.Radius * circle.Radius * 3.1428;
        }

        public static double Circle_Perimeter(this Circle circle)
        {
            Console.Write("Circle perimeter: ");
            return 2 * 3.1428 * circle.Radius;
        }

        public static double Bowl_Area(this Bowl bowl)
        {
            Console.Write("Bowl area: ");
            return 4 * 3.1428 * bowl.Get_Radius() * bowl.Get_Radius();
        }
        public static double Bowl_Volume(this Bowl bowl)
        {
            Console.Write("Bowl volume: ");
            return (3.1428 * bowl.Get_Radius() * bowl.Get_Radius() * bowl.Get_Radius()) * (4 / 3);
        }

        public static double Cube_Area(this Cube cube)
        {
            Console.Write("Cube area: ");
            return cube.Get_Side() * cube.Get_Side() * 6;
        }

        public static double Cube_Perimeter(this Cube cube)
        {
            Console.Write("Cube perimeter: ");
            return 4 * cube.Get_Side() * 6;
        }

        public static double Cube_Volume(this Cube cube)
        {
            Console.Write("Cube volume: ");
            return cube.Get_Side() * cube.Get_Side() * cube.Get_Side();
        }
    }
}
