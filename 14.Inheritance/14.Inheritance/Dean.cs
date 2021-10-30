using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Inheritance
{

    class Dean
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Faculty { get; set; }
        public Dean(string name, string surname, string faculty)
        {
            Name = name;
            Surname = surname;
            Faculty = faculty;
        }

        public void Print()
        {
            Console.Write("Name: " + Name + "\tSurname: " + Surname + "\tFaculty: " + Faculty);

        }
    }

    class Teacher : Dean
    {
        public string Subject { get; set; }
        public Teacher(string name, string surname, string faculty, string subject) : base(name, surname, faculty)
        {
            Subject = subject;
        }

        public new void Print()
        {
            Console.WriteLine();
            base.Print();
            Console.Write("\tSubject: " + Subject);
        }
    }

    class Student : Teacher
    {
        public int Course { get; set; }
        public Teacher Teacher { get; set; }
        public Student(string name, string surname, string faculty, string subject, int course, Teacher teacher) : base(name, surname, faculty, subject)
        {
            Course = course;
            Teacher = teacher;
        }
        public new void Print()
        {

            base.Print();
            Console.Write("\tCourse: " + Course);
            Console.Write("\tTeacher: " + Teacher.Name + " " + Teacher.Surname);
        }
    }
}
