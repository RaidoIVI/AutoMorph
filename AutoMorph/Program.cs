using System.Diagnostics;
namespace AutoMorph
{
    class Program
    {
        static void Main()
        {

            Console.ReadKey();
            Console.WriteLine($"Начинаем вычисления");
            var Timer = Stopwatch.StartNew();

            AutoMorph.Run();

            Timer.Stop();
            Console.WriteLine($"Вычисления закончены за {Timer.Elapsed.TotalSeconds} секунд");

            foreach (var item in AutoMorph.Get())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}