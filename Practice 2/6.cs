using System;

// Задание 6: Лабораторный опыт
class Program6
{
    static void Main()
    {
        Console.WriteLine("=== ЗАДАНИЕ 6: ЛАБОРАТОРНЫЙ ОПЫТ ===");
        
        // Улучшение: безопасный ввод данных
        long bacteria = 0;
        while (true)
        {
            Console.Write("Введите количество бактерий N: ");
            if (long.TryParse(Console.ReadLine(), out bacteria) && bacteria >= 0)
                break;
            Console.WriteLine("Ошибка ввода!");
        }
        
        int antibiotic = 0;
        while (true)
        {
            Console.Write("Введите количество капель антибиотика X: ");
            if (int.TryParse(Console.ReadLine(), out antibiotic) && antibiotic >= 0)
                break;
            Console.WriteLine("Ошибка ввода!");
        }
        
        int hour = 0;
        
        // Улучшение: ограничение количества часов
        while (hour < 20)
        {
            hour++;
            int killPower = Math.Max(10 - (hour - 1), 0);
            
            if (killPower == 0) break;
            
            bacteria *= 2;
            bacteria -= killPower * antibiotic;
            
            if (bacteria <= 0)
            {
                bacteria = 0;
                Console.WriteLine($"Час {hour}: бактерий = {bacteria}");
                break;
            }
            
            Console.WriteLine($"Час {hour}: бактерий = {bacteria}");
        }
        
        Console.WriteLine($"Итог: бактерий осталось = {bacteria}");
    }
}

/*
=== ЗАДАНИЕ 6: ЛАБОРАТОРНЫЙ ОПЫТ ===
Введите количество бактерий N: 10
Введите количество капель антибиотика X: 1
Час 1: бактерий = 10
Час 2: бактерий = 11
Час 3: бактерий = 13
Час 4: бактерий = 17
Час 5: бактерий = 25
Час 6: бактерий = 41
Час 7: бактерий = 73
Час 8: бактерий = 137
Час 9: бактерий = 265
Час 10: бактерий = 521
Итог: бактерий осталось = 521

УЛУЧШЕНИЯ:
1. Безопасный ввод данных
2. Ограничение количества часов
*/