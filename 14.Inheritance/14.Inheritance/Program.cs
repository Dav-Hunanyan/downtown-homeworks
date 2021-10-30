using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Inheritance
{
    class Program
    {
        static void Add_teacher(ref Teacher[] teachers, string faculty)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Teacher[] temp = new Teacher[teachers.Length + 1];
            for (int i = 0; i < teachers.Length; i++)
            {
                temp[i] = teachers[i];
            }
            Console.Write("Teacher name: ");
            string teacher_name = Console.ReadLine();
            Console.Write("Teacher surname: ");
            string teacher_surname = Console.ReadLine();
            Console.Write("Teacher subject: ");
            string teacher_subject = Console.ReadLine();
            temp[temp.Length - 1] = new Teacher(teacher_name, teacher_surname, faculty, teacher_subject);
            teachers = temp;
        }

        static void Add_student(ref Student[][] students, int row, int group_size, string faculty, Teacher teacher)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Student[][] temp = new Student[row][];
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students[i].Length; j++)
                {
                    temp[i] = new Student[students[i].Length];
                    temp[i][j] = students[i][j];
                }

            }
            temp[row - 1] = new Student[group_size];
            course: Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Students course: ");
            int student_course = int.Parse(Console.ReadLine());
            if (student_course > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There are only 4 course in faculty");
                goto course;
            }
            for (int i = 0; i < temp[row - 1].Length; i++)
            {
                Console.Write((i + 1) + ".Student name: ");
                string student_name = Console.ReadLine();
                Console.Write("Student surname: ");
                string student_surname = Console.ReadLine();
                Console.Write("Student subject: ");
                string student_subject = Console.ReadLine();

                temp[row - 1][i] = new Student(student_name, student_surname, faculty, student_subject, student_course, teacher);
            }
            students = temp;
        }

        static void Print_teacher(Teacher[] teachers, Student[][] students, int teacher_number)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            teachers[teacher_number - 1].Print();
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = 0; i < students[teacher_number - 1].Length; i++)
            {
                students[teacher_number - 1][i].Print();
            }


        }

        static void Print_course(Student[][] students, int course)
        {

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i][0].Course == students[course - 1][0].Course)
                {
                    for (int j = 0; j < students[i].Length; j++)
                    {
                        students[i][j].Print();
                    }

                }
                Console.WriteLine();
            }
        }

        static void Print_faculty(Dean dean, Teacher[] teachers, Student[][] students)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            dean.Print();

            for (int i = 0; i < teachers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                teachers[i].Print();
                for (int j = 0; j < students[i].Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    students[i][j].Print();
                }
            }
        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter faculty: ");
            string faculty = Console.ReadLine();
            Console.Write("Enter dean name: ");
            string name_dean = Console.ReadLine();
            Console.Write("Enter dean surname: ");
            string surname_dean = Console.ReadLine();
            Dean dean = new Dean(name_dean, surname_dean, faculty);
            int command;

            Teacher[] teachers = new Teacher[0];
            int teachers_count = 0;
            Student[][] groups = new Student[teachers_count][];
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                start: Console.Write(" 1.Add group 2.Print 3.Exit   -  ");
                command = int.Parse(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        teachers_count++;
                        Console.Write("How many students study in group: ");
                        int group_size = int.Parse(Console.ReadLine());
                        Add_teacher(ref teachers, faculty);
                        Add_student(ref groups, teachers_count, group_size, faculty, teachers[teachers.Length - 1]);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("     Print students by");
                        print: Console.Write("1.Teacher  2.Course  3.Faculty   :   ");
                        int print = int.Parse(Console.ReadLine());
                        switch (print)
                        {
                            case 1:

                                for (int i = 0; i < teachers.Length; i++)
                                {
                                    Console.WriteLine((i + 1) + "." + teachers[i].Name + " " + teachers[i].Surname);
                                }
                                teacherchoose: Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Whose group you want to print: ");
                                int teacher_print = int.Parse(Console.ReadLine());
                                if (teacher_print > teachers.Length)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("We have no so much teacher in our faculty");
                                    goto teacherchoose;
                                }
                                Print_teacher(teachers, groups, teacher_print);

                                break;

                            case 2:
                                Console.WriteLine("\n   Choose course");
                                for (int i = 0; i < groups.Length; i++)
                                {
                                    Console.Write((i + 1) + "." + groups[i][0].Course + "\t");
                                }
                                coursechoose: Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("Which course do you want to print: ");
                                int course_print = int.Parse(Console.ReadLine());
                                if (course_print > groups.Length)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Choose right number");
                                    goto coursechoose;
                                }
                                Print_course(groups, course_print);
                                break;
                            case 3:
                                Print_faculty(dean, teachers, groups);
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Wrong command");
                                goto print;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Thank for using our program");
                        break;
                    default:
                        Console.WriteLine("Wrong command");
                        goto start;
                }
            } while (command != 3);




        }
    }
}
