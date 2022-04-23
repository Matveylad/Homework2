Console.WriteLine("Веедите число N ");
int N = int.Parse(Console.ReadLine()); 
int pN = 1;
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i);
    pN = pN *i;
}
Console.WriteLine(pN);
  