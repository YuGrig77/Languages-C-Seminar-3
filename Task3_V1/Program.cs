//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//Формула длины отрезка: d = √((хА –  хВ)2 + (уА – уВ)2) 
//Запись в Math {Math.Round(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2)), 2)}

Console.Write("Введите x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double roundDistance = Math.Round(distance, 3);

Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}) равно {roundDistance}");