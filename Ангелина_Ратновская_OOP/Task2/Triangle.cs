using  System;
namespace Tasks
{
    
    public class Triangle
    {
        
        private double _a, _b, _c;
        public Triangle(double a, double b, double c)
        {    
            if (IsValid(a, b, c))
            {
                _a = a;
                _b = b;
                _c = c;
            }                            
        }
        
        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                if (IsValid(value, _b, _c))
              {
                    _a = value;
              }           
            }
        }
        public double B
        {
            get
            {
                return _b;
            }
            set
            {                
                if (IsValid(_a, value, _c))
                {
                    _b = value;
                }
            }
        }
        public double C
        {
            get
            {
                return _c;
            }
            set
            {
                if (IsValid(_a, _b, value))
                {
                    _c = value;
                }
            }
        }
        bool IsValid(double a, double b, double c)
        {
            if ((a < b + c) && (b < a + c) && (c < a + b) && (a > 0) && (b > 0) && (c > 0))
            {
                return true;
            }
            else
            {
                throw new System.ArgumentException("Каждая сторона треугольника должна быть меньше суммы двух других его сторон и больше 0");
            }
        }
        public double GetArea()
        {
            
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt((p * (p - _a)*(p - _b)*(p - _c)));
        }
        public double GetPerimeter()
        {                       
            return _a + _b + _c;            
        }   
     }
}
