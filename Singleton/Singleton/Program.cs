using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Get_instance("Instance1");
            Singleton instance2 = Singleton.Get_instance("Instance2");
            Console.WriteLine(instance1.Name);
            Console.WriteLine(instance2.Name);
            Console.WriteLine();

            Sun sun = Sun.GetSun();
            Sun sun1 = Sun.GetSun();
        }
    }
}
