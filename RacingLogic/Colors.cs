using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.RacingLogic
{
    static class Colors
    {
        /// <summary> Варианты цветов </summary>
        public enum ColorEnumeration
        {
            /// <summary> Красный </summary>
            Red,
            /// <summary> Розовый </summary>
            Pink,
            /// <summary> Оранжевый </summary>
            Orange,
            /// <summary> Желтый </summary>
            Yellow,
            /// <summary> Лавандовый </summary>
            Lavender,
            /// <summary> Бордовый </summary>
            Maroon,
            /// <summary> Лаймовый </summary>
            Lime,
            /// <summary> Зеленый </summary>
            Green,
            /// <summary> Оливковый </summary>
            Olive,
            /// <summary> Синий </summary>
            Blue,
            /// <summary> Светло-синий </summary>
            LightBlue,
            /// <summary> Серый </summary>
            Gray
        }

        /// <summary> Получить цвет по его названию </summary>
        public static Color GetColor(ColorEnumeration colorEnumeration) => _colorValues[colorEnumeration];

        /// <summary> Полчить список возможных цветов автомобиля </summary>
        public static Dictionary<ColorEnumeration, Color> GetVehicleColors() => _colorValues;

        /// <summary> Словарь цветов и их названий </summary>
        private static Dictionary<ColorEnumeration, Color> _colorValues = new Dictionary<ColorEnumeration, Color> {
            { ColorEnumeration.Red, Color.FromArgb(255, 0, 0) }, { ColorEnumeration.Pink, Color.FromArgb(255, 192, 203) },
            { ColorEnumeration.Orange, Color.FromArgb(255, 165, 0) }, { ColorEnumeration.Yellow, Color.FromArgb(255, 255, 0) },
            { ColorEnumeration.Lavender, Color.FromArgb(230, 230, 250) }, { ColorEnumeration.Maroon, Color.FromArgb(128, 0, 0) },
            { ColorEnumeration.Lime, Color.FromArgb(0, 255, 0) }, { ColorEnumeration.Green, Color.FromArgb(0, 128, 0) },
            { ColorEnumeration.Olive, Color.FromArgb(128, 128, 0) }, { ColorEnumeration.Blue, Color.FromArgb(0, 0, 255) },
            { ColorEnumeration.LightBlue, Color.FromArgb(173, 216, 230) }, { ColorEnumeration.Gray, Color.FromArgb(128, 128, 128) }
        };
    }
}
