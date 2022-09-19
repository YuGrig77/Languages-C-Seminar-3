// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();
Mark1:
Console.Write("Please enter five(5) digits number: ");
int num = int.Parse(Console.ReadLine());

if (10000 <= num && num < 100000)
{
    if ((num / 10000) == (num % 10) && ((num / 1000) % 10) == ((num / 10) % 10))
    {
        Console.WriteLine($"{num} -> Yes");
    }
    else
    {
        Console.WriteLine($"{num} -> No");
    }
}
else
{
    Console.WriteLine($"Pls enter correct number");
    goto Mark1;
}
