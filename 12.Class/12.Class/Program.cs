using System;

namespace _12.Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            Student[] array = new Student[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write((i + 1) + ".Enter name of the student: ");
                string name = Console.ReadLine();
                Console.Write("Enter surname of the student: ");
                string surname = Console.ReadLine();
                Console.Write("Enter faculty of the student: ");
                string faculty = Console.ReadLine();
                Console.Write("Enter age of the student: ");
                int age = int.Parse(Console.ReadLine());
                Student student = new Student(name, surname, faculty, age);
                student.fill(array, student, i);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("How many parts do you want to divide: ");
            int divide = int.Parse(Console.ReadLine());
            Seperate students = new Seperate(array, divide);
            for (int i = 0; i < students.result1.Length; i++)
            {
                Console.WriteLine("______________________________________");
                for (int j = 0; j < students.result1[i].Length; j++)
                {
                    students.result1[i][j].print();
                }
                Console.WriteLine("______________________________________");
            }


        }
    }
}
