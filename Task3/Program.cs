using System;

class Program
{
    static void Main()
    {
        double x, y, z;

        Console.Write("Введіть x: ");
        if (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Помилка: x введено некоректно.");
            return;
        }

        Console.Write("Введіть y: ");
        if (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Помилка: y введено некоректно.");
            return;
        }

        Console.Write("Введіть z: ");
        if (!double.TryParse(Console.ReadLine(), out z))
        {
            Console.WriteLine("Помилка: z введено некоректно.");
            return;
        }

        double numeratorExpression = 3 + Math.Tan(x) - y / 2.0;
        double numerator = Math.Cbrt(numeratorExpression);

        double denominator = Math.Pow(x, 2) + Math.Pow(z, 3) + 4;

        if (denominator == 0)
        {
            Console.WriteLine("Помилка: знаменник дорівнює нулю.");
            return;
        }

        double s = numerator / denominator;

        s = Math.Round(s, 3);

        Console.WriteLine($"s = {s:F3}");
    }
}