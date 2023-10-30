using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Введите второе число:");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                double sum = num1 + num2;
                double product = num1 * num2;

                Console.WriteLine($"Сумма чисел: {sum}");
                Console.WriteLine($"Произведение чисел: {product}");
            }
            else
            {
                Console.WriteLine("Неверный формат второго числа.");
            }
        }
        else
        {
            Console.WriteLine("Неверный формат первого числа.");
        }
    }
}
