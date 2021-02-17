using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.RasingLogic
{
    /// <summary> Класс транспортного средства, учавствующего в гонке </summary>
    class Vehicle
    {
        public Vehicle(VehicleType vehicleType, int vehicleSpeed, double wheelPunctureProbability)
        {
            TypeOfVehicle = vehicleType;
            VehicleSpeed = vehicleSpeed;
            WheelPunctureProbability = wheelPunctureProbability;
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

        public string 

        ///// <summary> Цвет автомобиля </summary>
        //struct VehicleColor
        //{
        //    /// <summary> Название цвета </summary>
        //    public string ColorName { get; set; }

        //    /// <summary> Цвет </summary>
        //    public Color Color { get; set; }
        //}
    }
}
