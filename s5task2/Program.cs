
void Print(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] mass = new int [5];
Print(mass);
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9,11); 
}
Print(mass);
for (int i = 0; i < mass.Length; i++)
{
    (mass[i]=-mass[i]);
}
Print(mass);