// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Enter five(5) digits number: ");
string? num = Console.ReadLine();

void CheckingNumber(string num)
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"{num} -> Yes");
    }
    else Console.WriteLine($"{num} -> No");
}

if (num!.Length == 5)
{
    CheckingNumber(num);
}
else Console.WriteLine($"Pls enter correct number");
