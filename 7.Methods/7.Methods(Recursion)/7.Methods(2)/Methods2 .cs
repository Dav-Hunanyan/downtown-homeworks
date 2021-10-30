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

        static int NumDigits5(int n, int count = 0)
        {

            if (n < 10)
            {
                count++;
                return count;
            }
            else
            {

                return NumDigits5(n / 10, count + 1);

            }
            return count;
        }

        static int odd(int n, int i = 1)
        {

            if (n == 1)
            {
                return i;
            }
            if (n % 2 == 0)
            {
                return odd(n - 1);
            }
            if (n % 2 == 1)
            {
                Console.Write(i + " ");
                return odd(n - 2, i + 2);
            }
            return i;

        }
        static int even(int n, int i = 2)
        {


            if (n == 2)
            {
                return i;
            }
            if (n % 2 == 1)
            {
                return even(n - 1);
            }
            if (n % 2 == 0)
            {
                Console.Write(i + " ");
                return even(n - 2, i + 2);
            }
            return i;


        }

        static bool prime(int n, int i = 2)
        {
            bool result = true;
            if (i > n / 2)
            {
                return result;
            }
            else
            {
                if (i <= n / 2)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Isn't prime");
                        result = false;

                        return result;
                    }
                    return prime(n, i + 1);
                }

            }
            return result;
        }

        static bool Palindrome(string str, int i = 0)
        {
            bool result = true;
            if (i == str.Length / 2)
            {
                Console.WriteLine("Is palindrome");
                return result;

            }
            else
            {
                if (str[i] == str[str.Length - 1 - i])
                {
                    return Palindrome(str, i + 1);
                }
                else
                {
                    Console.WriteLine("Isn't palindrome");
                    result = false;
                    return result;
                }


            }
            return result;
        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static int Fibonacci(int num, int i = 1, int first = 0, int second = 1)
        {

            if (i == num)
            {
                return first;
            }
            Console.Write(first + " ");
            return Fibonacci(num, ++i, second, first + second);
        }

        static string reverse(string str, int i = 0)
        {
            if (i == str.Length)
            {
                return "";
            }
            else
            {
                return str[str.Length - 1 - i] + reverse(str, i + 1);
            }
        }

        static int power(int num, int exp)
        {
            if (exp == 0)
            {
                return 1;
            }
            else
            {
                return num * power(num, exp - 1);
            }
        }

        static int binary(int num, string result = "")
        {
            if (num == 1)
            {
                result += "1";

            }
            else
            {
                result += "" + num % 2 + "";
                return binary(num / 2, result);
            }
            result = reverse(result);
            return Convert.ToInt32(result);

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

            //Console.Write("Input a number: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("The number " + n + " contains number of digits : " + NumDigits5(n));


            //6. Write a program in C to print even or odd numbers in a given range using recursion. 

            //Console.Write("Input the range to print starting from 1 : ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Odd numbers: ");
            //Console.WriteLine(odd(n));
            //Console.Write("Even numbers: ");
            //Console.WriteLine(even(n));

            //7. Write a program in C# Sharp to check whether a number is prime or not using recursion.
            //Console.Write("Input any positive number :");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(prime(n));

            //8. Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion. 
            //Console.Write("Input a string : ");
            //string str = Console.ReadLine();
            //Console.WriteLine(Palindrome(str));

            //9. Write a program in C# Sharp to find the factorial of a given number using recursion.

            //Console.Write("Input any positive number :");
            //int n = int.Parse(Console.ReadLine());            
            //Console.WriteLine(Factorial(n));

            //10. Write a program in C# Sharp to find the Fibonacci numbers for a n numbers of series using recursion.
            //Console.Write("Input number of terms for the Fibonacci series :");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(Fibonacci(n));

            //13.Write a program in C# Sharp to convert a decimal number to binary using recursion.
            //Console.Write("Input any positive number :");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(binary(n));


            //14. Write a program in C# Sharp to get the reverse of a string using recursion.
            //Console.Write("Input a string: ");
            //string str = Console.ReadLine();
            //Console.WriteLine(reverse(str));

            //15. Write a program in C# Sharp to calculate the power of any number using recursion.
            //Console.Write("Input the base value : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("Input the exponent : ");
            //int exp = int.Parse(Console.ReadLine());
            //Console.WriteLine(power(num,exp));




        }
    }
}
