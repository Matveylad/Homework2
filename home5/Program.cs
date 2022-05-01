// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, 
// которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
// int[] mas = new int[15];
// void Massive(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// for (int i = 0; i < mas.Length; i++)
// {
//     mas[i] = new Random().Next(99, 1000);
// }

// Massive(mas);

// int count=0;

// for(int i=0; i< mas.Length; i++)
// {
//     if(mas[i] %2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine();

// Console.WriteLine($"В массиве {count} четных элементов");

// Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

// int[] mas = new int[5];

// void Massive(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// for (int i = 0; i < mas.Length; i++)
// {
//     mas[i] = new Random().Next(1, 100);
// }

// Massive(mas);

// int sum=0;

// for(int i=0; i< mas.Length; i++)
// {
//     if(mas[i]%2 -1 == 0)
//     {
//         sum=sum+mas[i];
//     }
// }
// Console.WriteLine();

// Console.WriteLine($"Сумма не четных эллементов массива равна: {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.
//[3 7 22 2 78] -> 76


int[] mass = new int[10];
Console.Clear();
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(1, 100);
}
void FindMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinV = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinV])
            {
                MinV = j;
            }
        }
        int gap = array[i];
        array[i] = array[MinV];
        array[MinV] = gap;
    }
}
PrintArray(mass);
FindMin(mass);
PrintArray(mass);
int diff = mass[mass.Length-1] - mass[0];
Console.WriteLine($"Разница между максимальным  и минимальным элементами массива равна: {diff}");