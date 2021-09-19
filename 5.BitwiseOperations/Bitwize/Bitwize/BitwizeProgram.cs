using System;

namespace Bitwize
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Add 1 to a given number without using arithmetic operator. 

            Console.Write("Input number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("x=" + Convert.ToString(x, 2));
            int y = 1;
            Console.WriteLine("y=" + Convert.ToString(y, 2));
            while (y != 0)
            {
                int z = x & y;
                Console.WriteLine("z=" + Convert.ToString(z, 2));
                x = x ^ y;
                Console.WriteLine("x=" + Convert.ToString(x, 2));
                y = z << 1;
                Console.WriteLine("y=" + Convert.ToString(y, 2));
            }
            Console.WriteLine(x);
            Console.WriteLine("x=" + Convert.ToString(x, 2));

            //2.Turn off a particular bit in a number.

            //Console.Write("Enter number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine(Convert.ToString(number, 2));

            //Console.Write("Enter particular bit index ");
            //int index = int.Parse(Console.ReadLine());

            //number = number & ~(1 << (index - 1));
            //Console.WriteLine(Convert.ToString(number, 2));



            //3.Detect if two integers have opposite signs.


            //Console.Write("number1 = ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("number2 = ");
            //int number2 = int.Parse(Console.ReadLine());

            //if( (number1^number2)<0)
            //{
            //    Console.WriteLine("Opposite signs");
            //}
            //else
            //{
            //    Console.WriteLine("Same signs");
            //}

        }
    }
}
