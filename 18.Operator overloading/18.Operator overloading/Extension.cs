using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Operator_overloading
{
    static class Extension
    {
        public static double Area(this Rectangle rectangle)
        {
            return rectangle.A * rectangle.B;
        }

        public static double Area(this Triangle rectangle)
        {
            double P = (rectangle.A + rectangle.B + rectangle.C) / 2;
            return Math.Sqrt(P*(P - rectangle.A)*(P - rectangle.B)*(P - rectangle.C));
        }
    }
}
