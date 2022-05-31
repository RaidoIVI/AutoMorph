using System.Diagnostics;
using System.Numerics;

namespace AutoMorph
{
    class Program
    {
        static void Main()
        {
            int iteration = IO.GetInt("Введите порядок вычисления: ");
            BigInteger MaxValue = BigInteger.Pow(10, iteration);

            Console.WriteLine($"Начинаем вычисления до {MaxValue}");
            var Timer = Stopwatch.StartNew();

            AutoMorph.Run(MaxValue);

            Timer.Stop();
            Console.WriteLine($"Вычисления закончены за {Timer.Elapsed.TotalSeconds} секунд");

            IO.SendToFile("", AutoMorph.Get(), Timer, iteration);

            Console.WriteLine($"Найдено {AutoMorph.Get().Count} значений");
            Console.WriteLine($"Вычисления закончены за {Timer.Elapsed.TotalSeconds} секунд");
            Console.WriteLine($"Вычисления до 10^{iteration}");
            Console.ReadKey();
        }
    }
}