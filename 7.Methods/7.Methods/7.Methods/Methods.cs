using System;

namespace _7.Methods
{
    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");
        }

        static void Method2()
        {
            Console.Write("Please input a name : ");
            string name = Console.ReadLine();
            Console.WriteLine("\nWelcome friend " + name);
            Console.WriteLine("Have a nice day");
        }

        static int Sum3(int a, int b)
        {
            return a + b;
        }

        static void Spaces4()
        {
            Console.Write("Please input a string : ");
            string a = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(a + " : contains " + count + " spaces");

        }

        static int SumArray5(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static void Swap6(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Now the 1st number is : " + a + ", and the 2nd number is : " + b);
        }

        static int Exponent7(int m, int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= m;
            }
            return result;
        }

        static void Fibonacci8(int n)
        {
            int a = 0;
            int b = 1;
            int c = a + b;
            Console.Write(a + " " + b + " ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(c + " ");
                a = b;
                b = c;
                c = a + b;

            }
        }

        static void Prime9(int number)
        {
            int count = 0;
            if (number == 1)
            {
                Console.WriteLine(number + " isn't prime number");
            }
            else
            {
                {

                }
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                        Console.WriteLine(number + " isn't prime number");
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(number + " is prime number");
                }
            }
        }

        static int IndividualDigits10(int n)
        {
            int result = 0;

            while (n > 0)
            {
                result += n % 10;
                n = n / 10;
            }
            return result;
        }

        static int Factorial11(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                int result = n * Factorial11(n - 1);
                return result;
            }


        }

        static int Fibonacci12(int n)
        {


            if (n == 2 || n == 3)
            {
                return 1;
            }
            else
            {
                return Fibonacci12(n - 2) + Fibonacci12(n - 1);


            }
        }

        static void Main(string[] args)
        {
            //1.Write a program in C# Sharp to create a user define function. 
            //Expected Output:
            //Welcome Friends!
            //Have a nice day!

            //Method1();

            //2.Write a program in C# Sharp to create a user define function with parameters. 
            //Test Data:
            //Please input a name : John
            //Expected Output:
            //Welcome friend John!
            //Have a nice day!

            //Method2();

            //3.Write a program in C# Sharp to create a function for the sum of two numbers. 

            //Console.Write("Input first number: ");
            //int first = int.Parse(Console.ReadLine());
            //Console.Write("Input second number: ");
            //int second = int.Parse(Console.ReadLine());
            //Console.WriteLine("The sum of two numbers is : "+Sum3(first,second));


            //4. Write a program in C# Sharp to create a function to input
            //a string and count number of spaces are in the string.

            //Spaces4();

            //5.Write a program in C# Sharp to calculate the sum of elements in an array.

            //Console.WriteLine("Size of array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i <arr.Length; i++)
            //{
            //    Console.Write("Input "+i+" element: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Sum of array elements: "+SumArray5(arr));

            //6.Write a program in C# Sharp to create a function to swap the values of two integer numbers.

            //Console.Write("Input first number: ");
            //int first = int.Parse(Console.ReadLine());
            //Console.Write("Input second number: ");
            //int second = int.Parse(Console.ReadLine());
            //Swap6(first, second);

            //7. Write a program in C# Sharp to create a function to
            //calculate the result of raising an integer number to another. 

            //Console.Write("Input Base number: ");
            //int base_number = int.Parse(Console.ReadLine());
            //Console.Write("Input the Exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //Console.WriteLine("So, the number " + base_number +
            //    " ^ (to the power)" + exponent + " =" + Exponent7(base_number, exponent));


            //8.Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.

            //Console.Write("Input number of Fibonacci Series : ");
            //int n = int.Parse(Console.ReadLine());
            //Fibonacci8(n);

            //9.Write a program in C# Sharp to create a function to check whether a number is prime or not.

            //Console.Write("Input number: ");
            //int n = int.Parse(Console.ReadLine());
            //Prime9(n);

            //10. Write a program in C# Sharp to create
            //a function to calculate the sum of the individual digits of a given number.

            //Console.Write("Input number: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("The sum of the digits of the number "+n+" is: "IndividualDigits10(n));

            //11.Write a program in C# Sharp to create a recursive function
            //to find the factorial of a given number. 


            //Console.Write("Input number: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("The factorial of "+n+" is: "+Factorial(n));

            //12.Write a program in C# Sharp to create a recursive function to
            //calculate the Fibonacci number of a specific term. 

            //Console.Write("Input number: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("The Fibonacci of " + n + "th term is: " + Fibonacci12(n));
        }
    }
}
