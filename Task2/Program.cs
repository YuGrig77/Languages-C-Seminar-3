// 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)


Console.Clear();

Console.Write("Enter number: ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1) Console.WriteLine($"x = 1,2,3....infty и y = 1,2,3....infty");
if (quarter == 2) Console.WriteLine(("x = -1, -2, -3....infty и y = 1, 2, 3....infty"));
if (quarter == 3) Console.WriteLine(("x = -1, -2, -3....infty и y = -1, -2, -3....infty"));
if (quarter == 4) Console.WriteLine(("x = 1, 2, 3....infty и y = -1, -2, -3....infty"));

//OR

//Console.WriteLine("Введите номер четверти");
// int a = int.Parse(Console.ReadLine());
// if (a > 4)
// {
//     Console.WriteLine("вы за диапозоном");
// }
// else
// {
//     if ( a == 1)
// {
//     Console.WriteLine("от 0 до y, от 0 до x");
// }
// if (a == 2)
// {
//   Console.WriteLine("от 0 до y, от -x до 0");
// }
// if (a == 3)
// {
//   Console.WriteLine("от -y до 0, от -x до 0");
// }
// if (a == 4)
// {
//   Console.WriteLine("от -y до 0, от 0 до x");
// }

//OR

//Console.WriteLine("Введите номер четверти");
// int num = int.Parse(Console.ReadLine());

// if(num > 4 || num <1)
// {
//     Console.WriteLine("От одного до четырёх, пожалуйста.");
//     return; 
// }
// if(num == 1)
// {
//     Console.WriteLine($"X = (0;оо) Y = (0;оо).");
// }
// if(num == 2)
// {
//     Console.WriteLine($"X = (-оо;0) Y = (0;оо).");
// }
// if(num == 3)
// {
//     Console.WriteLine($"X = (-оо;0) Y = (-оо;0).");
// }
// if(num == 4)
// {
//     Console.WriteLine($"X = (0;оо) Y = (-оо;0).");
// }

