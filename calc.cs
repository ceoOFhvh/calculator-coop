using System;

class Calculator
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Ошибка! Некорректное число a.");
            return;
        }

        Console.Write("Выберите операцию (+, -, *, /, **, sqrt, inv): ");
        string op = Console.ReadLine();

        if (op == "sqrt")
        {
            if (a < 0) Console.WriteLine("Ошибка! Корень из отрицательного числа.");
            else Console.WriteLine($"√{a} = {Math.Sqrt(a)}");
            return;
        }

        if (op == "inv")
        {
            if (a == 0) Console.WriteLine("Ошибка! Деление на ноль.");
            else Console.WriteLine($"1/{a} = {1/a}");
            return;
        }

        Console.Write("Введите число b: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Ошибка! Некорректное число b.");
            return;
        }

        switch (op)
        {
            case "+":
                Console.WriteLine($"{a} + {b} = {a + b}");
                break;
            case "-":
                Console.WriteLine($"{a} - {b} = {a - b}");
                break;
            case "*":
                Console.WriteLine($"{a} * {b} = {a * b}");
                break;
            case "/":
                if (b == 0) Console.WriteLine("Ошибка! Деление на ноль.");
                else Console.WriteLine($"{a} / {b} = {a / b}");
                break;
            case "**":
                Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
                break;
            default:
                Console.WriteLine("Ошибка! Неизвестная операция.");
                break;
        }
    }
}
