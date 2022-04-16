int n1,n2;
int numberA = new Random().Next(10,100);
Console.WriteLine(numberA);

n1 = numberA %10;
n2 = numberA/10;
if(n1>n2) Console.WriteLine(n1);
else Console.WriteLine(n2);
