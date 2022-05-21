using System.Diagnostics;
using System.Numerics;

namespace AutoMorph
{
    class Program
    {
        static void Main()
        {
            BigInteger MaxValue = 10000000000;  //10^10
            MaxValue *= MaxValue;               //10^20
            MaxValue *= MaxValue;               //10^40
            MaxValue *= MaxValue;               //10^80
            MaxValue *= MaxValue;               //10^160
            MaxValue *= MaxValue;               //10^320
            MaxValue *= MaxValue;               //10^640
            MaxValue *= MaxValue;               //10^1280
            Console.ReadKey();
            Console.WriteLine($"Начинаем вычисления до {MaxValue}");
            var Timer = Stopwatch.StartNew();

            AutoMorph.Run(MaxValue);

            Timer.Stop();
            Console.WriteLine($"Вычисления закончены за {Timer.Elapsed.TotalSeconds} секунд");

            foreach (var item in AutoMorph.Get())
            {
                Console.WriteLine("{0,200}\n{1,200}", item, item * item);
            }
            Console.WriteLine($"Найдено {AutoMorph.Get().Count} значений");
            Console.WriteLine($"Вычисления закончены за {Timer.Elapsed.TotalSeconds} секунд");
            Console.WriteLine($"Вычисления до {MaxValue}");
            Console.ReadKey();
        }
    }
}