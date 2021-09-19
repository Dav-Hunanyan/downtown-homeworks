using System;
using System.Linq;
using System.Collections;
namespace _6.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program in C# Sharp to store elements in an array and print it.  

            //int[] array = new int[10];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("All elements in array: ");
            //for (int i = 0; i < array.Length; i++)
            //{

            //    Console.Write(array[i] + " ");
            //}


            //2.Write a program in C# Sharp to read n number of values
            //  in an array and display it in reverse order. 

            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("The values store into the array are: : ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //Console.Write("\nThe values store into the array in reverse are : ");

            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}



            // 3.Write a program in C# Sharp to find the sum of all elements of the array.  


            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];
            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //    sum += array[i];
            //}
            //Console.WriteLine("Sum of all elements stored in the array is : "+sum);


            //4.Write a program in C# Sharp to copy the elements one array into another array. 

            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}
            //Console.Write("\nThe elements stored in the first array are : ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.Write("\nThe elements copied into the second array are : ");
            //int[] array2 = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    array2[i] = array[i];
            //    Console.Write(array2[i] + " ");
            //}



            // 5.Write a program in C# Sharp to count a total number of duplicate elements in an array.


            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];
            //int count = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (array[i] == array[j] && i != j)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("Total number of duplicate elements found in the array is : " + count / 2);



            //6. Write a program in C# Sharp to print all unique elements in an array.  

            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}
            //Console.Write("\nThe unique elements found in the array are : ");
            //for (int i = 0; i < n; i++)
            //{
            //    int unique = array[i];
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (unique == array[j] && i != j)
            //        {
            //            break;
            //        }
            //        if (j == n - 1)
            //        {
            //            Console.Write(unique + " ");
            //        }
            //    }

            //}


            //7. Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.  

            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //Console.WriteLine("Enter first array elementes: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //int[] array2 = new int[n];
            //Console.WriteLine("Enter second array elementes: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array2[i] = int.Parse(Console.ReadLine());

            //}
            //int[] arr = new int[2*n];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = array[i];                
            //}
            //for (int i = 0; i < 2*n; i++)
            //{
            //    if (i + n==2*n)
            //    {
            //        break;
            //    }
            //    arr[i + n] = array2[i];

            //}
            //Array.Sort(arr);
            //for (int i = 0; i <2*n; i++)
            //{
            //    Console.Write(arr[i]+" ");
            //}


            //8. Write a program in C# Sharp to count the frequency of each element of an array.  



            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //Console.WriteLine("\nFrequency of all elements of array : ");

            //for (int i = 0; i < array.Length; i++)
            //{
            //    int count = 1;
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j] && i != j)
            //        {
            //            count++;
            //        }

            //    }
            //    Console.WriteLine(array[i] + " occurs " + count + " times");

            //}


            //9.Write a program in C# Sharp to find maximum and minimum element in an array. 



            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //            int minimum = array[0];
            //int maximum = array[0];

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i]<minimum)
            //    {
            //        minimum = array[i];
            //    }
            //    if (array[i]>maximum)
            //    {
            //        maximum = array[i];
            //    }
            //}
            //Console.WriteLine("Manimum element: "+minimum);
            //Console.WriteLine("Maximum element: "+maximum);




            // 10.Write a program in C# Sharp to separate odd and even integers in separate arrays. 

            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //int count_odd = 0;
            //int count_even = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 0)
            //    {
            //        count_even++;
            //    }
            //    else
            //    {
            //        count_odd++;
            //    }
            //}

            //int[] odd = new int[count_odd];
            //int[] even = new int[count_even];
            //int j = 0;
            //int k = 0;
            //for (int i = 0; i < array.Length; i++)
            //{

            //    if (array[i] % 2 == 0)
            //    {
            //        even[j] = array[i];
            //        j++;
            //    }

            //    else
            //    {
            //        odd[k] = array[i];
            //        k++;
            //    }
            //}

            //Console.Write("\nOdd numbers: ");
            //for (int i = 0; i < count_odd; i++)
            //{
            //    Console.Write(odd[i]+" ");
            //}
            //Console.Write("\nEven numbers : ");
            //for (int i = 0; i < count_even; i++)
            //{
            //    Console.Write(even[i]+" ");
            //}




            //11. Write a program in C# Sharp to sort elements of array in ascending order.


            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //for (int j = 0; j < array.Length; j++)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (i + 1 < array.Length)
            //        {
            //            if (array[i] > array[i + 1])
            //            {
            //                int temp = array[i];
            //                array[i] = array[i + 1];
            //                array[i + 1] = temp;
            //            }
            //        }

            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(array[i] + " ");

            //}



            //  12.Write a program in C# Sharp to sort elements of the array in descending order.


            //// Tarberak 1(sorted)
            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //Array.Sort(array);

            //Array.Reverse(array);
            //Console.Write("\nElements of the array in sorted descending order: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //Console.WriteLine();


            ////Tarberak2

            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}
            //for (int j = 0; j < array.Length; j++)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (i + 1 < array.Length)
            //        {
            //            if (array[i] < array[i + 1])
            //            {
            //                int temp = array[i];
            //                array[i] = array[i + 1];
            //                array[i + 1] = temp;
            //            }
            //        }

            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(array[i] + " ");

            //}


            //13.Write a program in C# Sharp to insert New value in the array (sorted list ).  

            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //Console.Write("Input the value to be inserted :  ");
            //int x = int.Parse(Console.ReadLine());

            //int[] arr = new int[n + 1];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = array[i];
            //}
            //arr[n ] = x;
            //Array.Sort(arr);
            //Console.WriteLine("\nThe exist array list is :");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i]+" ");
            //}
            //Console.WriteLine("\nAfter Insert the list is : ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]+" ");
            //}


            //14.Write a program in C# Sharp to insert New value in the array (unsorted list ).  


            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //Console.Write("\nInput the value to be inserted :  ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("\nInput the Position, where the value to be inserted :");
            //int position = int.Parse(Console.ReadLine());

            //int[] arr = new int[n + 1];

            //for (int i = 0; i < n + 1; i++)
            //{
            //    if (i < n + 1)
            //    {
            //        if (i + 1 < position)
            //        {
            //            arr[i] = array[i];
            //        }
            //        else if (i + 1 == position)
            //        {
            //            arr[i] = x;
            //        }
            //        else if (i + 1 > position)
            //        {
            //            arr[i] = array[i - 1];
            //        }
            //    }

            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}



            //15. Write a program in C# Sharp to delete an element at desired position from an array.  


            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}


            //Console.Write("\nInput the position where to delete :");
            //int position = int.Parse(Console.ReadLine());
            //int[] arr = new int[n - 1];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i + 1 < position)
            //    {
            //        arr[i] = array[i];
            //    }
            //    if (i + 1 >= position)
            //    {
            //        arr[i] = array[i + 1];

            //    }


            //}
            //Console.WriteLine("The new list is: ");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}


            //16. Write a program in C# Sharp to find the second largest element in an array.  


            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //Console.Write("\nThe Second largest element in the array is: ");
            //int max = array[0];
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i]>max)
            //    {
            //        max = array[i];
            //    }
            //}

            //int second_max =0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i]>second_max&&array[i]<max)
            //    {
            //        second_max = array[i];
            //    }
            //}
            //Console.Write(second_max);



            //17. Write a program in C# Sharp to find the second smallest element in an array.  

            //Console.Write("Enter array size: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Input " + i + " element: ");
            //    array[i] = int.Parse(Console.ReadLine());

            //}

            //Console.Write("\nThe Second smallest element in the array is: ");
            //int min = array[0];
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] < min)
            //    {
            //        min = array[i];
            //    }
            //}
            //int second_min;
            //if (array[0] != min)
            //{
            //    second_min = array[0];
            //}
            //else
            //{
            //    second_min = array[1];
            //}


            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > min && array[i] < second_min)
            //    {
            //        second_min = array[i];
            //    }
            //}
            //Console.Write(second_min);



            //18.Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.  

            //int[,] array = new int[3, 3];

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        array[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //19.Write a program in C# Sharp for addition of two Matrices of same size. 


            //Console.Write("Input the size of the square matrix(less than 5):");
            //int n = int.Parse(Console.ReadLine());
            //if (n >= 5)
            //{
            //    Console.WriteLine("Wrong size !!!!!!!!!!!");
            //}
            //else
            //{
            //    int[,] array1 = new int[n, n];
            //    int[,] array2 = new int[n, n];
            //    Console.WriteLine("\nInput elements in the first matrix : ");
            //    for (int i = 0; i < array1.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array1.GetLength(1); j++)
            //        {

            //            Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //            array1[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }

            //    Console.WriteLine("\nInput elements in the second matrix : ");
            //    for (int i = 0; i < array2.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array2.GetLength(1); j++)
            //        {

            //            Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //            array2[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }

            //    Console.WriteLine("\nThe First matrix is: ");
            //    for (int i = 0; i < array1.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array1.GetLength(1); j++)
            //        {
            //            Console.Write(array1[i, j] + " ");

            //        }
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("\nThe Second matrix is: ");

            //    for (int i = 0; i < array2.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array2.GetLength(1); j++)
            //        {
            //            Console.Write(array2[i, j] + " ");

            //        }
            //        Console.WriteLine();
            //    }
            //}






        }

    }
}
