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
        public Vehicle(VehicleType vehicleType, int vehicleSpeed, double wheelPunctureProbability, ColorEnumeration venicleColor)
        {
            TypeOfVehicle = vehicleType;
            VehicleSpeed = vehicleSpeed;
            WheelPunctureProbability = wheelPunctureProbability;
            VehicleColor = venicleColor;
            VehicleColorName = venicleColor.ToString();
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
        public double WheelPunctureProbability
        {
            get => _wheelPunctureProbability;
            set
            {
                if (value > 1 || value < 0)
                    throw new Exception("Вероятность прокола колеса должна быть вещественным числом в диапозоне от 0 до 1");
                _wheelPunctureProbability = value;
            }
        }
        private double _wheelPunctureProbability;

        public ColorEnumeration VehicleColor { get; set; }

        public string VehicleColorName { get; set; }

        public double RemainingDistanceToFinish
        {
            get => _remainingDistanceToFinish;
            set => _remainingDistanceToFinish = _remainingDistanceToFinish - value < 0 
                ? 0 
                : _remainingDistanceToFinish - value;
        }
        private double _remainingDistanceToFinish;

        public double Downtime { get; set; }

        public override string ToString()
        {
            string vehicleType = string.Empty;
            if (TypeOfVehicle == VehicleType.Truck)
                vehicleType = "Грузовик";
            else if (TypeOfVehicle == VehicleType.PassengerCar)
                vehicleType = "Легковое авто";
            else if (TypeOfVehicle == VehicleType.Motorcycle)
                vehicleType = "Мотоцикл";
            return vehicleType + ", " + VehicleColorName + ", " + VehicleSpeed + " / " + WheelPunctureProbability;
        }
    }
}
