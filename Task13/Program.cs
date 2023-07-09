// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число:");
string number = (Console.ReadLine());

int number2 = int.Parse(number);
int thirdDigit = number2;
if (thirdDigit > 999)
{
    while (thirdDigit > 999)
    {
        thirdDigit = thirdDigit / 10;
    }
    Console.WriteLine($"Третья цифра числа {number2} -> {thirdDigit % 10}");
}
else
{
    if (number2 > 99)
    {
        Console.WriteLine($"Третья цифра числа {number2} -> {thirdDigit % 10}");
    }
    else
    {
        Console.WriteLine($"Третья цифра числа {number2} -> отсутсвует");
    }
}