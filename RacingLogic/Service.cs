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

        /// <summary> Параметры моделирования </summary>
        public static class Parameters
        {
            /// <summary> Количество едениц расстояния </summary>
            public static int DistanceUnits { get; set; }

            /// <summary> Минимальное количество едениц времени для замены колеса </summary>
            public static int MinimumTimeToChangeWheel { get; set; }

            /// <summary> Минимальное количество едениц времени для замены колеса </summary>
            public static int MaximumTimeToChangeWheel { get; set; }

            /// <summary> Скорость моделирования по отношению к реальному времени </summary>
            public static int SimulationSpeed { get; set; }

        }

    }
}
