/*
 Auhtor: Victor Flores 
Course: COMP-003A
Faculty Jonathon Cruz
Purpose: Demonstrate the creation and usage of classes in C#*/using System.Runtime.InteropServices;

namespace COMP003A.LectureActivity5_1
{
    internal class Car
    {
        //Fields
        private static int carCount = 0;
        public string make;
        public string model;
        public int year;

        //properties
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
   
        public int Year
        {
            get { return year; }
            set { if (value >= 1886) year = value; }
        }

        ///<summary>
        ///Display car information
        ///</summary>
        ///<param name="make"></param>
        ///<param name="model"></param>
        ///<param name="year"></param>

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            carCount++;
        }
        /// <summary>
        /// static propery to get the car count
        /// </summary>
        public static void DisplayCarCount()
        {
            Console.WriteLine($"Total cars creates: {carCount}");
        }

        public void DisplayInfo()
        {
           // Car myCar = new Car("Honda", "Civic", 2021);
            Console.WriteLine($"Car: {Year} {Make} {Model}");
        }


        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic", 2021);//creates new car object using constructor
            myCar.DisplayInfo();//display info

            myCar.Make = "Toyota";//change make of car
            myCar.Model = "Corrolla";//change model of car 
            myCar.Year = 2020;//car's year
            myCar.DisplayInfo();//display car info

            Car myCar2 = new Car("Ford", "Mustang", 2020);//create car onject 2
            Car myCar3 = new Car("Chevrolet", "Camaro", 2021);//create car object 3
            Car.DisplayCarCount();
        }
    }
}
