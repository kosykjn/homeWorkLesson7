using System;

namespace homeWorkLesson7_5
{
    class Figure
    {
        public Point[] Points { get; set; }

        public Figure(Point a, Point b, Point c)
        {
            Points = new Point[] { a, b, c };
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            Points = new Point[] { a, b, c, d };
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0.0;

            for (int i = 0; i < Points.Length; i++)
            {
                perimeter += Distance(i, i == Points.Length - 1 ? 0 : i + 1);
            }

            return perimeter;
        }

        public double Distance(int index1, int index2)
        {
            return Distance(Points[index1], Points[index2]);
        }

        public static double Distance(Point a, Point b)
        {
            return Math.Sqrt((b.X - a.X) * (b.X - a.X) + (b.Y - a.Y) * (b.Y - a.Y));
        }
    }
}
