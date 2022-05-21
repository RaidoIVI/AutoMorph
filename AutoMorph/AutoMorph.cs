using System.Numerics;

namespace AutoMorph
{
    internal static class AutoMorph
    {
        private static readonly List<BigInteger> foundNumber = new List<BigInteger>(100);
        private static BigInteger exponent;                                           //текущий порядок числа
        private static int addCount;                                                  //сколько добавлено чисел в прошлом порядке
        private static int counter;                                                   //счетчик текущего порядка

        private static void Generation(BigInteger value)
        {
            for (BigInteger i = 0; i < 10; i++)
            {
                BigInteger newValue = (i * exponent) + value;
                if (NumberTest(newValue))
                {
                    foundNumber.Add(newValue);
                    counter++;
                }
            }
        }

        private static void TestExponent()
        {
            var tmp = foundNumber.Count();

            for (int i = addCount; i > 0; i--)
            {
                Generation(foundNumber[tmp - i]);
            }

            exponent = exponent * 10;
            addCount = counter;
            counter = 0;
        }

        private static bool NumberTest(BigInteger value)
        {
            BigInteger tmp = value * value;
            tmp = tmp - ((tmp / (10 * exponent)) * (10 * exponent));
            if (tmp == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static void Run(BigInteger MaxValue)
        {
            foundNumber.Add(1);
            addCount = 1;
            exponent = 1;
            counter = 0;

            while (exponent < MaxValue)
            {
                TestExponent();
            }
        }

        internal static List<BigInteger> Get()
        {
            foundNumber.Sort();
            List<BigInteger> result = new List<BigInteger>();
            foreach (BigInteger value in foundNumber)
            {
                if (!result.Contains(value))
                {
                    result.Add(value);
                }
            }
            return result;
        }
    }
}
