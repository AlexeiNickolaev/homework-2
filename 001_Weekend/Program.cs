// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Выберите число обозначающее день недели");
int day = int.Parse(Console.ReadLine() ?? "0");

if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день!!!");
}
else if (day > 0 && day < 6)
{
    Console.WriteLine("Рабочий день!");
}
else
{
    Console.WriteLine("Неправильно введен номер дня недели!");
}