using System;

// Задание 7
class Program7
{
    static void Main()
    {
        Console.WriteLine("=== ЗАДАНИЕ 7: КОЛОНИЗАЦИЯ МАРСА ===");
        
        // Улучшение: проверка ввода основных параметров
        int modules = 0;
        while (true)
        {
            Console.Write("Введите количество модулей n: ");
            if (int.TryParse(Console.ReadLine(), out modules) && modules > 0)
                break;
            Console.WriteLine("Ошибка ввода!");
        }
        
        Console.Write("Введите размеры модуля a b: ");
        string[] sizes = Console.ReadLine().Split();
        int a_size = int.Parse(sizes[0]);
        int b_size = int.Parse(sizes[1]);
        
        Console.Write("Введите размеры поля h w: ");
        string[] field = Console.ReadLine().Split();
        int h = int.Parse(field[0]);
        int w = int.Parse(field[1]);
        
        int maxD = 0;
        
        // Улучшение: проверка обеих ориентаций модулей
        for (int d = 0; d <= Math.Min(h, w); d++)
        {
            int newA = a_size + 2 * d;
            int newB = b_size + 2 * d;
            
            bool canPlace1 = (h / newA) * (w / newB) >= modules;
            bool canPlace2 = (h / newB) * (w / newA) >= modules;
            
            if (canPlace1 || canPlace2)
            {
                maxD = d;
            }
            else
            {
                break;
            }
        }
        
        Console.WriteLine($"Максимальная толщина защиты: {maxD}");
    }
}

/*
=== ЗАДАНИЕ 7 Вывод ===
Введите количество модулей n: 10
Введите размеры модуля a b: 2 3
Введите размеры поля h w: 20 30
Максимальная толщина защиты: 2

УЛУЧШЕНИЯ:
1. Проверка ввода основных параметров
2. Проверка обеих ориентаций модулей
*/
