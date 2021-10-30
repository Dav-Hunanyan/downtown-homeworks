using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Class
{
    class Seperate
    {

        public Student[][] result1;

        static void Delete(ref Student[] persons, int delete)
        {
            Student[] result = new Student[persons.Length - 1];
            for (int i = 0; i < persons.Length; i++)
            {
                if (i < delete)
                {
                    result[i] = persons[i];
                }
                if (i > delete)
                {
                    result[i - 1] = persons[i];
                }

            }
            persons = result;
        }
        public Seperate(Student[] arr, int seperator)
        {
            Random r = new Random();


            int n = arr.Length / seperator;
            int rest = arr.Length % seperator;


            result1 = new Student[seperator][];
            Student[] temp = arr;

            for (int i = 0; i < seperator; i++)
            {
                Student[] col;
                if (rest > 0)
                {
                    col = new Student[n + 1];
                    rest--;
                }
                else
                {
                    col = new Student[n];
                }
                for (int j = 0; j < col.Length; j++)
                {
                    int rand = r.Next(0, temp.Length - 1);
                    col[j] = temp[rand];
                    Delete(ref temp, rand);
                }
                result1[i] = col;
            }




        }
    }
}

