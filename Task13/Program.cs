// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine($"У числа {number} третья цифра отстутсвует. ");
}
else
{
    int digitCount = Convert.ToInt32(number.ToString().Length - 2);
    int digit = Convert.ToInt32(number % (Math.Pow(10, digitCount)));
    int thirdDigit = Convert.ToInt32(digit / (Math.Pow(10, digitCount-1)));
    Console.WriteLine(thirdDigit);
}