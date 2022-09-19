//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//Формула длины отрезка: d = √((хА –  хВ)2 + (уА – уВ)2) 
//Запись в Math {Math.Round(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2)), 2)}

Console.WriteLine("Введите координаты первой точки");
string[] values = Console.ReadLine().Split(' ');
int x1 = int.Parse(values[0]);
int y1 = int.Parse(values[1]);

Console.WriteLine("Введите координаты второй точки");
string[] values_2 = Console.ReadLine().Split(' ');
int x2 = int.Parse(values_2[0]);
int y2 = int.Parse(values_2[1]);

double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 2);

Console.WriteLine($"Расстояние между двумя точками в 2D равно: {result}");