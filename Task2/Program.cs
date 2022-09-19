// 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)


Console.Clear();

Console.Write("Enter number: ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1) Console.WriteLine($"x = 1,2,3....infty и y = 1,2,3....infty");
if (quarter == 2) Console.WriteLine(("x = -1, -2, -3....infty и y = 1, 2, 3....infty"));
if (quarter == 3) Console.WriteLine(("x = -1, -2, -3....infty и y = -1, -2, -3....infty"));
if (quarter == 4) Console.WriteLine(("x = 1, 2, 3....infty и y = -1, -2, -3....infty"));
