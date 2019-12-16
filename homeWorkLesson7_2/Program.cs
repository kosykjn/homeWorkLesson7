using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            cat.name = "Снежок";
            cat.DisplayName();

            cat.age = 3;
            cat.DisplayAge();

            cat.woolColor = "белого";
            cat.DisplayWoolColor();

            cat.eyeColor = "зеленые";
            cat.DisplayEyeColor();

            int myauCount = Convert.ToInt32(Console.ReadLine());

            cat.Myau(myauCount);

            Console.ReadKey();
        }
    }

    class Cat
    {

        public string name { get; set; }

        public void DisplayName()
        {
            Console.WriteLine($"Котенка зовут {name}");
        }

        public int age { get; set; }

        public void DisplayAge()
        {
            Console.WriteLine($"Ему {age} месяца");
        }

        public string woolColor { get; set; }

        public void DisplayWoolColor()
        {
            Console.WriteLine($"Шерсть {woolColor} цвета");
        }

        public string eyeColor { get; set; }

        public void DisplayEyeColor()
        {
            Console.WriteLine($"Глаза {eyeColor}");
        }

        public void Myau(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Мяу");
            }
        }
    }
}
