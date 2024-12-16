using System;

namespace UniversalDelegates
{
    class Program
    {
        // Делегат для арифметичних операцій
        delegate double OperationDelegate(double a, double b);

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть перше число:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Виберіть операцію (+, -, *, /):");
            string operation = Console.ReadLine();

            OperationDelegate operationDelegate = operation switch
            {
                "+" => Add,
                "-" => Subtract,
                "*" => Multiply,
                "/" => Divide,
                _ => null
            };

            if (operationDelegate != null)
            {
                double result = operationDelegate(a, b);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Невірна операція.");
            }
        }

        // Методи для операцій
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => b != 0 ? a / b : double.NaN;
    }
}
