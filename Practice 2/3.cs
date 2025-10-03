using System;

// Задание 3
class Program3
{
    static void Main()
    {
        Console.WriteLine("=== ЗАДАНИЕ 3: СОКРАЩЕНИЕ ДРОБИ ===");
        
        // Улучшение: проверка знаменателя на ноль
        int m = 0;
        while (true)
        {
            Console.Write("Введите числитель M: ");
            if (int.TryParse(Console.ReadLine(), out m))
                break;
            Console.WriteLine("Ошибка ввода!");
        }
        
        int n_val = 0;
        while (true)
        {
            Console.Write("Введите знаменатель N: ");
            if (int.TryParse(Console.ReadLine(), out n_val) && n_val != 0)
                break;
            Console.WriteLine("Ошибка! Знаменатель не может быть 0");
        }
        
        int a = Math.Abs(m);
        int b = Math.Abs(n_val);
        
        // Алгоритм Евклида
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        
        int gcd = a;
        int numerator = m / gcd;
        int denominator = n_val / gcd;
        
        // Улучшение: нормализация знака дроби
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }
        
        Console.WriteLine($"Несократимая дробь: {numerator}/{denominator}");
    }
}

/*
=== ЗАДАНИЕ 3 Вывод ===
Введите числитель M: 12
Введите знаменатель N: 18
Несократимая дробь: 2/3

УЛУЧШЕНИЯ:
1. Проверка знаменателя на ноль
2. Нормализация знака дроби
*/
