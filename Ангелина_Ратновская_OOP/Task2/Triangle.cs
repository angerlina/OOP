using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Triangle
    {
        private double a, b, c;
        
        public Triangle(double a, double b, double c)
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                this.a = Math.Abs(a);
                this.b = Math.Abs(b);
                this.c = Math.Abs(c);
            }

            else
            {
                throw new System.ArgumentException("Каждая сторона треугольника должна быть меньше суммы двух других его сторон");
            }

        }

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = Math.Abs(value);
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                b = Math.Abs(value);
            }
        }
        public double C
        {
            get
            {
                return c;
            }
            set
            {
                c = Math.Abs(value);
            }
        }

        public double Perimeter
        {
            get
            {
                return a + b + c;
            }
        }
        public double Area
        {
            get
            {
                return ((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2 - c));
            }
        }
    }
}
