// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// int m = 3, n = 3;

// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//     }
// }

// void Print(int[,] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             Console.Write(mass[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Print(array);
// Console.WriteLine();
// int temp;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1) - 1; j++)
//     {
//         for (int k = j + 1; k < array.GetLength(1); k++)
//         {
//             if (array[i, j] < array[i, k])
//             {
//                 temp = array[i, k];
//                 array[i, k] = array[i, j];
//                 array[i, j] = temp;
//             }
//         }
//     }
// }


// Print(array);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
// int m = 3, n = 4;
// int m = 3, n = 4;

// int[,] array = new int[m, n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//     }
// }
// Console.WriteLine("Первоначальный массив");

// void Print(int[,] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             Console.Write(mass[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Print(array);
// Console.WriteLine();

// int[] summ = new int[array.GetLength(1)];

// for (int a = 0; a < array.GetLength(0); a++)
// {
//     for (int b = 0; b < array.GetLength(1); b++)
//     {
//         summ[a] = summ[a] + array[a, b];
//     }
//     Console.WriteLine($"Сумма {a + 1} cтроки равна: {summ[a]}");
// }
// int temp;
// for (int i = 0; i < summ.Length; i++)
// {
//     for (int j = 0; j < summ.Length-1; j++)
//     {
//         if(summ[j]>summ[j+1])
//         {
//             temp=summ[j+1];
//             summ[j+1]=summ[j];
//             summ[j]=temp;
//         }
//     }
// }
// Console.Write($"Минимальная сумма строки равна: {summ[1]}");



// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
int m = 3, n = 3, k = 3;

int[,,] array = new int[m, n, k];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int l = 0; l < array.GetLength(2); l++)
        {
            array[i, j, l] = new Random().Next(1, 10);
        }

    }
}

void Print(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.WriteLine($"{mass[i, j, l]} - m:{i}, n:{j}, k:{l}");
            }

        }
        Console.WriteLine();
    }
}
Print(array);
