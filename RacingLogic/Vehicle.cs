using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestTask.RacingLogic.Colors;

namespace TestTask.RacingLogic
{
    /// <summary> Класс транспортного средства, учавствующего в гонке </summary>
    class Vehicle
    {
        public Vehicle(VehicleType vehicleType, int vehicleSpeed, double wheelPunctureProbability, ColorEnumeration venicleColor, string additionalParameter)
        {
            TypeOfVehicle = vehicleType;
            VehicleSpeed = vehicleSpeed;
            LuckRate = wheelPunctureProbability;
            VehicleColor = venicleColor;
            VehicleColorName = venicleColor.ToString();
            AdditionalParameter = additionalParameter;
        }

        /// <summary> Тип транспортного средства </summary>
        public VehicleType TypeOfVehicle { get; set; }

        /// <summary> Типы транспортных средства </summary>
        public enum VehicleType
        {
            /// <summary> Грузовик </summary>
            Truck,
            /// <summary> Легковой автомобиль </summary>
            PassengerCar,
            /// <summary> Мотоцикл </summary>
            Motorcycle
        }

        /// <summary> Скорость транспортного средства </summary>
        public int VehicleSpeed { get; set; }

        /// <summary> Вероятность прокола колеса, в диапозоне от 0 до 1 </summary>
        public double LuckRate
        {
            get => _luckRate;
            set => _luckRate = value > 1 || value < 0
                ? throw new Exception("Коэффициент удачи должен быть вещественным числом в диапозоне от 0 до 1")
                : value;
        }
        private double _luckRate;

        public ColorEnumeration VehicleColor { get; set; }

        public string VehicleColorName { get; set; }

        public string AdditionalParameter { get; set; }

        public void SetDistanceToFinish(double distance) => _remainingDistanceToFinish = distance;
        public double RemainingDistanceToFinish
        {
            get => _remainingDistanceToFinish;
            set => _remainingDistanceToFinish = value < 0 ? 0 : value;
        }
        private double _remainingDistanceToFinish;

        /// <summary> Количество проклов шины </summary>
        public int CountOfTirePunctures { get; set; }

        /// <summary> Количество едениц времени, затраченных на гонку </summary>
        public double CountOfTimeUnits { get; set; }

        public void SetDowntime(double time) 
        {
            if (time <= 0)
            {
                _downtime = 0;
                CountOfTirePunctures++;
            }
            else
                _downtime = time;
        }
        public double GetDowntime() => _downtime;
        //public int Downtime
        //{
        //    get => _downtime;
        //    set => _downtime = _downtime - value < 0 ? 0 : _downtime - value;
        //}
        private double _downtime;

        public override string ToString()
        {
            string vehicleType = "";
            string additionalParemeter = "";
            if (TypeOfVehicle == VehicleType.Truck)
            {
                vehicleType = "Грузовик";
                additionalParemeter = " Везет " + AdditionalParameter + " единиц веса";
            }
            else if (TypeOfVehicle == VehicleType.PassengerCar)
            {
                vehicleType = "Легковое авто";
                additionalParemeter = "Везет " + AdditionalParameter + " пассажира(ов)";
            }
            else if (TypeOfVehicle == VehicleType.Motorcycle)
            {
                vehicleType = "Мотоцикл";
                additionalParemeter = Convert.ToBoolean(AdditionalParameter) ? " Имеет коляску" : " Не имеет коляски";
            }

            return vehicleType + ", " + VehicleColorName + ", " + VehicleSpeed + " / " + LuckRate + "," + additionalParemeter;
        }
    }
}
