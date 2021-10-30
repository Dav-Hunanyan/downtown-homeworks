using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Static_Extension
{
    class Person
    {
        private string Name;
        private string Surname;
        private int Age;
        private static int counter = 0;

       
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            counter++;
        }

        public string Get_Name()
        {
            return Name;
        }
        public string Get_Surname()
        {
            return Surname;
        }
        public int Get_Age()
        {
            return Age;
        }
        public static int Get_Counter()
        {
            return counter;
        }
    }
}
