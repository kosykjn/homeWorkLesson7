using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();

            #region Properties
            adress.Country = "Ukraine";
            Console.WriteLine(adress.Country);
            adress.City = "Kyiv";
            Console.WriteLine(adress.City);
            adress.Street = "Shevchenka";
            Console.WriteLine(adress.Street);
            adress.House = 57;
            Console.WriteLine(adress.House);
            adress.Apartment = 12;
            Console.WriteLine(adress.Apartment);
            adress.Index = "08452";
            Console.WriteLine(adress.Index);
            #endregion

            #region AutoProperties
            //adress.country = "Ukraine";
            //adress.DisplayCountry();

            //adress.city = "Kyiv";
            //adress.DisplayCity();

            //adress.street = "Shevchenko";
            //adress.DisplayStreet();

            //adress.house = 45;
            //adress.DisplayHouse();

            //adress.apartment = 4;
            //adress.DisplayApartment();

            //adress.index = 4;
            //adress.DisplayIndex();
            #endregion

            Console.ReadKey();
        }
    }
    class Adress
    {
        #region Properties
        private string country = string.Empty;
        private string city = string.Empty;
        private string street = string.Empty;
        private int house;
        private int apartment;
        private string index = string.Empty;
       
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        public int House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }
        }
        public int Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }
        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }
        }
        #endregion

        #region AutoProperties
        //public string country { get; set; }
        //public void DisplayCountry()
        //{
        //    Console.WriteLine(country);
        //}

        //public string city { get; set; }
        //public void DisplayCity()
        //{
        //    Console.WriteLine(city);
        //}

        //public string street { get; set; }
        //public void DisplayStreet()
        //{
        //    Console.WriteLine(street);
        //}

        //public int house { get; set; }
        //public void DisplayHouse()
        //{
        //    Console.WriteLine(house);
        //}

        //public int apartment { get; set; }
        //public void DisplayApartment()
        //{
        //    Console.WriteLine(apartment);
        //}

        //public int index { get; set; }
        //public void DisplayIndex()
        //{
        //    Console.WriteLine(index);
        //}
        #endregion

    }
}
