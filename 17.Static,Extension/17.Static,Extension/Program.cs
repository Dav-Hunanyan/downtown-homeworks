using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Static_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Person person = new Person(name, surname, age);

            Console.WriteLine(person.NameSurname());
            person.Year();
            Console.WriteLine("Counter: " + Person.Get_Counter());


            Person person1 = new Person("Name", "Surname", 28);
            person1.NameSurname();
            person1.Year();

            Console.WriteLine("Counter: " + Person.Get_Counter());

        }
    }
}
