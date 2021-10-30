using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Singleton
    {
        private static Singleton instance;
        public string Name { get; private set; }
        private Singleton(string name)
        {
            Console.WriteLine("Singleton constructor");
            Name = name;
        }
        public static Singleton Get_instance(string name)
        {
            if (instance == null)
            {
                instance = new Singleton(name);
            }
            return instance;
        }
    }
}
