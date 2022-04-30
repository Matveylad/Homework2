Console.WriteLine("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
int res = 0;

Console.Write($"{a} {b}");

for (int i = 2; i < N; i++)
{
    res= a+b;

    Console.Write(res+ " ");
    a=b;
    b=res;
}
Console.WriteLine();
