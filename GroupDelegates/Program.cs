using System;

namespace GroupDelegates
{
    class Program
    {
        // Делегат для методів, що визначають пору року
        delegate void SeasonDelegate(int month);

        static void Main(string[] args)
        {
            // Створюємо делегат для виклику методів
            SeasonDelegate seasonDelegate = Season;
            seasonDelegate += AverageTemperature;

            Console.WriteLine("Введіть номер місяця (1-12):");
            if (int.TryParse(Console.ReadLine(), out int month) && month >= 1 && month <= 12)
            {
                // Викликаємо всі методи, що делегуються
                seasonDelegate(month);
            }
            else
            {
                Console.WriteLine("Номер місяця має бути від 1 до 12.");
            }
        }

        // Метод для визначення пори року
        static void Season(int month)
        {
            string season = month switch
            {
                12 or 1 or 2 => "Зима",
                3 or 4 or 5 => "Весна",
                6 or 7 or 8 => "Літо",
                9 or 10 or 11 => "Осінь",
                _ => "Невідома пора року"
            };

            Console.WriteLine($"Пора року: {season}");
        }

        // Метод для виведення середньої температури
        static void AverageTemperature(int month)
        {
            int temperature = month switch
            {
                12 or 1 or 2 => -5,
                3 or 4 or 5 => 10,
                6 or 7 or 8 => 25,
                9 or 10 or 11 => 15,
                _ => 0
            };

            Console.WriteLine($"Середня температура: {temperature}°C");
        }
    }
}
