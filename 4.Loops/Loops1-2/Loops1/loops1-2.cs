using System;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача №333.Четные числа
            //Вводятся целые числа a и b.Гарантируется, что a не превосходит b
            //Выведите(через пробел) все четные числа от a до b(включительно).

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //if (a < b)
            //{
            //    Console.WriteLine("все четные числа от " + a + " до " + b);
            //    for (int i = a; i <= b; i++)
            //    {
            //        if (i%2==0)
            //        {
            //            Console.Write(i+" ");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" a превосходит b.....");
            //}




            //Задача №334.Остаток
            //Вводятся 4 числа: a, b, c и d.
            //Выведите все числа на отрезке от a до b, дающие остаток c при делении на d.
            //Если таких чисел не существует, то ничего выводить не нужно.

            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //int c = int.Parse(Console.ReadLine());
            //Console.Write("d = ");
            //int d = int.Parse(Console.ReadLine());

            //for (int i = a; i <=b; i++)
            //{
            //    if (i%d==c)
            //    {
            //        Console.Write(i+" ");
            //    }
            //}




            //Задача №335.Квадраты
            //Вводятся целые числа a и b. Гарантируется, что a не превосходит b.
            //Выведите все числа на отрезке от a до b, являющиеся полными квадратами.
            //Если таких чисел нет, то ничего выводить не нужно.


            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());

            //for (int i = a; i <= b; i++)
            //{
            //    double c = Math.Sqrt(i);
            //    if (c % 1 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }

            //}



            //Задача №339.Минимальный делитель
            //Найдите самый маленький натуральный делитель числа x, отличный от 1(2 <= x <= 30000).


            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= x / 2; i++)
            //{
            //    if (x % i == 0)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}


            //Задача №340.Делители числа
            //Выведите все натуральные делители числа x в порядке возрастания(включая 1 и само число).


            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= x; i++)
            //{
            //    if (x % i == 0)
            //    {
            //        Console.Write(i + " ");

            //    }
            //}


            //Задача №341.Количество делителей
            //Подсчитайте количество натуральных делителей числа x(включая 1 и само число; x≤2∗10^9).



            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //int count = 0;
            //for (int i = 1; i <= x; i++)
            //{
            //    if (x % i == 0)
            //    {
            //        count++;

            //    }
            //}
            //Console.WriteLine(count);


            //Задача №342.Сумма ста
            //Вводятся 100 чисел, сумму которых необходимо посчитать.

            //int sum = 0;

            //for (int i = 0; i < 100; i++)
            //{
            //    sum += int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine(sum);


            //Задача №343.Сумма чисел
            //Вводится число N, а затем N чисел, сумму которых необходимо вычислить.



            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(sum);


            //Задача №345.Нули
            //Вводится число N, а затем N чисел.
            //Подсчитайте и выведите, сколько среди данных N чисел нулей.



            //int n = int.Parse(Console.ReadLine());
            //int count = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    if (number==0)

            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);



            //Задача №346.Подсчет чисел
            //Подсчитайте, сколько среди данных N чисел нулей, положительных чисел, отрицательных чисел.


            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //int count_plus = 0;
            //int count_minus = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    if (number == 0)

            //    {
            //        count++;
            //    }
            //    else if (number > 0)
            //    {
            //        count_plus++;
            //    }
            //    else
            //        count_minus++;
            //}
            //Console.WriteLine("__________\n"+count);
            //Console.WriteLine(count_plus);
            //Console.WriteLine(count_minus);



            //Задача №347.Ноль или не ноль


            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    if (number==0)
            //    {
            //        count++;
            //    }

            //}
            //if (count>0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //    Console.WriteLine("No");



            //Задача №348.Уравнение по возрастанию
            //Найдите все целые решения уравнения ax3 +bx2 + cx + d = 0 
            //на отрезке[0, 1000] и выведите их в порядке возрастания. 
            //Если на данном отрезке нет ни одного решения, то ничего выводить не нужно.


            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //int c = int.Parse(Console.ReadLine());
            //Console.Write("d = ");
            //int d = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= 1000; i++)
            //{
            //    if (a*i*i*i+b*i*i+c*i+d==0)
            //    {
            //        Console.WriteLine(i+" ");
            //    }
            //}


            //Задача №350.Количество решений
            //Найдите все целые решения уравнения
            //(ax3 +bx2 + cx + d ) / (x - e) = 0 на отрезке[0, 1000] и выведите их количество.

            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //int c = int.Parse(Console.ReadLine());
            //Console.Write("d = ");
            //int d = int.Parse(Console.ReadLine());
            //Console.Write("e = ");
            //int e = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= 1000; i++)
            //{
            //    if ((a * i * i * i + b * i * i + c * i + d) / (i - e) == 0)
            //    {
            //        Console.WriteLine(i + " ");
            //    }
            //}



            //Задача №1430.ГНЧЭ - 1
            //"ГНЧЭ-1"  – сложное электронное устройство, выдающее каждую секунду очередное
            //число последовательности 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5... Ввиду дороговизны
            //электронных комплектующих вам поручено разработать эмулятор для этого устройства.



            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i + ", ");
            //        count++;
            //        if (count == n)
            //        {
            //            return;
            //        }
            //    }
            //}


        }

    }
}
