using System;

// Задание 2: Счастливый билет
class Program2
{
    static void Main()
    {
        Console.WriteLine("=== ЗАДАНИЕ 2: СЧАСТЛИВЫЙ БИЛЕТ ===");
        
        // Улучшение: проверка диапазона номера билета
        int ticket = 0;
        while (true)
        {
            Console.Write("Введите шестизначный номер билета: ");
            if (int.TryParse(Console.ReadLine(), out ticket) && ticket >= 0 && ticket <= 999999)
                break;
            Console.WriteLine("Ошибка! Введите число от 0 до 999999");
        }
        
        int digit1 = ticket / 100000;
        int digit2 = (ticket / 10000) % 10;
        int digit3 = (ticket / 1000) % 10;
        int digit4 = (ticket / 100) % 10;
        int digit5 = (ticket / 10) % 10;
        int digit6 = ticket % 10;
        
        int sumFirst = digit1 + digit2 + digit3;
        int sumLast = digit4 + digit5 + digit6;
        
        if (sumFirst == sumLast)
            Console.WriteLine("Билет счастливый!");
        else
            Console.WriteLine("Билет обычный.");
    }
}

/*
=== ЗАДАНИЕ 2: СЧАСТЛИВЫЙ БИЛЕТ ===
Введите шестизначный номер билета: 123321
Билет счастливый!

УЛУЧШЕНИЯ:
1. Проверка диапазона номера билета
*/