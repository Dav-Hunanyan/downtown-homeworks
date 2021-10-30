using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Class
{
    class Student
    {
        string name;
        string surname;
        string faculty;
        int age;
        public Student(string name, string surname, string faculty, int age)
        {
            this.name = name;
            this.age = age;
            this.surname = surname;
            this.faculty = faculty;
        }

        public void fill(Student[] arr, Student item, int i)
        {
            arr[i] = item;
        }
        public void print()
        {
            Console.WriteLine("Name: " + name + "\t\tSurname: " + surname + "\t\tFaculty: " + faculty + "\t\tAge: " + age);
        }
        public string get_name()
        {
            return name;
        }
        public void set_name(string k)
        {
            name = k;
        }
        public int get_age()
        {
            return age;
        }
        public void set_age(int k)
        {
            age = k;
        }

        public string Surname
        {
            set
            {
                surname = value;
            }
            get
            {
                return surname;
            }
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }
    }

}



