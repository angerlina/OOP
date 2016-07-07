using System;

namespace Task5
{
    public class Figure
    {
        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Figure(double x, double y, uint angle)
        {
            Angle = angle;
            X = x;
            Y = y;
        }
        public Figure()
        {
            
        }

        // Угол наклона фигуры относительна горизонтали.
        public uint Angle { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public bool Colored { get; set; }
    }
}
