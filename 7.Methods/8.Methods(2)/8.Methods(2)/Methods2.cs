using System;
using System.Text.RegularExpressions;
namespace _8.Methods_2_
{
    class Program
    {
        //Определить можно ли с использованием только операций
        //«прибавить 3» и «прибавить 5» получить из числа 1 число N

        static void add(double n)
        {
            for (int i = 0; i < n / 3; i++)
            {
                for (int j = 0; j < n / 5; j++)
                {
                    if (n - 1 == 3 * i + 5 * j)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }
            Console.WriteLine("No");
        }

        //Дана строка, содержащая только десятичные цифры.Найти и вывести наибольшую цифру.

        static int highest(string k)
        {
            if (k.Length > 1000)
            {
                throw new Exception("Error!!!!!!!!!");
            }
            for (int j = 0; j < k.Length; j++)
            {
                if (k[j] <= '0' || k[j] >= '9')
                {

                    throw new Exception("Error!!!!!!!!!");
                }
            }

            int max = 1;
            int number = int.Parse(k);
            int i = 1;
            while (number / i > 1)
            {

                if (max < (number / (i)) % 10)
                {
                    max = (number / (i)) % 10;
                }
                i *= 10;
            }
            return max;

        }

        //Дана строка, содержащая цифры и английские буквы (большие и маленькие).
        //Найти и вывести количество цифр.

        static int numbers(string k)
        {
            if (k.Length > 1000)
            {
                throw new Exception("Error!!!!!!!!!");
            }
            int count = 0;
            for (int j = 0; j < k.Length; j++)
            {


                if (k[j] >= '0' && k[j] <= '9')
                {
                    count++;

                }
            }
            return count;
        }

        //Дана строка, содержащая только английские буквы (большие и маленькие).
        //Добавить символ ‘*’ (звездочка) между буквами (перед первой буквой и
        //после последней символ ‘*’ добавлять не нужно).

        static string stars(string k)
        {
            Regex regex = new Regex(@"[a-z|A-Z]");
            MatchCollection matches = regex.Matches(k);
            if (k.Length != matches.Count)
            {
                throw new Exception("Error!!!...Your string must have only letters");
            }

            else
            {
                string result = "";

                for (int i = 0; i < k.Length; i++)
                {
                    if (i == k.Length - 1)
                    {
                        result += k[i];
                    }
                    else
                    {
                        result += k[i] + "*";
                    }

                }
                return result;
            }


        }

        //Добавить открывающиеся и закрывающиеся скобки по следующему образцу: "example" -> "(e(x(a(m)p)l)e)" 

        static string brackets(string k, int i = 0)
        {
            int last = k.Length - i - 1;
            if (i == 0)
            {
                Regex regex = new Regex(@"[a-z|A-Z]");
                MatchCollection matches = regex.Matches(k);
                if (k.Length != matches.Count)
                {
                    throw new Exception("Error!!!...Your string must have only letters");
                }
            }

            if (i == last)
            {
                return k[i] + "";
            }
            else if (k.Length / 2 == last)
            {
                return k[i] + "" + k[last];
            }

            return k[i] + "(" + brackets(k, i + 1) + ")" + k[last];


        }

        //Сформировать новую строку добавлением справа «зеркальной» строки с
        //закрывающимися скобками. "(abc(def(g" -> "(abc(def(gg)fed)cba)"

        static string mirror(string k)
        {
            Regex regex = new Regex(@"[a-z|A-Z|\(]");
            MatchCollection matches = regex.Matches(k);
            if (k.Length != matches.Count)
            {
                throw new Exception("Error!!!...Your string must have only letters and '(' symbol");
            }
            string k_mirror = "";
            for (int i = 0; i < k.Length; i++)
            {
                k_mirror += k[k.Length - i - 1];
            }

            string mirror = k + k_mirror.Replace('(', ')');
            return mirror;
        }

        //. Сформировать новую строку путем «сокращения» одинаковых букв, находящихся на
        //симметричных местах (то есть если на одинаковом расстоянии от центра строки
        //находятся 2 одинаковые буквы, то их нужно убрать из строки).

        static string symmetric(string k, int i = 0)
        {
            Regex regex = new Regex(@"[a-z]");
            MatchCollection matches = regex.Matches(k);
            if (k.Length != matches.Count)
            {
                throw new Exception("Error!!!...Your string must have only small letters ");
            }

            if (i == k.Length / 2)
            {
                return "";
            }
            if (k[i] == k[k.Length - i - 1])
            {
                return symmetric(k, i + 1);
            }
            return k[i] + symmetric(k, i + 1) + k[k.Length - i - 1];

        }

        static void Main(string[] args)
        {
            string r = Console.ReadLine();

            //call the method you want
          
        }
    }
}
