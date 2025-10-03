using System;

// Задание 5: Кофейный аппарат
class Program5
{
    static void Main()
    {
        Console.WriteLine("=== ЗАДАНИЕ 5: КОФЕЙНЫЙ АППАРАТ ===");
        
        // Улучшение: проверка отрицательных значений
        int water = 0;
        while (true)
        {
            Console.Write("Введите количество воды (мл): ");
            if (int.TryParse(Console.ReadLine(), out water) && water >= 0)
                break;
            Console.WriteLine("Ошибка ввода!");
        }
        
        int milk = 0;
        while (true)
        {
            Console.Write("Введите количество молока (мл): ");
            if (int.TryParse(Console.ReadLine(), out milk) && milk >= 0)
                break;
            Console.WriteLine("Ошибка ввода!");
        }
        
        int americanoCount = 0;
        int latteCount = 0;
        int revenue = 0;
        
        while (true)
        {
            Console.WriteLine($"Остаток: вода={water} мл, молоко={milk} мл");
            Console.Write("Выберите напиток (1-американо, 2-латте, 0-завершить): ");
            int choice = int.Parse(Console.ReadLine());
            
            if (choice == 0) break;
            
            if (choice == 1)
            {
                if (water >= 300)
                {
                    water -= 300;
                    americanoCount++;
                    revenue += 150;
                    Console.WriteLine("Ваш американо готов! Цена: 150 руб");
                }
                else
                {
                    Console.WriteLine("Не хватает воды");
                }
            }
            else if (choice == 2)
            {
                if (water >= 30 && milk >= 270)
                {
                    water -= 30;
                    milk -= 270;
                    latteCount++;
                    revenue += 170;
                    Console.WriteLine("Ваш латте готов! Цена: 170 руб");
                }
                else if (water < 30)
                {
                    Console.WriteLine("Не хватает воды");
                }
                else
                {
                    Console.WriteLine("Не хватает молока");
                }
            }
            
            // Улучшение: автоматическое завершение при недостатке ингредиентов
            if (water < 300 && (water < 30 || milk < 270))
            {
                Console.WriteLine("Ингредиенты подошли к концу!");
                break;
            }
        }
        
        Console.WriteLine("Отчет:");
        Console.WriteLine($"Остаток воды: {water} мл");
        Console.WriteLine($"Остаток молока: {milk} мл");
        Console.WriteLine($"Приготовлено американо: {americanoCount}");
        Console.WriteLine($"Приготовлено латте: {latteCount}");
        Console.WriteLine($"Итоговый заработок: {revenue} руб");
    }
}

/*
=== ЗАДАНИЕ 5: КОФЕЙНЫЙ АППАРАТ ===
Введите количество воды (мл): 1000
Введите количество молока (мл): 1000
Остаток: вода=1000 мл, молоко=1000 мл
Выберите напиток (1-американо, 2-латте, 0-завершить): 1
Ваш американо готов! Цена: 150 руб
Остаток: вода=700 мл, молоко=1000 мл
Выберите напиток (1-американо, 2-латте, 0-завершить): 2
Ваш латте готов! Цена: 170 руб
Остаток: вода=670 мл, молоко=730 мл
Выберите напиток (1-американо, 2-латте, 0-завершить): 0
Отчет:
Остаток воды: 670 мл
Остаток молока: 730 мл
Приготовлено американо: 1
Приготовлено латте: 1
Итоговый заработок: 320 руб

УЛУЧШЕНИЯ:
1. Проверка отрицательных значений
2. Автоматическое завершение при недостатке ингредиентов
*/