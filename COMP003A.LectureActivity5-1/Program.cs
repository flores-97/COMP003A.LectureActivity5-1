namespace COMP003A.LectureActivity5_1
{
    internal class Car
    {
        //Fields
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
        }

        public void DisplayInfo()
        {
            Car myCar = new Car("Honda", "Civic", 2021);
            Console.WriteLine($"Car: {Year} {Make} {Model}");
        }

        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Civic", 2021);
            myCar.DisplayInfo();

            myCar.Make = "Toyota";//creates new car object
            myCar.Model = "Corrolla";//car's make
            myCar.Year = 2020;//car's year
            myCar.DisplayInfo();
        }
    }
}
