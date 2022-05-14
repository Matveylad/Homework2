// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aj,i = i+j.
// Выведите полученный массив на экран.

// int m = 4;
// int n = 3;

// int [,] mass = new int [m,n];

// void Print(int [,]array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//         array[i, j] = i+j;
//         Console.Write(array[i, j] + " ");
//          }
//     Console.WriteLine();
// }
// }
// Print(mass);

// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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

//     for (int i = 0; i < mass.GetLength(0); i=i+2)
//     {
//         for (int j = 0; j < mass.GetLength(1); j=j+2)
//         {
            
            
//                 mass[i,j] = mass[i,j] * mass[i,j];
            
//         }
//     }

//   Print(mass);


//   Задайте двумерный массив. Найдите сумму элементов, у
// которых оба индекса равны друг другу

int m = 2, n = 3, summ=0;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
      {
        mass[i, j] = new Random().Next(1, 10);

        Console.Write(mass[i, j] + " ");
      }
      Console.WriteLine();

    }
    void Print(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

     Console.WriteLine();

     int size = mass.GetLength(0); //задали условие, чтобы не проверять его в else
        if(mass.GetLength(1) < mass.GetLength(0))
         {
                size = mass.GetLength(1);
         }


    for (int i = 0; i < size; i++)
    {
 
              summ = summ + mass[i,i];
            
        
    }

    Console.WriteLine($"Сумма эллементов равных индексов = {summ}");

 

