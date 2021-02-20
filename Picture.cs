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

        public Image GetRacingImage(int width, int height)
        {



            throw new Exception();
        }

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
            SolidBrush solidBrush = new SolidBrush(Color.White);

            //---------- Залить полотно изображения
            graphics.FillRectangle(solidBrush, dx, dy, PictureWidth, PictureHeight);

            //---------- Отрисовать линии движения ТС
            for (int i = 0; i < vehicles.Count; i++)
            {
                int y = PictureHeight / (vehicles.Count + 1) * (i + 1);
                graphics.DrawLine(pen, new Point(PictureWidth, y), new Point(0, y));
            }

            //---------- Отрисовать финишную черту
            for (int i = 0; i < 2; i++)
            {
                int width = (int)(PictureWidth * 0.05);


            }

            //---------- Отрисовать ТС на линии движения
            for (int i = 0; i < vehicles.Count; i++)
            {
                double distanceCompleted = percentageOfDistanceTraveled[i];
                Color vehicleColor = GetColor(vehicles[i].VehicleColor);
                int x = (int)(PictureWidth * distanceCompleted / 100);
                //if (x - )
                int y = (PictureHeight / (vehicles.Count + 1) * (i + 1)) - (int)(PictureHeight * 0.025);
                solidBrush.Color = vehicleColor;
                int squareSize = (int)(PictureHeight * 0.05);
                if (x > (x - squareSize))
                    x -= squareSize;
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



        ///<summary> Макет изображения </summary>
        PictureBox pictureBox = new PictureBox();

        ///<summary> Ширина макета </summary>
        int pictureBoxSize;

        ///<summary> Переменная движения фигуры по оси X </summary>
        int dx;

        ///<summary> Переменная движения фигуры по оси Y </summary>
        int dy;

        public void DrawFigure(int newSize, PictureBox newPictureBox)
        {
            pictureBoxSize = newSize;
            pictureBox = newPictureBox;

            dx = (pictureBoxSize / 4 + pictureBoxSize / 8);
            dy = 0;

            Show(dx, dy);
        }

        public void Show(int dx, int dy) //Метод отрисовывает фигуру, делая отрисовку по заданным координатам
        {
            Graphics graphics = Graphics.FromImage(pictureBox.Image);
            Pen pen = new Pen(Color.Black) { Width = 2 };

            DrawSquere(); // Вызов метода рисования квадрат и его рамок
            void DrawSquere()
            {
                SolidBrush solidBrush = new SolidBrush(Color.Blue);
                int x = dx; //Начальная точка по оси X
                int y = dy; //Начальная точка рисования по оси Y
                int wigth = pictureBoxSize / 4; //Ширина квадрата
                int height = pictureBoxSize / 4; //Длина квадрата
                graphics.FillRectangle(solidBrush, x, y, wigth, height); //Метод отрисовки квадрата
                graphics.DrawLine(pen, x, y, x + wigth, y); //Отрисовка верхней линии квадрата
                graphics.DrawLine(pen, x + wigth, y, x + wigth, y + height); //Отрисовка правой линии квадрата
                graphics.DrawLine(pen, x + wigth, y + height, x, y + height); //Отрисовка нижней линии квадрата
                graphics.DrawLine(pen, x, y + height, x, y); //Отрисовка левой линии квадрата
            }

            DrawRhombus(); //Вызов метода рисования ромба и его рамок
            void DrawRhombus()
            {
                SolidBrush solidBrush = new SolidBrush(Color.White);
                int x = dx + (pictureBoxSize / 8); //Начальная точка ромба по оси X
                int y = dy + (0); //Начальная точка по оси Y
                int sizeOfSide = pictureBoxSize / 8; //Размер стороны ромба
                PointF point1 = new PointF() { X = x, Y = y, };
                PointF point2 = new PointF() { X = point1.X + sizeOfSide, Y = point1.Y + sizeOfSide };
                PointF point3 = new PointF() { X = point2.X - sizeOfSide, Y = point2.Y + sizeOfSide };
                PointF point4 = new PointF() { X = point3.X - sizeOfSide, Y = point3.Y - sizeOfSide };
                PointF point5 = point1;
                PointF[] pointsArray = new PointF[] { point1, point2, point3, point4, point5 }; //Массив точек, по которым рисуется ромб
                graphics.FillPolygon(solidBrush, pointsArray); //Залить ромб по массиву точке
                graphics.DrawLines(pen, pointsArray); //Нарисовать рамку ромба по массиву точек
            }

            DrawEllipse(); //Вызов метода рисования окружности и её рамок
            void DrawEllipse()
            {
                SolidBrush solidBrush = new SolidBrush(Color.Red);
                int x = dx + (pictureBoxSize / 27); //Левая точка рисования круга по оси X
                int y = dy + ((pictureBoxSize / 4) / 7); //Верхняя точка рисования круга по оси Y
                int rectangleSize = Convert.ToInt32(Math.Sqrt(Math.Pow(pictureBoxSize / 4, 2) / 2)); //Диаме окружности круга
                Rectangle rectangle = new Rectangle() { Height = rectangleSize, Width = rectangleSize, X = x, Y = y }; //Класс круга
                graphics.FillEllipse(solidBrush, rectangle); //Заливка окружности по классу круга
                graphics.DrawEllipse(pen, rectangle); //Обводка окружности рамкой по классу круга
            }

            pictureBox.Refresh();
        }

        public void Hide()
        {
            Graphics graphics = Graphics.FromImage(pictureBox.Image);
            SolidBrush solidBrush = new SolidBrush(pictureBox.BackColor);
            graphics.FillRectangle(solidBrush, 0, 0, pictureBoxSize, pictureBoxSize);
        }

        public void Move()
        {
            if (dx > 0 && dy == 0) { dx = dx - 1; Hide(); Show(dx, dy); return; } //Движение влево от точки старта
            else if (dy < pictureBoxSize - (pictureBoxSize / 4) && dx != pictureBoxSize - (pictureBoxSize / 4)) { dy++; Hide(); Show(dx, dy); return; } //Движения вниз
            else if (dx < pictureBoxSize - (pictureBoxSize / 4)) { dx++; Hide(); Show(dx, dy); return; } //Движение вправо
            else if (dy < pictureBoxSize && dy > 0) { dy--; Hide(); Show(dx, dy); return; } //Движение вверх
            else if (dx != (pictureBoxSize / 4 + pictureBoxSize / 8)) { dx--; Hide(); Show(dx, dy); return; }//Движение влево к точке старта
        }

    }
}

