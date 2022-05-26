// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26 
// int a = 2, b = 9, N = 10;
// int Fib(int f, int s, int num)
// {
//     if (num == 0)
//         return f;
//     if (num == 1)
//         return s;
//     return Fib(f, s, num - 1) + Fib(f, s, num - 2);
// }
// for (int i = 0; i < N; i++)
// {
//     int m = Fib(a, b, i);
//     Console.Write(m + " ");
// }

// Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
// и «в». Покажите все слова, состоящие из n букв, которые можно построить из
// букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
// ав, ва, ви, ив, св, вс



// int n =1;

// void FindWords(string alphabet, char[] word, int length = 0)
// {
//  if (length == word.Length)
//  {
//  Console.WriteLine($"{n++} {new String(word)}"); return;
//  }
//  for (int i = 0; i < alphabet.Length; i++)
//  {
//  word[length] = alphabet[i];
//  FindWords(alphabet, word, length + 1);
//  }
// }
// FindWords("аисв", new char[2]);


// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве data хранится
// информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел
// массива data с учётом информации из массива info.
// 25 мин
// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// - info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1

int[] array1 = { 0, 1, 1, 1, 1, 0, 0, 0, 1 }; // data
int[] array2 = { 2, 3, 3, 1 }; // info

int Transfer(int[] data, int[] info)
{
    int count = 0;
    int[] result = new int[info.Length];
    for (int i = 0; i < info.Length; i++)
    {

        for (int j = count; j < count + info[i]; j++)
        {
            result[i] += data[j] * (int)Math.Pow(2, info[i] + count - j - 1);


        }
        count += info[i];
        Console.Write(result[i] + " ");

    }
    return result[0];

}
Transfer(array1, array2);