using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1. Write a program in C# Sharp to display the cube of the number up to given an integer.
            ////     Test Data : Input number of terms : 5 Expected Output :
            ////     Number is : 1 and cube of the 1 is :1
            ////     Number is : 2 and cube of the 2 is :8 
            ////     Number is : 3 and cube of the 3 is :27 
            ////     Number is : 4 and cube of the 4 is :64 
            ////     Number is : 5 and cube of the 5 is :125

            //Console.WriteLine("Enter number");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <=number ; i++)
            //{
            //    Console.WriteLine("Number is: "+i+" and cube of the "+i+"is: "+i*i*i);
            //}



            ////2.Write a program in C# Sharp to display the multiplication table of a given integer. 
            ////    Test Data : Input the number (Table to be calculated) : 15
            ////    Expected Output : 
            ////    15 X 1 = 15 
            ////    ...
            ////    ... 
            ////    15 X 10 = 150

            //Console.WriteLine("Enter number");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("The multiplication table of " + number);
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(number + " * " + i + " = " + number * i);
            //}


            ////3.Write a program in C# Sharp to display the multiplication table
            ////    vertically from 1 to n.
            ////    Test Data : Input upto the table number starting from 1 : 8 
            ////    Expected Output :
            ////    Multiplication table from 1 to 8
            ////    1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
            ////    ... 
            ////    1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80


            //Console.WriteLine("Enter number");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("the multiplication table vertically from 1 to "+number);

            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write(i+"*"+j+"="+i*j+", ");
            //    }
            //    Console.WriteLine();
            //}


            //4.Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.
            //    Provide the last rows count.

            //        * 
            //       * *
            //      * * *
            //     * * * *


            //Console.WriteLine("Input height of rectengle: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 1; j < number - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = number - 2 * i; j <= number; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(" ");
            //}


            //5.Write a program in C# Sharp to display the n terms of harmonic series and their sum.
            //    1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms 
            //    Test Data : Input the number of terms : 5
            //    Expected Output :
            //    1 / 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5 + Sum of Series up to 5 terms: 2.283334

            //Console.WriteLine("Enter number");
            //double number = double.Parse(Console.ReadLine());

            //double sum =0.0;
            //for (double i = 1; i <= number; i++)
            //{
            //    sum += 1 / i;
            //    if (i != number)
            //    {
            //        Console.Write("1/" + i + "+");
            //    }
            //    else { Console.Write("1/" + i); }
            //}
            //Console.WriteLine("="+sum);


            //6.  Write a C# Sharp program to check whether a given number is an Armstrong number or not.
            //    Test Data :
            //    Input a number: 153
            //    Expected Output : 153 is an Armstrong number.

            //Console.WriteLine("Enter number");
            //int num = int.Parse(Console.ReadLine());
            //string answer = "";
            //for (int i = 0; i <= 9; i++)
            //{
            //    for (int j = 0; j <= 9; j++)
            //    {
            //        for (int k = 0; k <= 9; k++)
            //        {
            //            if (i != j && j != k && i != k && num == i * i * i + j * j * j + k * k * k)
            //            {
            //                answer += num + " is Armstrong number";
            //                Console.WriteLine(answer);
            //                return;
            //            }

            //        }
            //    }
            //}
            //if (answer=="")
            //{
            //    Console.WriteLine(num + " isn't Armstrong number");
            //}




            //7.Write a C# Sharp program to determine whether a given number is prime or not. 
            //    Test Data : 
            //    Input a number: 13
            //    Expected Output : 13 is a prime number.

            //Console.WriteLine("Enter number");
            //int number = int.Parse(Console.ReadLine());
            //if (number == 2 || number == 3)
            //{
            //    Console.WriteLine(number + " is prime number");
            //}
            //else
            //{
            //    for (int i = 2; i <= number / 2; i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            Console.WriteLine(number + " isn't prime number");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine(number + " is prime number");
            //            break;
            //        }
            //    }
            //}



            //8.Write a program in C# Sharp to display the first n terms of Fibonacci series. 
            //    Fibonacci series 0 1 2 3 5 8 13 .....
            //    Test Data : 
            //    Input number of terms to display : 10
            //    Expected Output :
            //    Here is the Fibonacci series up to to 10 terms : 0 1 1 2 3 5 8 13 21 34

            //int number = int.Parse(Console.ReadLine());
            //int number1 = 0;
            //int number2 = 1;
            //int res = 0;
            //for (int i = 0; i < number; i++)
            //{
            //     Console.Write(res+", ");
            //    res = number1 + number2;
            //    number1 = number2;
            //    number2 = res;
            //}


            //Console.WriteLine("Enter number");
            //int number = int.Parse(Console.ReadLine());
            //int[] arr = new int[number];

            //arr[0] = 0;
            //arr[1] = 1;
            //Console.Write(arr[0] + " " + arr[1] + " ");
            //for (int i = 0; i < number; i++)
            //{
            //    arr[i + 2] = arr[i] + arr[i + 1];
            //    Console.Write(arr[i + 2] + " ");
            //}



            //9. Write a program in C# Sharp to check whether a number is a palindrome or not.
            //   Test Data :
            //   Input a number: 121 Expected
            //   Output : 121 is a palindrome number.

            //Console.WriteLine("Enter number");
            //string number = Console.ReadLine();
            //int j = number.Length - 1;
            //for (int i = 0; i < number.Length - 1; i++)
            //{
            //    if (number[i] != number[j])
            //    {
            //        Console.WriteLine(number + " isn't palindrome number");
            //        return;
            //    }
            //    else if (i == j || i + 1 == j)
            //    {
            //        Console.WriteLine(number + " is palindrome number");
            //        return;
            //    }
            //    j--;
            //}



            //10.Write a program in C# Sharp to find the number and sum of all
            //    integer between 100 and 200 which are divisible by 9.
            //    Expected Output :
            //    Numbers between 100 and 200, divisible by 9 : 108 117 126 135 144 153 162 171 180 189 198
            //    The sum : 1683


            //int number = 9;
            //int sum = 0;
            //Console.WriteLine(" Numbers between 100 and 200, divisible by 9 :");
            //for (int i = 100; i < 200; i++)
            //{
            //    if (i % number == 0)
            //    {
            //        Console.Write(i + ", ");
            //        sum += i;
            //    }
            //}

            //Console.WriteLine("The sum :" + sum);



            //11.Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...]. 
            //   Test Data : Input the number or terms :5 
            //   Expected Output : 9 99 999 9999 99999
            //   The sum of the series = 111105


            //Console.WriteLine("Input number: ");
            //int number = int.Parse(Console.ReadLine());
            //string row = "";
            //int sum = 0;

            //for (int i = 0; i < number; i++)
            //{
            //    string series = "";
            //    for (int j = 0; j <= i; j++)
            //    {
            //        series += "9";
            //    }
            //    row += series + " ";
            //    sum += Convert.ToInt32(series);
            //}
            //Console.WriteLine("The series of number 9: " + row);
            //Console.WriteLine("The sum of the series = " + sum);



            //12.Write a program in C# Sharp to display the number in reverse order.
            //   Test Data :
            //   Input a number: 12345
            //   Expected Output : 
            //   The number in reverse order is : 54321


            //Console.WriteLine("Input number: ");
            //string number = Console.ReadLine();
            //string result = "";

            //for (int i = number.Length - 1; i >= 0; i--)
            //{
            //    result += number[i];
            //}
            //Console.WriteLine("The number in reverse order is : " + result);



            //13.Write a program in C# Sharp to find LCM of any two numbers.
            //   Test Data : 
            //   Input 1st number for LCM: 15
            //   Input 2nd number for LCM: 20 
            //   Expected Output : The LCM of 15 and 20 is : 60

            //Console.Write("Input 1st number for LCM: ");
            //int number_1 = int.Parse(Console.ReadLine());
            //Console.Write("Input 2st number for LCM: ");
            //int number_2 = int.Parse(Console.ReadLine());
            //int min_number = 0;
            //int max_number = 0;
            //if (number_1 > number_2)
            //{
            //    min_number = number_2;
            //    max_number = number_1;
            //}
            //else
            //{
            //    min_number = number_1;
            //    max_number = number_2;
            //}

            //for (int i = 1; i < min_number; i++)
            //{
            //    int LCM;
            //    if (max_number * i % min_number == 0)
            //    {
            //        LCM = max_number * i;
            //        Console.WriteLine("The LCM of " + number_1 + " and " + number_2 + " is: " + LCM);
            //        return;
            //    }
            //}



            //14.Write a program in C# Sharp to display the pattern like a diamond. 

            //       *
            //      ***
            //     *****
            //    *******
            //   *********
            //    *******
            //     *****
            //      ***
            //       *


            //Console.WriteLine("Input height of diamond: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number / 2; i++)
            //{
            //    for (int j = 1; j <= number - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = number - 2 * i; j <= number; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(" ");
            //}
            //for (int i = number / 2; i >= 0; i--)
            //{
            //    for (int j = 1; j <= number - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = number - 2 * i; j <= number; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine(" ");
            //}




        }

    }
}

