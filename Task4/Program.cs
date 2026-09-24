using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть a: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Помилка: a введено некоректно.");
            return;
        }

        Console.Write("Введіть b: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Помилка: b введено некоректно.");
            return;
        }

        Console.Write("Введіть c: ");
        if (!double.TryParse(Console.ReadLine(), out double c))
        {
            Console.WriteLine("Помилка: c введено некоректно.");
            return;
        }

        if (a == 0)
        {
            Console.WriteLine("Помилка: a не може дорівнювати 0.");
            return;
        }

        double D = Math.Pow(b, 2) - 4 * a * c;

        Console.WriteLine($"D = {D:F3}");

        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            Console.WriteLine($"x1 = {x1:F3}");
            Console.WriteLine($"x2 = {x2:F3}");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);

            Console.WriteLine($"x = {x:F3}");
        }
        else
        {
            Console.WriteLine("Дійсних коренів немає.");
        }
    }
}