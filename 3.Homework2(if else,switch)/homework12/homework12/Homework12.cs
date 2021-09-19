using System;

namespace homework12
{
    class Program
    {
        static void Main(string[] args)
        {
            //  12.	Թավայում միաժամանակ կարելի է դնել к թվով կոտլետ։
            //   Յուրաքանչյուր կոտլետ ամեն կողմից պետք է տապակել t րոպե։
            //   Ո՞րքան ամենքիչ ժամանակը կպահանջվի n թվով կոտլետներ
            //   երկկողմանի տապակելու համար։
            //   Մուտքային տվյալները k , t , n: թվերը չեն գերազանցում 32000 - ը։ 
            //   Օրինակ
            //   1
            //   5
            //   1
            //   Պատասխան
            //   10

            Console.WriteLine("How many cotlets can be put in the pan?");
            double k = int.Parse(Console.ReadLine());
            Console.WriteLine("How many minutes is cotlet frying?");
            double t = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cotlets you want to fry?");
            double n = int.Parse(Console.ReadLine());

            if (k > 32000 || t > 32000 || n > 32000)
            {
                Console.WriteLine("Error");
            }

            double answer =n / k;
            
            Console.WriteLine("Answer\n"+Math.Ceiling(answer)*2*t);

        }
    }
}
