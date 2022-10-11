// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ведите второе число:");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if (num1 == num2 * num2)
{
    Console.WriteLine("Первое число является квадратом второго!");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго!");
}
if (num2 == num1 * num1)
{
    Console.WriteLine("Второе число является квадратом первого!");
}
else
{
    Console.WriteLine("Второе число не явлется квадратом первого!");
}
