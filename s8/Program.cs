// Задача 53 задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива

// int m = 3;
// int n = 4;
// int[,] massiv = new int[m, n];
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
//     for (int j = 0; j < massiv.GetLength(1); j++)
//     {
//         massiv[i, j] = new Random().Next(1, 10);
//     }
// }
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
//     for (int j = 0; j < massiv.GetLength(1); j++)
//     {
//         Console.Write(massiv[i, j] + " "); 
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// int temp = 0;
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
//     temp = massiv[0, i];
//     massiv[0, i] = massiv[massiv.GetLength(0) - 1, i];
//     massiv[massiv.GetLength(0) - 1, i] = temp;
// }
// Console.WriteLine();
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
//     for (int j = 0; j < massiv.GetLength(1); j++)
//     {
//         Console.Write(massiv[i, j] + " "); ;
//     }
//     Console.WriteLine();
// }

//задача 55
// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

// int m = 4;
// int n = 4;

// int[,] mass = new int[m, n];
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//            for (int j = 0; j < mass.GetLength(1); j++)
//       {
//         mass[i, j] = new Random().Next(1, 10);

//       }


//     }
//     void Print(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
//     Print(mass);
//     Console.WriteLine();
//     int temp;
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = i; j <mass.GetLength(1); j++)
//         {
//              temp=mass[i,j];
//         mass[i,j]=mass[j,i];
//         mass[j,i]=temp;
//         }


//     }
//     Print(mass);

// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// int m = 4;
// int n = 4;

// int[,] mass = new int[m, n];
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//            for (int j = 0; j < mass.GetLength(1); j++)
//       {
//         mass[i, j] = new Random().Next(1, 10);

//       }
      
      
//     }
//     void Print(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
//     Print(mass);
//     Console.WriteLine();

// Console.WriteLine("Введите искомое число а: ");
// int a = int.Parse(Console.ReadLine());
// int count=0;
// for (int i = 0; i < mass.GetLength(0); i++)
// {
//     for (int j = 0; j < mass.GetLength(1); j++)
//     {
//         if(mass[i,j]==a)
//         count++;
        
//     }
// }
// if(count==0)
// {
//     Console.WriteLine("искомого числа нет");

// }
// else
// {
//     Console.WriteLine($"искомое число в массиве встречается {count} раз");
// }
// int[,] matrix = new int[m, n];

// FillArray(matrix);
// PrintArray(matrix);
// int min=matrix[0,0];
// int mini=0;
// int minj=0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (matrix[i,j]<min)
//         {
//             min=matrix[i,j];
//             mini=i;
//             minj=j;
//         }
//     }
// }
// int[,] newmatrix=new int [m-1,n-1];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (i!=mini & j!=minj)
//         {
//             int a=i, b=j;
//             if (i>mini) a--;
//             if (j>minj) b--;
//             newmatrix[a,b]=matrix[i,j];            
//         }
//     }
// }
// Console.WriteLine();
// PrintArray(newmatrix);
