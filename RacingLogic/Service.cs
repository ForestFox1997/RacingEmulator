using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.RacingLogic
{
    static class Service
    {
        static private Random _random = new Random();

        public static int GetRandomIntegerValue(int minValue, int maxValue) => _random.Next(minValue, maxValue + 1);

        public static int GetRandomIntegerValue() => _random.Next();

        public static double GetRandomRealValue() => _random.NextDouble();









    }
}
