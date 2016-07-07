using System;

namespace Tasks
{
   public class Round
    {
        private double _radius;

        public Round(double x, double y, double radius)
        {           
            if (IsValid(radius))
            {
                X = x;
                Y = y;
                _radius = radius;
            }
        }

        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (IsValid(value))
                {
                    _radius = value;
                }              
            }
        }
        public double X { get; set; }

       public double Y { get; set; }

        // Валидация радиуса круга.
       private static bool IsValid(double r)
        {
            
            if (r >= 0)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Радиус должен быть >=0!");
            }
        }

        public double Lenght => 2 * Math.PI * _radius;

       public double Area => Math.PI * Math.Pow(_radius, 2);
    }
}
