using System;

namespace _10.program__
{
    class Program
    {
        static void converter_distance(double n, string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "sm")
                {
                    Console.WriteLine(n + " sm");
                }
                if (arr[i] == "dcm")
                {
                    Console.WriteLine(n / 10 + "dcm");
                }
                if (arr[i] == "m")
                {
                    Console.WriteLine(n / 100 + "m");
                }
                if (arr[i] == "km")
                {
                    Console.WriteLine(n / 100 / 1000 + "km");
                }
            }


        }
        static void converter_area(double n, string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "sm")
                {
                    Console.WriteLine(n + " sm^2");
                }
                if (arr[i] == "dcm")
                {
                    Console.WriteLine(n / 100 + "dcm^2");
                }
                if (arr[i] == "m")
                {
                    Console.WriteLine(n / 10000 + "m^2");
                }
                if (arr[i] == "km")
                {
                    Console.WriteLine(n / 10000000000 + "km^2");
                }
            }
        }

        static void Main(string[] args)
        {
            string finish;
            do
            {

                Console.Write("Please enter unit of measurement(1.sm 2.dcm 3.m 4.km) : ");
                int unit = int.Parse(Console.ReadLine());
                Console.Write("Input the number to convert : ");
                double number = int.Parse(Console.ReadLine());
                Console.Write("Convert to(1.sm 2.dcm 3.m 4.km) : ");
                string conv = Console.ReadLine();
                Console.Write("Choose distance(1) or area(2) : ");
                int dis_area = int.Parse(Console.ReadLine());
                string[] arr = conv.Split(',');


                if (dis_area == 1)
                {
                    switch (unit)
                    {
                        case 1:
                            number = number * 1;
                            break;
                        case 2:
                            number = number * 10;
                            break;
                        case 3:
                            number = number * 100;
                            break;
                        case 4:
                            number = number * 100 * 1000;
                            break;
                        default:
                            Console.WriteLine("Error!!!");
                            break;
                    }

                    converter_distance(number, arr);
                }
                if (dis_area == 2)
                {

                    switch (unit)
                    {
                        case 1:
                            number = number * 1;
                            break;
                        case 2:
                            number = number * 100;
                            break;
                        case 3:
                            number = number * 10000;
                            break;
                        case 4:
                            number = number * 10000000000;
                            break;
                        default:
                            Console.WriteLine("Error!!!");
                            break;
                    }

                    converter_area(number, arr);

                }


                Console.WriteLine("\n____________________");
                Console.WriteLine("Enter to continue(0 for exit): ");
                finish = Console.ReadLine();
            } while (finish != "0");
        }
    }
}
