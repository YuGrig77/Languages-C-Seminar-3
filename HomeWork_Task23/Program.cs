// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Mark1:
Console.WriteLine("Pls enter number: ");
bool result = int.TryParse(Console.ReadLine(), out int n);

if (!result || n <= 0)
{
     Console.WriteLine("Wrong entry! Pls recheck.");
     goto Mark1;
}

 Console.Write($"{n} -> ");

 int tmp = 1;
 for (int i = 0; i < n; i++)
 {
     if (tmp < n)
     Console.Write($"{Math.Pow(tmp, 3)}, ");
     tmp++;
     if (tmp == n) Console.Write($"{Math.Pow(tmp, 3)}");
 }
 
 
