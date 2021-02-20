using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TestTask.RacingLogic.Racing;
using static TestTask.RacingLogic.Colors;
using static TestTask.RacingLogic.Service;

namespace TestTask
{
    public class Picture
    {
        public void DrawPicture(PictureBox pictureBox)
        {
            PictureWidth = pictureBox.Width;
            PictureHeight = pictureBox.Height;
            percentageOfDistanceTraveled = 
                (from vehicle in vehicles select (100 - (vehicle.RemainingDistanceToFinish / Parameters.DistanceUnits * 100))).ToList();
            pictureBox.Image = new Bitmap(PictureWidth, PictureHeight);

            //---------- Инструменты отрисовки
            Graphics graphics = Graphics.FromImage(pictureBox.Image);
            Pen pen = new Pen(Color.Black) { Width = (int)(PictureHeight * 0.01) };
            SolidBrush solidBrush = new SolidBrush(Color.NavajoWhite);

            //---------- Залить полотно изображения
            graphics.FillRectangle(solidBrush, 0, 0, PictureWidth, PictureHeight);

            //---------- Отрисовать линии движения ТС
            for (int i = 0; i < vehicles.Count; i++)
            {
                int y = PictureHeight / (vehicles.Count + 1) * (i + 1);
                graphics.DrawLine(pen, new Point(PictureWidth, y), new Point(0, y));
            }

            //---------- Отрисовать финишную черту
            for (double y = 0; y < PictureHeight; y += PictureHeight * 0.025)
            {
                solidBrush.Color = solidBrush.Color == Color.White ? Color.Black : Color.White;
                graphics.FillRectangle(solidBrush, (float)(PictureWidth - (PictureHeight * 0.025)),
                    (float)y, (float)(PictureHeight * 0.025), (float)(PictureHeight * 0.025));
            }
            solidBrush.Color = Color.White;
            for (double y = 0; y < PictureHeight; y += PictureHeight * 0.025)
            {
                solidBrush.Color = solidBrush.Color == Color.Black ? Color.White : Color.Black;
                graphics.FillRectangle(solidBrush, (float)(PictureWidth - (PictureHeight * 0.05)),
                    (float)y, (float)(PictureHeight * 0.025), (float)(PictureHeight * 0.025));
            }

            //---------- Отрисовать ТС на линии движения
            for (int i = 0; i < vehicles.Count; i++)
            {
                double distanceCompleted = percentageOfDistanceTraveled[i];
                Color vehicleColor = GetColor(vehicles[i].VehicleColor);
                int x = (int)(PictureWidth * distanceCompleted / 100);
                int y = (PictureHeight / (vehicles.Count + 1) * (i + 1)) - (int)(PictureHeight * 0.025);
                solidBrush.Color = vehicleColor;
                int squareSize = (int)(PictureHeight * 0.05);
                if (x > (x - squareSize))
                    x -= squareSize;
                if (x < 0)
                    x = 0;
                graphics.FillRectangle(solidBrush, x, y, squareSize, squareSize);
            }


            pictureBox.Refresh();
        }

        /// <summary> Ширина полотна отрисовки изображения </summary>
        private int PictureWidth { get; set; }

        /// <summary> Длина полотна отрисовки изображения </summary>
        private int PictureHeight { get; set; }

        /// <summary> Список, содержащий пройденную ТС дистанцию в процентном соотношении </summary>
        private List<double> percentageOfDistanceTraveled;
    }
}

