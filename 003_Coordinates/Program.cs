// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти от 1 до 4");
int num = int.Parse(Console.ReadLine() ?? "0");

if (num == 1)
{
    Console.WriteLine($"Диапазоны возможных координат для {num} четверти: X > 0, Y > 0");
}
if (num == 2)
{
    Console.WriteLine($"Диапазоны возможных координат для {num} четверти: X < 0, Y > 0");
}
if (num == 3)
{
    Console.WriteLine($"Диапазоны возможных координат для {num} четверти: X < 0, Y < 0");
}
if (num == 4)
{
    Console.WriteLine($"Диапазоны возможных координат для {num} четверти: X > 0, Y < 0");
}
if (num < 1 || num > 4)
{
    Console.WriteLine("Номер четверти введен не верно!");
}
