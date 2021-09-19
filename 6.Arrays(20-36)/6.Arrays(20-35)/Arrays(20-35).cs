using System;

namespace _6.Arrays_20_35_
{
    class Program
    {
        static void Main(string[] args)
        {

            //20. Write a program in C# Sharp for subtraction of two Matrices.  


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

            //    Console.WriteLine("\nThe Subtraction of two matrix is : ");

            //    for (int i = 0; i < array2.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array2.GetLength(1); j++)
            //        {
            //            Console.Write(array1[i, j] - array2[i, j] + " ");

            //        }
            //        Console.WriteLine();
            //    }
            //}




            //21. Write a program in C# Sharp for multiplication of two square Matrices.  


            //int[,] array1 = new int[2, 2];
            //int[,] array2 = new int[2, 2];
            //Console.WriteLine("\nInput elements in the first matrix : ");
            //for (int i = 0; i < array1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nInput elements in the second matrix : ");
            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        array2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nThe First matrix is: ");
            //for (int i = 0; i < array1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        Console.Write(array1[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("\nThe Second matrix is: ");

            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        Console.Write(array2[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("The multiplication of two matrix is : ");

            //Console.Write(array1[0, 0] * array2[0, 0] + array1[0, 1] * array2[1, 0] + " ");
            //Console.WriteLine(array1[0, 0] * array2[0, 1] + array1[0, 1] * array2[1, 0]);
            //Console.Write(array1[1, 0] * array2[0, 0] + array1[1, 1] * array2[1, 0] + " ");
            //Console.WriteLine(array1[1, 0] * array2[0, 1] + array1[1, 1] * array2[1, 1]);



            //22. Write a program in C# Sharp to find transpose of a given matrix.  

            //Console.Write("Input the rows of the matrix : ");
            //int row = int.Parse(Console.ReadLine());
            //Console.Write("Input the columns of the matrix : ");
            //int col = int.Parse(Console.ReadLine());

            //int[,] arr = new int[row, col];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nThe matrix is: ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("\nThe Transpose of a matrix is : ");
            //for (int i = 0; i < arr.GetLength(1); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        Console.Write(arr[j, i] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //23. Write a program in C# Sharp to find sum of right diagonals of a matrix. 

            //Console.Write("Input the size of the square matrix : ");
            //int size = int.Parse(Console.ReadLine());

            //int[,] arr= new int[size, size];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nThe matrix is: ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("\nAddition of the right Diagonal elements is : ");
            //int diagonal = 0;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (j==size-i-1)
            //        {
            //            diagonal += arr[i, j];
            //        }
            //    }

            //}
            //Console.Write(diagonal);
            //Console.WriteLine();



            //24. Write a program in C# Sharp to find the sum of left diagonals of a matrix. 

            //Console.Write("Input the size of the square matrix : ");
            //int size = int.Parse(Console.ReadLine());

            //int[,] arr = new int[size, size];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nThe matrix is: ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("\nAddition of the left Diagonal elements is : ");
            //int diagonal = 0;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            diagonal += arr[i, j];
            //        }
            //    }

            //}
            //Console.Write(diagonal);
            //Console.WriteLine();



            //25. Write a program in C# Sharp to find sum of rows an columns of a Matrix.


            //Console.Write("Input the size of the square matrix : ");
            //int size = int.Parse(Console.ReadLine());

            //int[,] arr = new int[size, size];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nThe matrix is: ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("The sum or rows and columns of the matrix is : ");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    int sum_rows = 0;
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        sum_rows += arr[i, j];


            //    }
            //    Console.WriteLine(i + " row sum:" + sum_rows);
            //}

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    int sum_col = 0;
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        sum_col += arr[j, i];
            //    }

            //    Console.WriteLine(i + " col sum:" + sum_col);

            //}




            //26. Write a program in C# Sharp to print or display the lower triangular of a given matrix.  


            //Console.Write("Input the size of the square matrix : ");
            //int size = int.Parse(Console.ReadLine());

            //int[,] arr = new int[size, size];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nThe matrix is: ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Setting zero in lower triangular matrix ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (i > j)
            //        {
            //            arr[i, j] = 0;
            //        }

            //    }

            //}


            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}



            //27. Write a program in C# Sharp to print or display the upper triangular of a given matrix.  

            //Console.Write("Input the size of the square matrix : ");
            //int size = int.Parse(Console.ReadLine());

            //int[,] arr = new int[size, size];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nThe matrix is: ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Setting zero in upper triangular matrix ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (i < j)
            //        {
            //            arr[i, j] = 0;
            //        }

            //    }

            //}


            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //28.Write a program in C# Sharp to calculate determinant of a 3 x 3 matrix.  


            //int[,] arr = new int[3, 3];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nThe matrix is: ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //Console.Write("\nThe Determinant of the matrix is: ");

            //int determinant = arr[0, 0] * (arr[1, 1] * arr[2, 2] - arr[1, 2] * arr[2, 1]) -
            //     arr[0, 1] * (arr[1, 0] * arr[2, 2] - arr[1, 2] * arr[2, 0]) +
            //     arr[0, 2] * (arr[1, 0] * arr[2, 1] - arr[1, 1] * arr[2, 0]);

            //Console.Write(determinant);

            //29. Write a program in C# Sharp to accept a matrix and determine whether it is a sparse matrix.  


            //Console.Write("Input the rows of the matrix : ");
            //int row = int.Parse(Console.ReadLine());
            //Console.Write("Input the columns of the matrix : ");
            //int col = int.Parse(Console.ReadLine());

            //int[,] arr = new int[row, col];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nThe matrix is: ");
            //int count_zero = 0;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (arr[i, j] == 0)
            //        {
            //            count_zero++;
            //        }
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //if (count_zero > arr.Length / 2)
            //{
            //    Console.WriteLine("The given matrix is sparse matrix. ");
            //    Console.WriteLine("There are " + count_zero + " number of zeros in the matrix");
            //}
            //else
            //{
            //    Console.WriteLine("The given matrix isn't sparse matrix. ");
            //    Console.WriteLine("There are " + count_zero + "  of zeros in the matrix");
            //}



            // 30.Write a program in C# Sharp to accept two matrices and check whether they are equal. 



            //Console.Write("Input the rows of the first matrix : ");
            //int row1 = int.Parse(Console.ReadLine());
            //Console.Write("Input the columns of the first matrix : ");
            //int col1 = int.Parse(Console.ReadLine());


            //Console.Write("Input the rows of the second matrix : ");
            //int row2 = int.Parse(Console.ReadLine());
            //Console.Write("Input the columns of the second matrix : ");
            //int col2 = int.Parse(Console.ReadLine());


            //int[,] arr = new int[row1, col1];
            //int[,] arr2 = new int[row1, col1];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //Console.WriteLine("\nThe first matrix is: ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}


            //Console.WriteLine("\nThe second matrix is: ");

            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //if (row1 == row2 && col1 == col2)
            //{
            //    Console.WriteLine("The Matrices can be compared ");
            //}
            //else
            //    Console.WriteLine("The Matrices can't be compared ");



            //int count = 0;
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        if (arr[i, j] == arr2[i, j])
            //        {
            //            count++;
            //        }

            //    }

            //}
            //if (count == arr2.Length)
            //{
            //    Console.WriteLine("Two matrices are equal. ");
            //}
            //else
            //    Console.WriteLine("Two matrices aren't equal. ");




            //31. Write a program in C# Sharp to check whether a given matrix is an Identity Matrix.  


            //Console.Write("Input the size of the square matrix : ");
            //int size = int.Parse(Console.ReadLine());

            //int[,] arr = new int[size, size];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nThe matrix is: ");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //int count_one = 0;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if ((i == j && arr[i, j] == 1))
            //        {
            //            count_one++;
            //        }

            //    }

            //}
            //int count_zero = 0;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if ((i > j || i < j && arr[i, j] == 0))
            //        {
            //            count_zero++;
            //        }

            //    }

            //}

            //if (count_one == arr.GetLength(0) && count_zero == arr.Length - arr.GetLength(0))
            //{
            //    Console.WriteLine("The matrix is an Identity Matrix. ");
            //}
            //else
            //{
            //    Console.WriteLine("The matrix isn't an Identity Matrix. ");
            //}


            //32. Write a C# Sharp program to get only the odd values from a given array of integers.  



            //Console.Write("Input the rows of the matrix : ");
            //int row = int.Parse(Console.ReadLine());
            //Console.Write("Input the columns of the matrix : ");
            //int col = int.Parse(Console.ReadLine());

            //int[,] arr = new int[row, col];
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        Console.Write("Element [" + i + "]" + "[" + j + "]: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());

            //    }
            //}

            //Console.WriteLine("Only the odd values of the said array: ");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {

            //        if (arr[i, j] % 2 == 1)
            //        {
            //            Console.Write(arr[i, j] + " ");
            //        }

            //    }
            //}




            //33. Write a C# Sharp program to remove all duplicate elements from a given
            //array and returns a new array.


            //string[] array = new string[6];
            //Console.WriteLine("Please input original array elements: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = Console.ReadLine();
            //}


            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (i != j && array[i] == array[j])
            //        {
            //            array[j] = "";
            //        }
            //    }
            //}


            //Console.WriteLine("\nAfter removing duplicate elements from the said array:");

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] != "")
            //    {
            //        Console.WriteLine(array[i]);
            //    }

            //}




            //34.Write a C# Sharp program to find the missing number 
            // in a given array of numbers between 10 and 20.

            //int[] array = new int[11];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = 10 + i;
            //}
            //Console.WriteLine("Original array elements: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}


            //Console.WriteLine("Enter element(0 for finish)");
            //int[] array1 = new int[11];
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = int.Parse(Console.ReadLine());
            //    if (array1[i] == 0)
            //    {
            //        break;
            //    }

            //}


            //for (int i = 0; i < array.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < array1.Length; j++)
            //    {
            //        if (array[i] == array1[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 0)
            //    {
            //        Console.WriteLine("Missing number: " + array[i]);
            //    }
            //}





            //35.Write a C# Sharp program to calculate the sum of two lowest
            //negative numbers of a given array of integers.  



            //int[] array = new int[10];
            //Console.WriteLine("Enter integers (negative too):");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Original array elements: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}


            //Array.Sort(array);
            //Console.WriteLine("\nSum of two lowest negative numbers of" +
            //    " the said array of integers: " + (array[0] + array[1]));



            //36. Write a C# Sharp program to re-arrange the elements
            //in a given array of numbers and check the numbers are consecutive or not.  


            //int[] array = new int[10];
            //Console.WriteLine("Enter integers (negative too):");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Original array elements: ");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //int count = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (i + 1 < array.Length && array[i] == array[i + 1] - 1)
            //    {
            //        count++;
            //    }
            //}
            //if (count == array.Length - 1)
            //{
            //    Console.WriteLine("\nThe numbers of the said array are consecutive");
            //}
            //else
            //{
            //    Console.WriteLine("\nThe numbers of the said array are NOT consecutive");
            //}


        }
    }
}
