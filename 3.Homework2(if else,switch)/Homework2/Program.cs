using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Console - ից կարդալ  2 թիվ և ընտրել operation և տպել արդյունքը։

            //Console.WriteLine("Enter two number");

            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter operation");
            //char operation = char.Parse(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        Console.WriteLine( a+"+"+b+"="+(a+b));
            //        break;
            //    case '-':
            //        Console.WriteLine(a + "-" + b + "=" + (a - b));
            //        break;
            //    case '*':
            //        Console.WriteLine(a + "*" + b + "=" + (a * b));
            //        break;
            //    case '/':
            //        Console.WriteLine(a + "/" + b + "=" + (a / b));
            //        break;
            //    case '%':
            //        Console.WriteLine(a + "%" + b + "=" + (a % b));
            //        break;
            //    default:
            //        Console.WriteLine("Wrong operation");
            //        break;
            //}


            // 2. Console - ից կարդալ  3 թիվ և տպել դրանցից մեծը։
            //Հավասարի դեպքում տպել, որ դրանք բոլորը հավասար են։

            //Console.WriteLine("Enter three number");

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a>b&&a>c)
            //{
            //    Console.WriteLine("The biggest number is "+a);
            //}
            //else if(b>a&&b>c)
            //{
            //    Console.WriteLine("The biggest number is " + b);
            //}
            //else
            //{
            //    Console.WriteLine("The biggest number is " + c);
            //}


            // 3. Console - ից կարդալ 1 - 100 թիվ։ Եթե Valid է տպել համապատասխանաբար Excellent,
            //Very Good, Good, Average , Fail: Բաժանումները կատարեք ըստ ձեր ցանկության։

            //Console.WriteLine("Enter number from 1 to 100");
            //int number = int.Parse(Console.ReadLine());

            //if (number > 0 && number <= 20)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else if (number > 20 && number <= 40)
            //{
            //    Console.WriteLine("Average");
            //}
            //else if (number > 40 && number <= 60)
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (number > 60 && number <= 80)
            //{
            //    Console.WriteLine("Very good");
            //}
            //else if (number > 80 && number <= 100)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong number");
            //}


            // 4. Console - ից կարդալ եռանկյան կողմերը և տպել հավասարակող եռանկյուն է,
            //հավասարասրուն, թե՝  սովորական(scalene triangle):

            //Console.WriteLine("Enter sides of a triangle");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a + b < c || a + c < b || b + c < a)
            //{
            //    Console.WriteLine("This isn't triangle");
            //}
            //else if (a == b && a == c)
            //{
            //    Console.WriteLine("This is equilateral triangle");
            //}
            //else if (a == b && a != c || b == c && b != a || a == c && a != b)
            //{
            //    Console.WriteLine("This is equal triangle");
            //}
            //else
            //{
            //    Console.WriteLine("This is scalene triangle");
            //}



            // 5. Console - ից կարդալ եռանկյան անկյունները և տպել valid եռանկյուն է թե ոչ։

            //Console.WriteLine("Enter corners of a triangle");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //int corners = a + b + c;
            //Console.WriteLine(corners == 180 && a > 0 && b > 0 && c > 0 ? "Is valid" : "Invalid");



            // 6. Console - ից կարդալ անկյունները և եթե valid եռանկյուն է՝
            //տպել սուրանկյուն է,բութ անկյուն թե ուղղանկյուն։


            //Console.WriteLine("Enter corners of a triangle");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a + b + c == 180 && a > 0 && b > 0 && c > 0)
            //{
            //    if (a > b + c || b > a + c || c > a + b)
            //    {
            //        Console.WriteLine("Blunt angle triangle");
            //    }
            //    else if (a < b + c || b < a + c || c < a + b)
            //    {
            //        Console.WriteLine("Sharp angle triangle");
            //    }
            //    else if (a == 90 || b == 90 || c == 90)
            //    {
            //        Console.WriteLine("Right triangle");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}


            // 7. Console - ից կարդալ Տառ և եթե valid տառ է,տպել ձայնավոր է թե ոչ։

            //Console.WriteLine("Enter letter");
            //char letter = char.Parse(Console.ReadLine());

            //switch (letter)
            //{
            //    case 'A':
            //    case 'a':
            //    case 'E':
            //    case 'e':
            //    case 'I':
            //    case 'i':
            //    case 'O':
            //    case 'o':
            //    case 'U':
            //    case 'u':
            //    case 'Y':
            //    case 'y':
            //        Console.WriteLine("Vocal letter");
            //        break;
            //    default:
            //        Console.WriteLine("Consonant letter");
            //        break;
            //}


            // 8. Console - ից կարդալ ամսվա թիվը(1 - 12) կամ անունը և տպել  քանի օր կա տվյալ ամսում։

            //Console.WriteLine("Enter number of month");
            //int number = int.Parse(Console.ReadLine());

            //switch (number)
            //{
            //    case 1: Console.WriteLine("January-31 day");
            //        break;
            //    case 2:
            //        Console.WriteLine("February-28 day");
            //        break;
            //    case 3:
            //        Console.WriteLine("March-31 day");
            //        break;
            //    case 4:
            //        Console.WriteLine("April-30 day");
            //        break;
            //    case 5:
            //        Console.WriteLine("May-31 day");
            //        break;
            //    case 6:
            //        Console.WriteLine("June-30 day");
            //        break;
            //    case 7:
            //        Console.WriteLine("July-31 day");
            //        break;
            //    case 8:
            //        Console.WriteLine("August-31 day");
            //        break;
            //    case 9:
            //        Console.WriteLine("September-30 day");
            //        break;
            //    case 10:
            //        Console.WriteLine("October-31 day");
            //        break;
            //    case 11:
            //        Console.WriteLine("November-30 day");
            //        break;
            //    case 12:
            //        Console.WriteLine("December-31 day");
            //        break;

            //    default:
            //        Console.WriteLine("There isn't "+number+" month ");
            //        break;
            //}



            // 9. Console - ից կարդալ 2 հատ երկնիշ թիվ։Ստուգել դրանք հավասար են թե ոչ և շրջած հավասար են թե ոչ ։
            //Օրինակ 21 = 12:

            //Console.WriteLine("Enter two numbers from 10 to 99");
            //int first = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());


            //int first_reverse = Convert.ToInt32(Convert.ToString(first % 10) + Convert.ToString(first / 10));
            //int second_reverse = Convert.ToInt32(Convert.ToString(second % 10) + Convert.ToString(second / 10));

            //if (first == second)
            //{
            //    Console.WriteLine(first + "=" + second);
            //}
            //else if (first == second_reverse || second == first_reverse)
            //{
            //    Console.WriteLine(first + "=" + second);
            //}
            //else
            //{
            //    Console.WriteLine("Isn't equal");
            //}



            // 10. Պետք է տպել էլեկտա՝ներգիայի վճարման անդորրագիր։
            //Մուտքագրում ենք վճարողի տվյալները(Անուն, ազգանուն, հասցե, կատարած ծախսը)։ Ծրագիրը տպումա անդորրագիր։
            //	 Մինչև 100 միավորի համար 50դրամ
            //	100 - ից 200 միավորի համար 100դրամ
            //	200 - ից 400 միավորի համար 150դրամ
            //	400 - ից ավել միավորի համար 250դրամ

            //Console.WriteLine("Enter name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter surname");
            //string surname = Console.ReadLine();
            //Console.WriteLine("Enter address");
            //string address = Console.ReadLine();
            //Console.WriteLine("Enter energy cost");
            //int energy_count = int.Parse(Console.ReadLine());
            //int energy_cost = 0;
            //if (energy_count > 0 && energy_count < 100)
            //{
            //    energy_cost = 50;
            //}
            //else if (energy_count >= 100 && energy_count < 200)
            //{
            //    energy_cost = 100;
            //}
            //else if (energy_count >= 200 && energy_count < 400)
            //{
            //    energy_cost = 150;
            //}
            //else if (energy_count >= 400)
            //{
            //    energy_cost = 250;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Energy receipt\n");
            //Console.WriteLine(name + " " + surname);
            //Console.WriteLine("address: " + address);
            //Console.WriteLine(energy_count + " - " + energy_cost + " AMD");




            // 11. Պաղպաղակը սրճարանում վաճառում են 3 կամ 5 գնդիկով։
            //  Մուտքագրած պետք է ասի, կարելի է գնել մուտքագրված թվով պաղպաղակ,թե ոչ։
            //  Օրինակ՝ 3 թվի դեպքում կտպի YES, 1 թվի դեպքում NO:


            //Console.WriteLine("How many ice-cream you want?");
            //int count = int.Parse(Console.ReadLine());

            //switch(count)
            //{
            //    case 3:
            //    case 5:
            //        Console.WriteLine("YES");
            //        break;
            //    default:
            //        Console.WriteLine("NO");
            //        break;
            //}
        }
    }
}
