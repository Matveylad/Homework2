int[]mass = new int[8];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random ().Next(0,2);
    Console.Write(mass[i]);
}