// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

// int n = new Random().Next(1,30);
// Console.WriteLine(n);

// void PrintNumber (int n, int m)
// {
// if(m == n+1)
// {
//     return;
// }
// Console.Write(m + " ");
// PrintNumber(n,m+1);
// }
// PrintNumber(n, 1);


// Задача 65: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.

// Console.Clear();
// int n = new Random().Next(0,30);
// Console.WriteLine(n);
// int m = new Random().Next(0,30);
// Console.WriteLine(m);


// void PrintNumber(int n, int m)
// {
//     if (m > n)
//     {
//         return;
//     }
//     Console.Write(m + " ");
//     PrintNumber(n, m + 1);
// }
// PrintNumber(n, m);

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

// Console.Clear();
// Console.WriteLine("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int PrintNumber(int n, int m)
// {
//     int sum = 0;
//     if (m == n)
//     {
//         return;
//     }
//     Console.Write(m + " ");
//     PrintNumber(n, m + 1);
// }
// PrintNumber(n, 1);
// int rec (int num)
// {
//     if (num == 0)
//     {
//         return 0;
//     }
    
//     int sum = rec(num/10);
//     Console.WriteLine(num %10 + " ");
//     return sum + num %10;
// }
// int sum = rec(124);
// Console.WriteLine(sum);

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.

 Console.Clear();
 int a = new Random().Next(1,10);
 Console.WriteLine(a);
 int b = new Random().Next(1,10);
 Console.WriteLine(b);

int degree (int a, int b)
{
 int count = a;
 if ( b<1 ) return 1;
return a * degree(a, b - 1);
}
Console.WriteLine(degree(a,b));

