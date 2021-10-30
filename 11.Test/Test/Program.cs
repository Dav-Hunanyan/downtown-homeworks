using System;

namespace Test
{
    class Person
    {
        private int ID;
        private int Math;
        private int C_sharp;
        private Person[] persons;

        public Person(int a = 0, int b = 0, int c = 0)
        {
            this.ID = a;
            this.Math = b;
            this.C_sharp = c;
        }

        public int Get_ID()
        {
            return ID;
        }
        public int Get_Math()
        {
            return Math;
        }
        public int Get_C()
        {
            return C_sharp;
        }

        public void Print()
        {
            Console.WriteLine("ID: " + ID + "\tMath: " + Math + "\t C#: " + C_sharp);
        }

    }
    class Program
    {

        static void Add(ref Person[] persons, int i, ref Person item)
        {
            persons[i] = item;
        }
        static void Sort_id(ref Person[] persons)
        {
            for (int j = 0; j < persons.Length - 1; j++)
            {
                for (int i = 1 + j; i < persons.Length; i++)
                {
                    if (persons[i].Get_ID() < persons[i - 1].Get_ID())
                    {
                        Person temp = persons[i];
                        persons[i] = persons[i - 1];
                        persons[i - 1] = temp;
                    }
                }
            }

        }
        static void Sort_math(ref Person[] persons)
        {
            for (int j = 0; j < persons.Length - 1; j++)
            {
                for (int i = 1; i < persons.Length; i++)
                {
                    if (persons[i].Get_Math() < persons[i - 1].Get_Math())
                    {
                        Person temp = persons[i];
                        persons[i] = persons[i - 1];
                        persons[i - 1] = temp;
                    }
                }
            }

        }
        static void Sort_c(ref Person[] persons)
        {
            for (int j = 0; j < persons.Length - 1; j++)
            {
                for (int i = 1; i < persons.Length; i++)
                {
                    if (persons[i].Get_C() < persons[i - 1].Get_C())
                    {
                        Person temp = persons[i];
                        persons[i] = persons[i - 1];
                        persons[i - 1] = temp;
                    }
                }
            }

        }
        static void Delete(ref Person[] persons, int delete)
        {
            Person[] result = new Person[persons.Length - 1];
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].Get_ID() < delete)
                {
                    result[i] = persons[i];
                }
                if (persons[i].Get_ID() > delete)
                {
                    result[i - 1] = persons[i];
                }

            }
            persons = result;

        }
        static void Print(Person[] persons)
        {
            Console.WriteLine("__________________________________");
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Print();
            }
            Console.WriteLine("__________________________________");
        }


        static void Main(string[] args)
        {

            int command;
            Person[] persons = { };
            int size = 1;
            int id_generate = 1;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose the command");
                Console.Write("1.Add 2.Delete 3.Print 4.Exit   :  ");
                command = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                switch (command)
                {
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("ID: " + id_generate);
                            Console.Write("Math: ");
                            int math = int.Parse(Console.ReadLine());
                            Console.Write("C#: ");
                            int c_sharp = int.Parse(Console.ReadLine());
                            Person temp = new Person(id_generate, math, c_sharp);
                            Array.Resize(ref persons, size);
                            Add(ref persons, size - 1, ref temp);
                            size++;
                            id_generate++;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        {
                            Console.Write("Which ID you want to delete: ");
                            int delete = int.Parse(Console.ReadLine());
                            bool valide = false;
                            for (int k = 0; k < persons.Length; k++)
                            {
                                if (delete == persons[k].Get_ID())
                                {
                                    valide = true;
                                    break;
                                }

                            }
                            if (!valide)
                            {
                                Console.WriteLine("Wrong ID");

                            }
                            else
                            {
                                Delete(ref persons, delete);
                            }
                            size--;

                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        {
                            Console.WriteLine("Print 1.by ID  2.by Math  3.By C# 4.Print");
                            int print = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;

                            switch (print)
                            {
                                case 1:
                                    Sort_id(ref persons);
                                    Print(persons);
                                    break;
                                case 2:
                                    Sort_math(ref persons);
                                    Print(persons);
                                    break;
                                case 3:
                                    Sort_c(ref persons);
                                    Print(persons);
                                    break;
                                case 4:
                                    Print(persons);
                                    break;

                            }
                        }
                        break;
                }


            } while (command != 4);






        }
    }
}
