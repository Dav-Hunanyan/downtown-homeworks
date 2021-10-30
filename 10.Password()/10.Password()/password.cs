using System;
using System.Text;

namespace _10.Password__
{
    class Program
    {

        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine(Password());
                Console.Write("If you like your password exit(0 for exit) or repeat(Enter) :");
                answer = Console.ReadLine();

            } while (answer != "0");


        }

        static string Password()
        {
            Console.Write("Enter password length : ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Do you want capital letters in your passwprd(1.Yes 2.No) : ");
            int letters_up = int.Parse(Console.ReadLine());
            Console.Write("Do you want small letters in your passwprd(1.Yes 2.No) : ");
            int letters_low = int.Parse(Console.ReadLine());
            Console.Write("Do you want numbers in your passwprd(1.Yes 2.No) : ");
            int numbers = int.Parse(Console.ReadLine());
            Console.Write("Do you want symbols in your passwprd(1.Yes 2.No) : ");
            int symbols = int.Parse(Console.ReadLine());

            StringBuilder str_build = new StringBuilder();
            Random r = new Random();
            char letter;
            for (int i = 0; i < length;)
            {
                if (letters_up == 1 && i < length)
                {
                    int flt = r.Next(65, 90);
                    letter = Convert.ToChar(flt);
                    str_build.Append(letter);
                    i++;
                }
                if (letters_low == 1 && i < length)
                {
                    int flt = r.Next(97, 122);
                    letter = Convert.ToChar(flt);
                    str_build.Append(letter);
                    i++;
                }

                if (numbers == 1 && i < length)
                {
                    int flt = r.Next(48, 57);
                    letter = Convert.ToChar(flt);
                    str_build.Append(letter);
                    i++;
                }
                if (symbols == 1 && i < length)
                {
                    int flt = r.Next(33, 48);
                    letter = Convert.ToChar(flt);
                    str_build.Append(letter);
                    i++;
                }

            }

            return "Your password : " + str_build;
        }
    }
}
