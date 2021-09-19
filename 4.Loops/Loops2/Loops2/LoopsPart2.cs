using System;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №113.Список квадратов
            //Выведите все точные квадраты натуральных чисел, не превосходящие данного числа N.


            //Console.WriteLine("Input number");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Список квадратов, не превосходящие числа "+number);
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i * i <= number)
            //        Console.WriteLine(i * i);
            //}


            //Задача №3058.Минимальный делитель
            //Дано целое число, не меньшее 2.Выведите его наименьший натуральный делитель, отличный от 1.


            //Console.WriteLine("Input number");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= number; i++)
            //{
            //    if (number%i==0)
            //    {
            //        Console.WriteLine("Минимальный делитель :"+i);
            //        break;
            //    }
            //}


            //Задача №3059.Список степеней двойки
            //По данному числу N распечатайте все целые степени двойки, не превосходящие N, в порядке возрастания.


            //Console.WriteLine("Input number");
            //int number = int.Parse(Console.ReadLine());
            //int n = 2;
            //int r = 2;
            //Console.WriteLine("Список степеней двойки");
            //for (int i = 1; i <= number; i++)
            //{
            //    if (r < number)
            //    {
            //        Console.WriteLine(r);
            //        r *= n;
            //    }
            //}



            //Задача №3060.Точная степень двойки
            //Дано натуральное число N. Выведите слово YES, если число N 
            //является точной степенью двойки, или слово NO в противном случае.
            //Операцией возведения в степень пользоваться нельзя!


            //Console.WriteLine("Input number");
            //int number = int.Parse(Console.ReadLine());
            //int n = 2;
            //int r = 1;


            //for (int i = 1; i <= number; i++)
            //{
            //    if (r <= number)
            //    {
            //        if (number == r)
            //        {
            //            Console.WriteLine("Yes");
            //            return;
            //        }
            //        r *= n;

            //    }
            //    if (r>number)
            //    {
            //        Console.WriteLine("No");
            //        return;
            //    }
            //}



            //Задача №3061.Двоичный логарифм
            //По данному натуральному числу N выведите такое наименьшее целое число k, что 2^k≥N.


            //Console.WriteLine("Input number");
            //int n = int.Parse(Console.ReadLine());
            //int k = 0;
            //int r = 1;
            //do
            //{
            //    k++;
            //    r *= 2;

            //} while (n>r);
            //Console.WriteLine("2^"+k+">"+n);
            //Console.WriteLine("2^" + k + "=" + r);


            //Задача №3062.Утренняя пробежка
            //В первый день спортсмен пробежал x километров, а затем он каждый день увеличивал
            //пробег на 10 % от предыдущего значения. По данному числу y определите номер дня,
            //на который пробег спортсмена составит не менее y километров.


            //Console.Write("В первый день спортсмен пробежал :");
            //double x = double.Parse(Console.ReadLine());
            //Console.WriteLine("A затем он каждый день увеличивал пробег на 10 %.");
            //Console.Write("день на который пробег спортсмена составил (y) километров: ");
            //double y = double.Parse(Console.ReadLine());
            //double day_km = x;
            //int day = 1;
            //do
            //{
            //    day++;
            //    day_km = day_km + (day_km / 10);

            //} while (day_km <=y);
            //Console.WriteLine(day);



            //Задача №3063.Банковские проценты
            //Вклад в банке составляет x рублей.Ежегодно он увеличивается на p процентов, 
            //после чего дробная часть копеек отбрасывается.Каждый год сумма вклада становится больше.
            //Определите, через сколько лет вклад составит не менее y рублей.


            //Console.Write("Вклад в банке:");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Ежегодно он увеличивается на (p) процентов: ");
            //double p = double.Parse(Console.ReadLine());
            //Console.Write("через сколько лет вклад составит не менее (y) рублей: ");
            //double y = double.Parse(Console.ReadLine());
            //int year = 0;
            //double year_money = x;

            //do
            //{
            //    year++;
            //    year_money = year_money + (year_money * p) / 100;
            //    year_money = Math.Floor(year_money);

            //} while (year_money<y);
            //Console.WriteLine(year);



            //Задача №3074.Числа Фибоначчи
            //Последовательность Фибоначчи определяется так:
            //φ0 = 0,  φ1 = 1, ..., φn = φn - 1 + φn - 2.
            //По данному числу n определите n-е число Фибоначчи φn.



            //Console.Write("determine the (n) Fibonacci number : ");
            //int n = int.Parse(Console.ReadLine());
            //int n1 = 0, n2 = 1, n3 = n1 + n2;
            //if (n == 1)
            //{
            //    Console.WriteLine(n1);
            //}
            //else if (n == 2)
            //{
            //    Console.WriteLine(n2);

            //}
            //else
            //{
            //    for (int i = 3; i <= n; i++)
            //    {
            //        n1 = n2;
            //        n2 = n3;
            //        n3 = n1 + n2;
            //    }
            //    Console.WriteLine(n3);
            //}


            //Задача №3075.Номер числа Фибоначчи
            //Дано натуральное число A > 1.Определите, каким по счету числом Фибоначчи оно является,
            //то есть выведите такое число n, что φn = A.Если А не является числом Фибоначчи, 
            //выведите число -1.


            //Console.WriteLine("Number of (A) fibonacci: ");
            //int A = int.Parse(Console.ReadLine());


            //int n1 = 0, n2 = 1, n3 = n1 + n2;
            //int count = 3;
            //{
            //    if (A == 0)
            //    {
            //        Console.WriteLine(A + "  является 1 числом Фибоначчи");
            //    }
            //    else if (A == 1)
            //    {
            //        Console.WriteLine(A + "  является 2 или 3 числом Фибоначчи");
            //    }
            //    else
            //    {
            //        do
            //        {
            //            if (A > n3)
            //            {
            //                n1 = n2;
            //                n2 = n3;
            //                n3 = n1 + n2;
            //            }
            //            count++;
            //            if (A < n3)
            //            {
            //                Console.WriteLine(A + " не является числом Фибоначчи");

            //            }
            //            if (A == n3)
            //            {
            //                Console.WriteLine(A + "  является " + count + " числом Фибоначчи");
            //            }
            //        } while (A > n3);
            //    }
            //}




            //Задача №3076.Исполнитель Раздвоитель
            //Исполнитель “Раздвоитель” преобразует натуральные числа.У него есть две команды: 
            //“Вычесть 1” и “Разделить на 2”, первая команда уменьшает число на 1,
            //вторая команда уменьшает число в два раза, если оно чётное, иначе происходит ошибка.
            //Дано два натуральных числа A и B(A > B).
            //Напишите алгоритм для Развоителя, который преобразует число A в число B и при этом содержит
            //минимальное число команд.Команды алгоритма нужно выводить по одной в строке,
            //первая команда обозначается, как -1, вторая команда как: 2.


            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());

            //do
            //{
            //    if (B * 2 < A)
            //    {
            //        if (A % 2 == 1)
            //        {
            //            A = A - 1;
            //            Console.WriteLine("-1");
            //        }
            //        if (A % 2 == 0)
            //        {
            //            A = A / 2;
            //            Console.WriteLine("/2");
            //        }
            //    }

            //    if (B * 2 >= A)
            //    {
            //        A = A - 1;
            //        Console.WriteLine("-1");
            //    }

            //} while (A != B);



        }
    }
}
