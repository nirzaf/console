using System;

namespace source
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator");
            Calculator calc = new Calculator();
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double addedValue = calc.AddFunction(num1, num2);
            double subtractedValue = calc.SubstractFunction(num1, num2);
            double multipliedValue = calc.MultiplyFunction(num1, num2);
            double dividedValue = calc.DivideFunction(num1, num2);
            Console.WriteLine(" Added Value : " + addedValue.ToString());
            Console.WriteLine(" Substracted Value : " + subtractedValue.ToString());
            Console.WriteLine(" Multiplied Value : " + multipliedValue.ToString());
            Console.WriteLine(" Divided Value : " + dividedValue.ToString());
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
        public double DivideFunction(double number1, double number2)
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
}
