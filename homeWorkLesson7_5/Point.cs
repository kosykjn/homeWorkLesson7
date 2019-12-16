using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_5
{
    class Point
    {
        public string Name { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public Point(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }
}
