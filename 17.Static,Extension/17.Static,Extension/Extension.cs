using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Static_Extension
{
    static class Extension
    {
        public static string NameSurname(this Person person)
        {
            return person.Get_Name() + " " + person.Get_Surname();
        }

        public static void Year(this Person person)
        {
            Console.WriteLine(person.Get_Name()+" was born in "+(2021-person.Get_Age()));
        }
    }
}
