Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int index=1;
while (index<=N)
{
    if(index==N)
    {
        Console.Write($"{Math.Pow(index,2)}.");
    }
    else  
        Console.Write($"{Math.Pow(index,2)},");
    index++;
}




