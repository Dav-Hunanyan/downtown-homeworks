using System;

namespace _7.Methods_2_
{
    class Program
    {
        static int Natural1(int n, int start = 1)
        {
            if (n == start)
            {
                return n;
            }
            else
            {
                Console.Write(start + " ");
                return Natural1(n, start + 1);
            }
        }

        static int Natural2(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                Console.Write(n + " ");
                return Natural2(n - 1);
            }
        }

        static int Sum_natural3(int n)
        {
            int result = n;
            if (n == 1)
            {
                return 1;
            }
            else
            {
                result += Sum_natural3(n - 1);

                return result;
            }


        }

        static int Digits4(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                Console.Write(n % 10 + " ");
                return Digits4(n / 10);
            }
        }

        static int NumDigits5(int n,int count=0)
        {
         
        }
        static void Main(string[] args)
        {
            //1. Write a program in C# Sharp to print the first n natural number using recursion.

            //Console.Write("How many numbers to print : ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(Natural1(n));

            //2.Write a program in C# Sharp to print numbers from n to 1 using recursion.

            //Console.Write("How many numbers to print : ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(Natural2(n));

            //3.Write a program in C# Sharp to find the sum of first n natural numbers using recursion.

            //Console.Write("How many numbers to sum : ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("The sum of first " + n + " natural numbers is " + Sum_natural3(n));


            //4.Write a program in C# Sharp to display the individual digits of a given number using recursion.
            //Console.Write("Input a number: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("The digits in the number " + n + " are : ");
            //Console.Write(Digits4(n));

            //5.Write a program in C# Sharp to count the number of digits in a number using recursion.

            Console.Write("Input a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("The number " + n + " contains number of digits : " + NumDigits5(n));
        }
    }
}
