using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = { new Lion(), new Deer(), new Shark(), new Eagle() };
            for (int i = 0; i < animal.Length; i++)
            {
                animal[0].Eat();
                Console.WriteLine();
            }

            Lion lion = new Lion();
            lion.Swim(); lion.Hunt(); lion.Eat(); lion.Run();
            Console.WriteLine();
            Deer deer = new Deer();
            deer.Run();
            deer.Escape();
            deer.Eat();
            Console.WriteLine();
            Eagle eagle = new Eagle();
            eagle.Fly();
            eagle.Hunt();
            eagle.Eat();
            Console.WriteLine();
            Shark shark = new Shark();
            shark.Swim();
            shark.Hunt();
            shark.Eat();
        }
    }
}
