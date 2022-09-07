//Задача 22: Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.Clear();

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
int count = 1;

Console.Write($"{x} -> "); 

while (count < x)
{
    Console.Write($"{Math.Pow((count), 2)}, ");
    count++;
}

if (count == x)
{
    Console.Write($"{Math.Pow((count), 2)}");
}

// OR

//Console.WriteLine("Введите N:");

// bool res = int.TryParse(Console.ReadLine(), out int n);

///if (!res || n <= 0)
// {
//     Console.WriteLine("Ошибка ввода");
//     return;
// }
// Console.Write($"{n} -> ");
// int tmp = 1;
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"{tmp*tmp} ");
//     tmp++;
// }

// OR

//Console.WriteLine("Введите число");
// int N = int.Parse(Console.ReadLine());
// int i = 1;
// while (i <= N)
// {
//     Console.WriteLine($"{i} -> {Math.Pow(i, 2)}");
//     i++;
// }

// OR

//Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     if (i != N) Console.Write($"{i*i}, ");
//     else Console.Write($"{i*i}");
// }
