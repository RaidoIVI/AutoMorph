namespace AutoMorph
{
    internal static class AutoMorph
    {
        private static readonly List<ulong> foundNumber = new List<ulong>(100);
        private static ulong exponent;                                                //текущий порядок числа
        private static int addCount;                                                  //сколько добавлено чисел в прошлом порядке
        private static int counter;                                                   //счетчик текущего порядка

        private static void Generation(ulong value)
        {
            for (ulong i = 0; i < 10; i++)
            {
                ulong newValue = (i * exponent) + value;
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
                    Generation(foundNumber[tmp-i]);
                }

            exponent = exponent*10;
            addCount = counter;
            counter = 0;
        }

        private static bool NumberTest(ulong value)
        {

            ulong tmp = value * value;
            tmp = tmp - ((tmp / (10*exponent)) * (10*exponent));
            if (tmp == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static void Run()
        {
            foundNumber.Add(1);
            addCount = 1;
            exponent = 1;
            counter = 0;

            while (exponent < 100000000000)
            {
                TestExponent();
            }
        }

        internal static List<ulong> Get()
        {
            foundNumber.Sort();
            List<ulong> result = new List<ulong>();
            foreach (ulong value in foundNumber)
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
