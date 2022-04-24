void Print(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.Clear();
int [] mass = new int [6];
int[] res = new int[mass.Length/2];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(0,10); 
}
Print(mass);

for (int i = 0; i < mass.Length/2; i++)
{
   res[i] = mass[i]* mass[mass.Length -1 -i];
}
Print(res);
