//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//Формула длины отрезка: d = √((хА –  хВ)2 + (уА – уВ)2) 
//Запись в Math {Math.Round(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2)), 2)}

Console.Clear();

Console.Write("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Длина отрезка =  {Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)), 2)}");
