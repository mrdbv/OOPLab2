using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть n (> 0): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Помилка: n має бути додатним цілим числом.");
            return;
        }

        Console.Write("Введіть k (> 0): ");
        if (!int.TryParse(Console.ReadLine(), out int k) || k <= 0)
        {
            Console.WriteLine("Помилка: k має бути додатним цілим числом.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("Оберіть, яку суму обчислити:");
        Console.WriteLine("1 - 1^n + 2^n + ... + k^n");
        Console.WriteLine("2 - 1^k + 2^k + ... + n^k");
        Console.WriteLine("3 - 1/n + 1/n^2 + ... + 1/n^k");

        Console.Write("Ваш вибір: ");

        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine("Помилка введення.");
            return;
        }

        double sum = 0;

        switch (choice)
        {
            case 1:
                for (int i = 1; i <= k; i++)
                {
                    sum += Math.Pow(i, n);
                }

                Console.WriteLine($"Сума = {sum}");
                break;

            case 2:
                for (int i = 1; i <= n; i++)
                {
                    sum += Math.Pow(i, k);
                }

                Console.WriteLine($"Сума = {sum}");
                break;

            case 3:
                for (int i = 1; i <= k; i++)
                {
                    sum += 1.0 / Math.Pow(n, i);
                }

                Console.WriteLine($"Сума = {sum:F3}");
                break;

            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }
}