using System;

namespace DelegateExample
{
    class Program
    {
        // Делегат для функцій
        delegate double FunctionDelegate(double x);

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення x:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double x))
            {
                // Вибір функції через делегат
                FunctionDelegate function;

                if (x > 0)
                {
                    function = Function1; // x > 0
                }
                else
                {
                    function = Function2; // x <= 0
                }

                double result = function(x);
                Console.WriteLine($"Результат F({x}) = {result}");
            }
            else
            {
                Console.WriteLine("Потрібно було ввести число.");
            }
        }

        // Функція для x > 0: F(x) = sin²(x)
        static double Function1(double x)
        {
            return Math.Pow(Math.Sin(x), 2);
        }

        // Функція для x <= 0: F(x) = 1 + 2 * sin²(x)
        static double Function2(double x)
        {
            return 1 + 2 * Math.Pow(Math.Sin(x), 2);
        }
    }
}
