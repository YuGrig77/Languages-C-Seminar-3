//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
//Формула длины отрезка: d = √((хА –  хВ)2 + (уА – уВ)2) 
//Запись в Math {Math.Round(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2)), 2)}

Console.Write("Введите координаты точки А ");
Console.Write("Введите координаты точки B ");
string[] masStr = Console.ReadLine().Split(' ');
double[] masSdbl = new double[4];
for (int index = 0; index < masStr.Length; index++) // цикл для заполнения пустого целочисленного массива
    masSdbl[index] = Convert.ToInt32(masStr[index]);
double res = Math.Sqrt(Math.Pow(masSdbl[0] - masSdbl[2], 2) + Math.Pow(masSdbl[1] - masSdbl[3], 2));
Console.WriteLine($"Расстояние между точками{res}");
