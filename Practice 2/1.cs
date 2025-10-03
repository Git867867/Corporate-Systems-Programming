using System;

// Задание 1
class Program1
{
    static void Main()
    {
        Console.WriteLine("=== ЗАДАНИЕ 1: РЯДЫ ===");
        
        // Улучшение: безопасный ввод с проверкой ошибок
        double x = 0;
        while (true)
        {
            Console.Write("Введите x: ");
            if (double.TryParse(Console.ReadLine().Replace(',', '.'), out x))
                break;
            Console.WriteLine("Ошибка ввода!");
        }
        
        double epsilon = 0;
        while (true)
        {
            Console.Write("Введите точность (e < 0.01): ");
            if (double.TryParse(Console.ReadLine().Replace(',', '.'), out epsilon) && epsilon > 0 && epsilon < 0.01)
                break;
            Console.WriteLine("Ошибка! Точность должна быть от 0 до 0.01");
        }

        // Улучшение: рекуррентная формула для избежания переполнения
        double sum = 0;
        double term = 1;
        int n = 0;
        
        while (Math.Abs(term) > epsilon)
        {
            sum += term;
            n++;
            term = term * x / n;
        }
        
        Console.WriteLine($"Значение e^x с точностью {epsilon}: {sum}");
        
        // Улучшение: проверка корректности номера члена
        int memberNum = 0;
        while (true)
        {
            Console.Write("Введите номер члена ряда: ");
            if (int.TryParse(Console.ReadLine(), out memberNum) && memberNum >= 0)
                break;
            Console.WriteLine("Ошибка ввода!");
        }
        
        double memberTerm = 1;
        for (int i = 1; i <= memberNum; i++)
        {
            memberTerm = memberTerm * x / i;
        }
        
        Console.WriteLine($"Значение {memberNum}-го члена: {memberTerm}");
    }
}

/*
=== ЗАДАНИЕ 1 Вывод ===
Введите x: 1
Введите точность (e < 0.01): 0.0001
Значение e^x с точностью 0.0001: 2.7182539682539684
Введите номер члена ряда: 5
Значение 5-го члена: 0.008333333333333333

УЛУЧШЕНИЯ:
1. Безопасный ввод с проверкой ошибок
2. Рекуррентная формула вместо факториала
3. Проверка корректности номера члена
*/
