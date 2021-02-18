using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.RacingLogic
{
    static class Racing
    {
        /// <summary> Транспортные средства, учавствующие в гонке </summary>
        public static BindingList<Vehicle> vehicles = new BindingList<Vehicle>();

        class RaceCondition
        {
            public delegate void ConditionIsChanged();

            /// <summary> Сообщает о том, что в состоянии гонки произошли изменения </summary>
            public event ConditionIsChanged RaceConditionIsChanged;

            /// <summary> Запускает моделирование гонки </summary>
            public void StartRace()
            {
                foreach (Vehicle vehicle in vehicles)
                    vehicle.RemainingDistanceToFinish = 10000;
                while (EveryoneAtFinishLine == false)
                {
                    CalculateMomentOfRace(1);
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
            private bool EveryoneAtFinishLine => vehicles.Where(v => v.RemainingDistanceToFinish > 0).Count() > 1;
        }


        /// <summary> Расчитать момент времени гонки для каждого ТС </summary>
        /// <param name="speedRatio"> Коэффициент скорость расчета по отношению к реальному времени </param>
        public static async void CalculateMomentOfRace(double speedRatio)
        {
            int delay = Convert.ToInt32(speedRatio * 100);
            await Task.Delay(delay);

            /* Пусть размер круга - 10000 едениц расстояния;
             * Пусть 100 едениц скорости движения ТС проходятся примерно за 100 миллесекунд при коэффициенте ускорения 1;
             * Пусть время замены одного проколотого колеса занимает от 100 до 200 едениц времени; 
            */ 

            //Расчитать, сколько
            for (int i = 0; i < vehicles.Count; i++)
            {
                Vehicle vehicle = vehicles[i];
                if (vehicle.RemainingDistanceToFinish == 0)
                    continue;
                //---------- Расчет того, какую долю времени ТС потратит на езду
                double remainingTimeRatio;
                if (vehicle.Downtime > 0)
                    remainingTimeRatio = 1 - (vehicle.Downtime / (vehicle.Downtime - 100));
                else
                    remainingTimeRatio = 1;
                //---------- 
                if (remainingTimeRatio > 0)
                    vehicle.RemainingDistanceToFinish -= vehicle.VehicleSpeed * remainingTimeRatio;
                if (vehicle.Downtime == 0)
                {
                    double chance = vehicle.WheelPunctureProbability / 10000 / vehicle.VehicleSpeed;
                    bool puncture = Service.GetRandomRealValue() < chance;
                    if (puncture)
                        vehicle.Downtime = Service.GetRandomIntegerValue(100, 200);
                }

            }

            





            //------------------ Расчет того, сколько проехало ТС
            //Vehicle vehicle = new Vehicle(Vehicle.VehicleType.Motorcycle, 100, 0.05, Colors.ColorEnumeration.Orange);
                //------------------ Расчет того, какую долю времени авто потратит на движение, затратив время на смену колеса
            //double remainingTimeRatio;
            //if (vehicle.Downtime > 0)
            //    remainingTimeRatio = 1 - (vehicle.Downtime / (vehicle.Downtime - 100));
            //else
            //    remainingTimeRatio = 1;
                //------------------ Расчет того, какую долю времени авто потратит на движение, затратив время на смену колеса
            //double remainingWay = 10000;
            //double timeToChangeWheel = 100;
            //if (vehicle.RemainingDistanceToFinish > 0 && remainingTimeRatio > 0)
            //    vehicle.RemainingDistanceToFinish -= vehicle.VehicleSpeed;
            //------------------ Расчет того, сколько проехало ТС


            //------------------ Расчет шанса прокола колеса ТС
            //double chance = vehicle.WheelPunctureProbability / 10000 / vehicle.VehicleSpeed; //Шанс прокола колеса при каждом расчете возможности прокола колеса
            //bool flag = Service.GetRandomRealValue() < chance; //Результат расчета шанса на прокол колеса
            //------------------ Расчет шанса прокола колеса ТС



        }


    }
}
