// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число:");

int number = int.Parse(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine("Вторая цифра числа: " + secondDigit);
}
else
{
    Console.WriteLine("Введенное вами число не является трехзначным.");
}


