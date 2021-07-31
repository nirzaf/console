using System;

namespace source
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car car = new Car();
            // Console.WriteLine("Enter the color of the car : ");
            // string color = Console.ReadLine();
            // car.setColor(color);
            // Console.WriteLine("Enter the Model of the car : ");
            // string model = Console.ReadLine();
            // car.setModel(model);
            // Console.WriteLine("Enter the Year of the car : ");
            // int year = int.Parse(Console.ReadLine());
            // car.setYear(year);
        }
    }

    public class AddNumbers
    {
         public double number1 { get; set; }
         public double number2 { get; set; }

         public double AddFunction(double number1, double number2)
         {
             this.number1 = number1;
             this.number2 = number2;
             return this.number1 + this.number2;
         }

    }

    
    public class SubstractNumbers : AddNumbers
    {
         public double SubstractFunction(double number1, double number2)
         {
             this.number1 = number1;
             this.number2 = number2;
             return this.number1 - this.number2;
         }
    }

    public class DevideNumbers : SubstractNumbers
    {
        public double DevideFunction(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            return this.number1 / this.number2;
        }
    }

     public class MultiplyNumbers : DevideNumbers
    {
        public double MultiplyFunction(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
            return this.number1 * this.number2;
        }
    }
    public class Calculator : MultiplyNumbers
    {
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
