// 17. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

Console.WriteLine("Введите номер четверти");
int a = int.Parse(Console.ReadLine());
if (a > 4)
{
    Console.WriteLine("вы за диапозоном");
}
else
{
    if (a == 1)
    {
        Console.WriteLine("от 0 до y, от 0 до x");
    }
    if (a == 2)
    {
        Console.WriteLine("от 0 до y, от -x до 0");
    }
    if (a == 3)
    {
        Console.WriteLine("от -y до 0, от -x до 0");
    }
    if (a == 4)
    {
        Console.WriteLine("от -y до 0, от 0 до x");
    }
}
