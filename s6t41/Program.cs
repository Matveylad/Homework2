//  Console.WriteLine("Введите число : ");
// int x = Convert.ToInt32(Console.ReadLine());
// while (x>0)
// int s = 0;
// {
// s += (x % 2).ToString();
// x= (x /2) ;
// }

// for ( i=s.Length-1 ; i >=0; i- )
// {
// Console.Write(s[i]);
// }
// Console.ReadLine();
Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
 int x = 0;
 int[] Array = new int[6];
 string res = String.Empty;

 while (num>0)
 {
     x=num%2;
     num = num/2;
     res= x + res;
     
 }
Console.WriteLine(res);