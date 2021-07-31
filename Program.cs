using System;

namespace source
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("Enter the color of the car : ");
            string color = Console.ReadLine();
            car.setColor(color);
            Console.WriteLine("Enter the Model of the car : ");
            string model = Console.ReadLine();
            car.setModel(model);
            Console.WriteLine("Enter the Year of the car : ");
            int year = int.Parse(Console.ReadLine());
            car.setYear(year);
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Car() { }
        internal void setModel(string model)
        {
            this.Model = model;
            Console.WriteLine("Model of this car is : " + this.Model);
        }

        internal void setColor(string color)
        {
            this.Color = color;
            Console.WriteLine("Color of this car is : " + this.Color);
        }

        internal void setYear(int year)
        {
            this.Year = year;
            Console.WriteLine("Year of this car is : " + this.Year);
        }
    }
}
