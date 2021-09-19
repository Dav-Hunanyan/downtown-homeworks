using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number");
            Random r = new Random();
            string number = Convert.ToString(r.Next(1000, 10000));

            do
            {
                string user_number = Console.ReadLine();
                int count_number = 0;
                int count_position = 0;
                if (user_number.Length != number.Length)
                {
                    Console.WriteLine("Your number must have four digits");
                    continue;
                }

                for (int i = 0; i < 4; i++)
                {

                    for (int j = 0; j < 4; j++)
                    {
                        if (number[i] == user_number[j])
                        {
                            count_number++;

                        }
                        if (i == j && number[i] == user_number[j])
                        {
                            count_position++;

                        }

                    }
                }
                Console.WriteLine("count position: " + count_position);
                Console.WriteLine("count number: " + count_number);
                if (user_number == number)
                {
                    Console.WriteLine("You win");
                    break;
                }
            } while (true);

        }
    }
}
