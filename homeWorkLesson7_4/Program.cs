using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(5, 3, 6);

            triangle.ShowInfo();

            Console.ReadKey();
        }
    }
}
