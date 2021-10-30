using System;

namespace _8.Methods_3_
{
    class Program
    {
        //Даны два числа. Найти их наибольший общий делитель.

        static int divisor(int num1, int num2)
        {
            int divisor;
            if (num1 > num2)
            {
                divisor = num2;
            }
            else divisor = num1;

            if (num1 > 0 && num2 > 0)
            {
                while (true)
                {
                    if (num1 % divisor == 0 && num2 % divisor == 0)
                    {
                        Console.Write("The divisor of the two given numbers: ");
                        return divisor;
                    }
                    divisor--;
                }
            }
            else return 1;
        }



        static void Main(string[] args)
        {

        }
    }
}
