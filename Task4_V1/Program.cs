//Задача 22: Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

Console.WriteLine("Введите N:");

bool res = int.TryParse(Console.ReadLine(), out int n);

if (!res || n <= 0)
{
    Console.WriteLine("Ошибка ввода");
    return;
}
Console.Write($"{n} -> ");
int tmp = 1;
for (int i = 0; i < n; i++)
{
    Console.Write($"{tmp * tmp} ");
    tmp++;
}
