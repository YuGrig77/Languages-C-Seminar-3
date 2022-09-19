// 17. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

Console.WriteLine("Введите номер четверти");
int num = int.Parse(Console.ReadLine());

if (num > 4 || num < 1)
{
    Console.WriteLine("От одного до четырёх, пожалуйста.");
    return;
}
if (num == 1)
{
    Console.WriteLine($"X = (0;оо) Y = (0;оо).");
}
if (num == 2)
{
    Console.WriteLine($"X = (-оо;0) Y = (0;оо).");
}
if (num == 3)
{
    Console.WriteLine($"X = (-оо;0) Y = (-оо;0).");
}
if (num == 4)
{
    Console.WriteLine($"X = (0;оо) Y = (-оо;0).");
}

