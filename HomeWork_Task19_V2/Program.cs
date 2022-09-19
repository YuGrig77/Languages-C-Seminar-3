// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число для получения таблицы кубов:");
bool checkNum = int.TryParse(Console.ReadLine(), out int num);

while (!checkNum)
{
    Console.WriteLine("Введите число для проверки:");
    checkNum = int.TryParse(Console.ReadLine(), out num);
}
