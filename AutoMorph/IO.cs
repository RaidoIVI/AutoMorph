using System.Diagnostics;
using System.Numerics;

namespace AutoMorph
{
    internal static class IO
    {
        #region input

        public static int GetInt(string value)
        {
            SendConsole(value);
            return GetInt();
        }
        public static int GetInt()
        {
            int result;
            string data;
            do
            {
                data = Console.ReadLine();
                if (!Int32.TryParse(data, out _))
                {
                    SendConsole("Некорректный ввод");
                }
            }
            while (!Int32.TryParse(data, out result));
            return result;
        }
        #endregion

        #region output

        public static void SendConsole(string value)
        {
            System.Console.Write(value);
        }

        public static void SendToFile(string fileName, List<BigInteger> value, Stopwatch timer, int iteration)
        {
            if (fileName == null || fileName == string.Empty)
            {
                fileName = "output.txt";
            }
            using StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine($"Вычисления до 10^{iteration} заняли {timer.Elapsed} секунд");
            sw.WriteLine($"Найдено {value.Count} значений");
            for (int i = 0; i < value.Count; i++)
            {
                sw.WriteLine($"{i + 1}. {value[i]} {value[i] * value[i]}");
            }
        }

        #endregion
    }
}
