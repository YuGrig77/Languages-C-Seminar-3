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

Console.WriteLine($"Длина отрезка =  {Math.Round(Math.Sqrt(Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2)), 2)}");

// OR
//Console.Write("Введите x1: ");
// double x1 = double.Parse(Console.ReadLine());
// Console.Write("Введите y1: ");
// double y1 = double.Parse(Console.ReadLine());
// Console.Write("Введите x2: ");
// double x2 = double.Parse(Console.ReadLine());
// Console.Write("Введите y2: ");
// double y2 = double.Parse(Console.ReadLine());

// double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
// double roundDistance = Math.Round(distance, 3);

// Console.WriteLine($"Расстояние между точками ({x1}, {y1}) и ({x2}, {y2}) равно {roundDistance}");

//OR

//Console.WriteLine("Введите координаты первой точки");
// string[] values = Console.ReadLine().Split(' ');
// int x1 = int.Parse(values[0]);
// int y1 = int.Parse(values[1]);

// Console.WriteLine("Введите координаты второй точки");
// string[] values_2 = Console.ReadLine().Split(' ');
// int x2 = int.Parse(values_2[0]);
// int y2 = int.Parse(values_2[1]);
    
// double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),2);

// Console.WriteLine($"Расстояние между двумя точками в 2D равно: {result}");

// OR

//Console.Write("Введите координаты точки А ");
// Console.Write("Введите координаты точки B ");
// string[] masStr = Console.ReadLine().Split(' ');
// double[] masSdbl = new double [4];
// for (int index = 0; index < masStr.Length; index++)      // цикл для заполнения пустого целочисленного массива
//     masSdbl [index] = Convert.ToInt32(masStr[index]);
// double res = Math.Sqrt(Math.Pow(masSdbl[0] - masSdbl[2], 2)+ Math.Pow(masSdbl[1] - masSdbl[3], 2));
// Console.WriteLine($"Расстояние между точками{res}");
