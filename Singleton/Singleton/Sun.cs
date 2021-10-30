using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Sun
    {
        private static Sun sun;
        private Sun()
        {
            Console.WriteLine("Sun");
        }

        public static Sun GetSun()
        {
            if (sun == null)
            {
                sun = new Sun();
            }
            return sun;
        }
    }
}
