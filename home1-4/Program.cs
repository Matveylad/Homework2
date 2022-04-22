// dz1
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//int a = 14212;
//int b = (a / 1000) % 10;
//int c = (a % 100) / 10;
//if (a / 10000 == a % 10 & b == c)
//{
//   Console.Write("ДА");
//}
//else
//{
//   Console.Write("НЕТ");
//}

// dz2
//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

//Console.WriteLine("Введите координаты 1й точки");

//Console.Write("X1: ");

//int x1 = int.Parse(Console.ReadLine());

//Console.Write("Y1: ");

//int y1 = int.Parse(Console.ReadLine());

//Console.Write("Z1: ");

//int z1 = int.Parse(Console.ReadLine());

//Console.Write("X2: ");

//int x2 = int.Parse(Console.ReadLine());

//Console.Write("Y2: ");

//int y2 = int.Parse(Console.ReadLine());

//Console.Write("Z2: ");

//int z2 = int.Parse(Console.ReadLine());

//double lenght = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

//Console.WriteLine($"Расстояние между точками равно {lenght}");

// dz3
//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

int n = 12;
int i = 1;
while (i <= n)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
    i++;
}
Console.Write($"{Math.Pow(i, 3)}.");