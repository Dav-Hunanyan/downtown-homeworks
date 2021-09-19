using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №315.Сумма квадратов
            //По данному натуральному n вычислите сумму  1^2+2^2+...+n^2..


            //Console.WriteLine("Input number from 1 to 100");
            //int number = int.Parse(Console.ReadLine());
            //int sum = 0;

            //if (number < 0 || number > 100)
            //{
            //    Console.WriteLine("Your number must be from 1 to 100");
            //}
            //else
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (i == number)
            //        {
            //            sum += i * i;
            //            Console.Write(i + "^2");
            //        }
            //        else
            //        {
            //            sum += i * i;
            //            Console.Write(i + "^2+");
            //        }
            //    }
            //}
            //Console.Write("=" + sum);



            //Задача №351.Факториал
            //Вычислите N!("эн-факториал") – произведение всех натуральных чисел от 1 до N(N!= 1∙2∙3∙…∙ N ).

            //Console.WriteLine("Input number from 1 to 12");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write(number + "!=");
            //int result = 1;
            //if (number < 0 || number > 12)
            //{
            //    Console.WriteLine("Error");
            //}
            //else
            //{

            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (number == i)
            //        {
            //            result *= i;
            //            Console.Write(i);
            //        }
            //        else
            //        {
            //            result *= i;
            //            Console.Write(i + " * ");
            //        }
            //    }

            //}
            //Console.WriteLine("\n" + number + "! = " + result);




            //Задача №352.Степень
            //Напишите программу, вычисляющую 2 N.

            //Console.WriteLine("Input number from 1 to 30");
            //int number = int.Parse(Console.ReadLine());
            //int result = 1;
            //Console.Write("2^" + number + " = ");
            //for (int i = 1; i <= number; i++)
            //{
            //    result *= 2;
            //}
            //Console.Write(result);




            //Задача №317.Число сочетаний
            //По данным натуральным n и k вычислите значение 
            //Ckn = n!/(k!(n−k)!)(число сочетаний из n элементов по k).


            //Console.WriteLine("Input 2 numbers from 1 to 30");
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("k = ");
            //int k = int.Parse(Console.ReadLine());
            //int cnk = 1;
            //int fact_n = 1;
            //int fact_k = 1;
            //int fact_nk = 1;

            //if (n < 30 && k < 30 && n > k)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        fact_n *= i;
            //    }
            //    for (int i = 1; i <= k; i++)
            //    {
            //        fact_k *= i;
            //    }
            //    for (int i = 1; i <= n - k; i++)
            //    {
            //        fact_nk *= i;
            //    }

            //    cnk = fact_n / (fact_k * fact_nk);
            //    Console.WriteLine(cnk);
            //}else
            //    Console.WriteLine("Error!!!!!!");




            //Задача №319.Геометрическая прогрессия
            //По данному действительному числу a и натуральному n вычислите
            //сумму 1 + a + a^2 + ...+a^n, не используя формулу суммы геометрической прогрессии. 
            //Время работы программы должно быть пропорционально n.


            //Console.WriteLine("Input 2 numbers");
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 1;
            //int a_astijan = 1;
            //int i = 1;
            //Console.Write(a_astijan + "+");
            //do
            //{
            //    a_astijan *= a;
            //    sum += a_astijan;
            //    Console.Write(a_astijan + "+");
            //    i++;

            //} while (i <= n);
            //Console.Write("=" + sum);


            //Задача №320.Сумма - 1
            //По данному числу n вычислите сумму 1 + 1 / 2^2 + 1 / 3^2 + ...+1 / n^2.



            //          Console.WriteLine("Input number from 1 to 100");
            //double number = double.Parse(Console.ReadLine());
            //double sum = 0;

            //if (number < 0 || number > 100)
            //{
            //    Console.WriteLine("Your number must be from 1 to 100");
            //}
            //else
            //{
            //    for (double i = 1; i <= number; i++)
            //    {
            //        if (i == number)
            //        {
            //            sum +=1/( i * i);
            //            Console.Write("1/"+i + "^2");
            //        }
            //        else
            //        {
            //            sum += 1/(i * i);
            //            Console.Write("1/"+i + "^2 + ");
            //        }
            //    }
            //}
            //Console.Write(" = " + sum);



            //Задача №321.Сумма - 2
            //По данному числу n вычислите сумму 4(1 - 1 / 3 + 1 / 5 - 1 / 7 + ...+(-1)^n / (2n + 1)).


            //Console.WriteLine("Input number ");
            //double number = double.Parse(Console.ReadLine());
            //double sum = 0;

            //for (double i = 1; i <= 2 * number + 1; i += 4)
            //{
            //    sum += 1 / i;
            //    if (i < 2 * number + 1)
            //    {
            //        Console.Write("1/" + i + "+");
            //    }
            //    else
            //        Console.Write("1/" + i);

            //}
            //for (double i = 3; i <= 2 * number + 1; i += 4)
            //{
            //    sum -= 1 / i;

            //    Console.Write("-1/" + i);
            //}
            //Console.WriteLine("=" + 4 * sum);



            //Задача №353.Сумма степеней
            //Вводится натуральное число N, которое не превосходит 30.
            //Вычислите 1 + 2 + 2^2 + 2^3 +…+2^N.


            //Console.WriteLine("Input number ");
            //int number = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int res = 1;
            //Console.Write(res + "+");
            //for (int i = 0; i < number; i++)
            //{
            //    if (i == number - 1)
            //    {

            //        res *= 2;
            //        sum += res;
            //        Console.Write(res);
            //    }
            //    else
            //    {
            //        res *= 2;
            //        Console.Write(res + "+");
            //        sum += res;
            //    }
            //}
            //Console.Write("=" + (sum + 1));



            //Задача №120. 1 / 0! + 1 / 1! + 1 / 2! + ...
            //По данному натуральному числу N найдите сумму чисел
            //1 + 1 / 1! + 1 / 2! + 1 / 3! + ...+1 / N!.
            //Количество действий должно быть пропорционально N.



            //Console.WriteLine("Input number ");
            //double number = double.Parse(Console.ReadLine());
            //double sum = 0;
            //double fact = 1;
            //double member = 1;
            //for (double i = 1; i <= number; i++)
            //{

            //    fact *= i;

            //    member = 1 / fact;
            //    sum += member;
            //    if (number == i)
            //    {
            //        Console.Write("1/" + fact);
            //    }
            //    else
            //    {
            //        Console.Write("1/" + fact + " + ");
            //    }

            //}
            //Console.Write(" = " + sum);


            //Задача №318.Степень
            //По данному действительному числу a и целому неотрицательному n вычислите величину an.



            //Console.WriteLine("Input 2 numbers");
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //int result = 1;
            //if (a > 0 && n > 0)
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        result *= a;
            //    }
            //}
            //Console.WriteLine(a + "^" + n + "=" + result);





        }
    }
}

