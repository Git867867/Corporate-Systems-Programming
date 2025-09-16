using System;

class Calculator
{
    private double memory = 0;
    private double currentValue = 0;
    
    public void Run()
    {
        Console.WriteLine("Калькулятор запущен!");
        Console.WriteLine("Доступные операции: +, -, *, /, %, 1/x, x^2, sqrt, M+, M-, MR, C (очистка), EXIT");
        
        while (true)
        {
            Console.Write($"Текущее значение: {currentValue} > ");
            string input = Console.ReadLine()?.Trim().ToUpper();
            
            if (string.IsNullOrEmpty(input)) continue;
            
            if (input == "EXIT") break;
            if (input == "C")
            {
                currentValue = 0;
                continue;
            }
            
            ProcessInput(input);
        }
        
        Console.WriteLine("Работа калькулятора завершена.");
    }
    
    private void ProcessInput(string input)
    {
        try
        {
            switch (input)
            {
                case "M+":
                    memory += currentValue;
                    Console.WriteLine($"Значение {currentValue} добавлено в память");
                    break;
                    
                case "M-":
                    memory -= currentValue;
                    Console.WriteLine($"Значение {currentValue} вычтено из памяти");
                    break;
                    
                case "MR":
                    currentValue = memory;
                    Console.WriteLine($"Значение из памяти: {memory}");
                    break;
                    
                case "1/X":
                    if (currentValue == 0)
                        throw new DivideByZeroException("Деление на ноль!");
                    currentValue = 1 / currentValue;
                    break;
                    
                case "X^2":
                    currentValue *= currentValue;
                    break;
                    
                case "SQRT":
                    if (currentValue < 0)
                        throw new ArgumentException("Корень из отрицательного числа!");
                    currentValue = Math.Sqrt(currentValue);
                    break;
                    
                default:
                    ProcessOperation(input);
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
    
    private void ProcessOperation(string input)
    {
        if (double.TryParse(input, out double number))
        {
            currentValue = number;
            return;
        }
        
        string[] parts = input.Split(' ');
        if (parts.Length != 2)
        {
            Console.WriteLine("Неверный формат ввода! Используйте: число операция");
            return;
        }
        
        if (!double.TryParse(parts[0], out double operand))
        {
            Console.WriteLine("Неверный формат числа!");
            return;
        }
        
        string operation = parts[1];
        switch (operation)
        {
            case "+":
                currentValue += operand;
                break;
                
            case "-":
                currentValue -= operand;
                break;
                
            case "*":
                currentValue *= operand;
                break;
                
            case "/":
                if (operand == 0)
                    throw new DivideByZeroException("Деление на ноль!");
                currentValue /= operand;
                break;
                
            case "%":
                currentValue %= operand;
                break;
                
            default:
                Console.WriteLine("Неизвестная операция!");
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        calculator.Run();
    }
}