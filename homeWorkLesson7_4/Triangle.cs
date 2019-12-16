using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_4
{
    class Triangle
    {
        private double a;

        private double b;

        private double c;

        public double A
        {
            get 
            {
                return a;
            }
            set
            {
                a = value;
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
                b = value;
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
                c = value;
            }
        }

        public double CalculatePerimeter()
        {
            return a + b + c;
        }
        public double CalculateArea()
        {
            double pHalf = CalculatePerimeter() / 2.0;
            return Math.Sqrt(pHalf * (pHalf - a) * (pHalf - b) * (pHalf - c));
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Периметр треугольника: {CalculatePerimeter(): 0.##}. Площадь треугольника: {CalculateArea(): 0.##}");
        }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }
}
