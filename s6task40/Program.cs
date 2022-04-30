Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число : ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число : ");
int c = Convert.ToInt32(Console.ReadLine());

if (a<b+c & b< a+c & c< a+b)
{
    Console.WriteLine($"треугольник со сторонами{a},{b} и {c} существует");
}

else
{
    Console.WriteLine("Треуголник не существуте");

}