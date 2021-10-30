using System;

namespace _8.Methods
{
    class Program
    {

        static int min(int a, int b, int c, int d)
        {
            int[] arr = { a, b, c, d };        //Напишите функцию int min (int a, int b, int c, int d),
                                               //находящую наименьшее из четырех данных чисел.
            Array.Sort(arr);
            return arr[0];
        }

        static double power(double a, uint n)
        {
            if (n == 0)
            {
                return 1;                        //Напишите функцию double power (double a, int n),
            }                                    //вычисляющую значение a^n.
            else
            {

                return a * power(a, n - 1);
            }
        }

        static bool Xor(bool x, bool y)
        {
            if ((x == true && y == false) || x == false && y == true)
            {
                return true;              //Напишите функцию bool Xor(bool x, bool y)
                                          // Функция Xor должна возвращать true, если
                                          // ровно один из ее аргументов x или y, но не оба одновременно равны true.
            }
            else
            {
                return false;
            }
        }

        static bool election(bool x, bool y, bool z)
        {
            bool result = true;
            if (x == y || x == z)          //Напишите "функцию голосования" bool Election(bool x, bool y, bool z)
            {                              //, возвращающую то значение (true или false),
                                           //которое среди значений ее аргументов x, y, z встречается чаще.
                result = x;
            }
            if (z == y)
            {
                result = y;

            }
            return result;
        }

        static void prime(int a)
        {
            if (a <= 1 || a > 200000000)
            {
                Console.WriteLine("Error");
                return;
            }
            else
            {
                for (int i = 2; i <= a / 2; i++)
                {
                    if (a % i == 0)
                    {
                        Console.WriteLine("Isn't prime");
                        return;
                    }
                }
                Console.WriteLine("Prime number");
            }


        }

        static double power(double a, int n)
        {
            if (n == 0)
            {
                return 1;               //Необходимо вывести  значение a^n
                                        // (число n может быть отрицательным).
            }
            else
            {

                return 1 / a * power(a, n + 1);

            }
        }

        static double factorial(double a)
        {
            if (a == 1)
            {
                return 1;
            }
            else
            {
                return a * factorial(a - 1);
            }
        }

        static double Binomial_coefficients(double n, double k)
        {
            if (n >= k)
            {
                return factorial(n) / (factorial(k) * factorial(n - k));
            }
            else return 0;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(Binomial_coefficients(4, 2));


        }
    }
}
