Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели (1-7):");
int dayOfWeek = int.Parse(Console.ReadLine());

if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine($"{dayOfWeek}-й день недели -  это выходной день.");
}
if (dayOfWeek < 1 || dayOfWeek > 7)
{
    Console.WriteLine("Дня недели под таким порядковым номером не существует.");
}
if (dayOfWeek >= 1 && dayOfWeek < 6)
{
    Console.WriteLine($"{dayOfWeek}-й день недели -  это не выходной день.");
}
