using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Triangle
            Point a1 = new Point("A", 10.0, 10.0);
            Point b1 = new Point("B", 20.0, 20.0);
            Point c1 = new Point("C", 20.0, 10.0);

            Figure triangle = new Figure(a1, b1, c1);
            double trianglePerimeter = triangle.CalculatePerimeter();

            Console.WriteLine($"Периметр треугольника: {trianglePerimeter : 0.##}");

            //Rectagle
            Point a2 = new Point("A", 10.0, 10.0);
            Point b2 = new Point("C", 20.0, 10.0);
            Point c2 = new Point("B", 20.0, 20.0);
            Point d2 = new Point("D", 10.0, 20.0);

            Figure rectangle = new Figure(a2, b2, c2, d2);
            double rectanglePerimeter = rectangle.CalculatePerimeter();

            Console.WriteLine($"Периметр прямоугольника: {rectanglePerimeter : 0.##}");

            Console.ReadKey();
        }
    }
}
