using System.Diagnostics;
using System.Numerics;

namespace AutoMorph
{
    class Program
    {
        static void Main()
        {
            BigInteger MaxValue = 10000000000000000000;
            MaxValue *= MaxValue;
            MaxValue *= MaxValue;
            MaxValue *= MaxValue;
            MaxValue *= MaxValue;
            Console.ReadKey();
            Console.WriteLine($"Начинаем вычисления до {MaxValue}");
            var Timer = Stopwatch.StartNew();

            AutoMorph.Run(MaxValue);

            Timer.Stop();
            Console.WriteLine($"Вычисления закончены за {Timer.Elapsed.TotalSeconds} секунд");

            foreach (var item in AutoMorph.Get())
            {
                Console.WriteLine("{0,200}\n{1,200}",item,item*item);
            }
            Console.WriteLine($"Найдено {AutoMorph.Get().Count} значений");
            Console.ReadKey();
        }
    }
}