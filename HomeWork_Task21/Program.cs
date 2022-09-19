// Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Pls enter coordinates (xa,ya,za,xb,yb,zb) of points A & B : ");
string[] pieceStr = Console.ReadLine().Split(',');
double[] piecedbl = new double[6];

for (int i = 0; i < piecedbl.Length; i++)
    piecedbl[i] = Convert.ToInt32(pieceStr[i]);
double res = Math.Round(Math.Sqrt(Math.Pow(piecedbl[0] - piecedbl[3], 2)
+ Math.Pow(piecedbl[1] - piecedbl[4], 2) + Math.Pow(piecedbl[2] - piecedbl[5], 2)), 2);
Console.WriteLine($"Length of piece AB where A({piecedbl[0]},{piecedbl[1]},{piecedbl[2]}); B({piecedbl[3]},{piecedbl[4]},{piecedbl[5]}) => {res}");


// Console.Write("Введите координаты точки А ");
// Console.Write("Введите координаты точки B ");
// string[] masStr = Console.ReadLine().Split(' ');
// double[] masSdbl = new double [4];
// for (int index = 0; index < masStr.Length; index++) // цикл для заполнения пустого целочисленного массива
//     masSdbl [index] = Convert.ToInt32(masStr[index]);
// double res = Math.Sqrt(Math.Pow(masSdbl[0] - masSdbl[2], 2)+ Math.Pow(masSdbl[1] - masSdbl[3], 2));
// Console.WriteLine($"Расстояние между точками{res}");