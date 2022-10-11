// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.Write("Для нахождения расстояния между точками в пространстве 2D нажмите (2), в пространстве 3D нажмите (3): ");
int button = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

if (button == 2)
{
    Console.Write("Введите координату Xa: ");
    int Xa = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    Console.Write("Введите координату Xb: ");
    int Xb = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    Console.Write("Введите координату Ya: ");
    int Ya = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    Console.Write("Введите координату Yb: ");
    int Yb = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    double dist = Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya));
    Console.WriteLine($"Расстояние между точками в пространстве 2D равно {dist}");
}
else if (button == 3)
{
    Console.Write("Введите координаты Xa: ");
    int Xa = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    Console.Write("Введите координаты Xb: ");
    int Xb = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    Console.Write("Введите координаты Ya: ");
    int Ya = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    Console.Write("Введите координаты Yb: ");
    int Yb = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    Console.Write("Введите координаты Za: ");
    int Za = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    Console.Write("Введите координаты Zb: ");
    int Zb = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

    double result = Math.Sqrt((Xb - Xa) * (Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya) * (Yb - Ya) + (Zb - Za) * (Zb - Za) * (Zb - Za));
    Console.WriteLine($"Расстояние между точками в пространстве 3D равно {result}");
}
else
{
    Console.WriteLine("Неверный ввод, нажмите 2 или 3");
}
