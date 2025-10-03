using System;

// Задание 4
class Program4
{
    static void Main()
    {
        Console.WriteLine("=== ЗАДАНИЕ 4: УГАДАЙ ЧИСЛО ===");
        Console.WriteLine("Загадайте число от 0 до 63");
        
        int low = 0;
        int high = 63;
        
        // Улучшение: безопасный ввод ответов
        for (int i = 0; i < 6; i++)
        {
            int mid = (low + high) / 2;
            int answer = 0;
            while (true)
            {
                Console.Write($"Ваше число больше {mid}? (1-да, 0-нет): ");
                if (int.TryParse(Console.ReadLine(), out answer) && (answer == 0 || answer == 1))
                    break;
                Console.WriteLine("Ошибка! Введите 0 или 1");
            }
            
            if (answer == 1)
                low = mid + 1;
            else
                high = mid;
        }
        
        Console.WriteLine($"Ваше число: {low}");
    }
}

/*
=== ЗАДАНИЕ 4 Вывод ===
Загадайте число от 0 до 63
Ваше число больше 31? (1-да, 0-нет): 0
Ваше число больше 15? (1-да, 0-нет): 1
Ваше число больше 23? (1-да, 0-нет): 1
Ваше число больше 27? (1-да, 0-нет): 0
Ваше число больше 25? (1-да, 0-нет): 1
Ваше число больше 26? (1-да, 0-нет): 0
Ваше число: 26

УЛУЧШЕНИЯ:
1. Безопасный ввод ответов
*/
