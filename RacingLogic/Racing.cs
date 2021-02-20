using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static TestTask.RacingLogic.Service;

namespace TestTask.RacingLogic
{
    static class Racing
    {
        /// <summary> Транспортные средства, учавствующие в гонке </summary>
        public static BindingList<Vehicle> vehicles = new BindingList<Vehicle>();

        public class RaceCondition
        {
            public delegate void ConditionIsChanged();

            /// <summary> Сообщает о том, что в состоянии гонки произошли изменения </summary>
            public event ConditionIsChanged RaceConditionIsChanged;

            /// <summary> Запускает моделирование гонки </summary>
            public void StartRace()
            {
                //---------- Для каждого ТС из имеющихся
                foreach (Vehicle vehicle in vehicles)
                {
                    //---------- Установить расстояние до финиша
                    vehicle.SetDistanceToFinish(Parameters.DistanceUnits);
                    //---------- Установить количество проколов шин
                    vehicle.CountOfTirePunctures = 0;
                    //---------- Установить количество прошедшего времени гонки
                    vehicle.CountOfTimeUnits = 0;
                }
                while (EveryoneAtFinishLine == false)
                {
                    CalculateMomentOfRace();
                    RaceConditionIsChanged();
                }
                RaceConditionIsChanged();
            }

            /// <summary> Возвращает состояние гонки </summary>
            public List<int> Condition
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            /// <summary> Показывает, все ли ТС достигли финиша </summary>
            private bool EveryoneAtFinishLine => vehicles.Where(v => v.RemainingDistanceToFinish > 0).Count() == 0;
        }

        /// <summary> Расчитать момент времени гонки для каждого ТС </summary>
        private static void CalculateMomentOfRace()
        {

            /* Пусть размер круга - 10000 едениц расстояния;
             * Пусть 100 едениц скорости движения ТС проходятся примерно за 100 миллесекунд при коэффициенте ускорения 1;
             * Пусть время замены одного проколотого колеса занимает от 100 до 200 едениц времени; 
            */ 

            // Расчитать, какое расстояние преодолело каждое ТС за текущий момент гонки
            for (int i = 0; i < vehicles.Count; i++)
            {
                Vehicle vehicle = vehicles[i];

                //---------- Если ТС уже на финише - пропустить расчет расстояния
                if (vehicle.RemainingDistanceToFinish == 0)
                    continue;

                //---------- Расчет того, какую долю времени ТС потратит на езду
                // Доля времени будет меньше 1, если в текущем моменте гонки ушло время на замену колеса,
                // а если ТС не успело заменить колесо на текущий момент времени, то доля времени будет 0
                double remainingTimeRatio = 1;
                if (vehicle.GetDowntime() > 0)
                {
                    remainingTimeRatio = 1 - (vehicle.GetDowntime() / 100);
                    vehicle.SetDowntime(vehicle.GetDowntime() - 100);
                }

                //---------- Если в текущем моменте времени у ТС есть время для движения
                if (remainingTimeRatio > 0)
                {
                    //---------- Посчитать, сколько оно проедет за текущий момент времени, учитывая затраты на смену колеса
                    vehicle.RemainingDistanceToFinish -= vehicle.VehicleSpeed * remainingTimeRatio;
                    //---------- Увеличить счетчик времени, затраченного на гонку с учетом затрат времени на смену колеса
                    vehicle.CountOfTimeUnits += vehicle.VehicleSpeed * remainingTimeRatio;
                }

                //---------- Если колесо ТС не проколото
                if (vehicle.GetDowntime() == 0)
                {
                    //---------- Расчитать вероятность прокола колеса на каждом моменте времени
                    double chance = (1 - vehicle.LuckRate) / (Parameters.DistanceUnits / vehicle.VehicleSpeed);
                    //---------- Расчет того, будет ли пробито колесо ТС в текущий момент времени гонки
                    bool puncture = GetRandomRealValue() < chance;
                    //---------- Если колесо было пробито
                    if (puncture)
                        //---------- Сгенерировать время, которое уйдет на смену колеса ТС
                        vehicle.SetDowntime(GetRandomIntegerValue(
                            Parameters.MinimumTimeToChangeWheel, Parameters.MaximumTimeToChangeWheel));
                }
            }

            // Коэффициент замедления, по отношению к реальному времени
            double percent = (double)Parameters.SimulationSpeed / 100;
            // Произвести задержку, в зависимости от соотношения времени гонки к реальному времени
            int delay = Convert.ToInt32(100 + (100 * percent));
            Thread.Sleep(delay);
        }

    }
}
