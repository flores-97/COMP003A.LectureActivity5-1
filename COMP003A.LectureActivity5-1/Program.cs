namespace COMP003A.LectureActivity5_1
{
    internal class Car
    {
        //Fields
        public string Make;
        public string Model;
        public int Year;

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
            //Car myCar = new Car();
            //myCar.Make = "Toyota";//creates new car object
            //myCar.Model = "Supra";//car's make
            //myCar.Year = 2024;//car's year
            Car myCar = new Car("Honda", "Civic", 2021);
            
            myCar.DisplayInfo();
        }
    }
}
