using System;

namespace Task1
{
   public class Round
    {
        private double radius, x, y;

        public Round(double x, double y, double radius)
        {            
            this.x = Math.Abs(x);
            this.y = Math.Abs(y);
            this.radius = Math.Abs(radius);
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = Math.Abs(value);
            }
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = Math.Abs(value);
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = Math.Abs(value);
            }
        }

        public double Lenght
        {
            get
            {
                return 2 * Math.PI * radius;
            }
        }
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }
    }
}
