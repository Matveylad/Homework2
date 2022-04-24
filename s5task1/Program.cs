int [] mass = new int [12];

void Print(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}

Print(mass);

for (int i = 0; i < mass.Length; i++ )
{
    mass[i]= new Random(). Next(-9, 10);
    Console.WriteLine(mass[i]);
}
Console.WriteLine();

Print(mass);

int summPos = 0;
int summNeg = 0;

for (int i = 0; i < mass.Length; i++)

{
   if (mass[i] >0) 
   {
       summPos +=mass[i];
   }
   else
   {
       summNeg += mass[i];
   }
}

Console.WriteLine($"Сумма положительных{summPos} и отрицательных {summNeg}");