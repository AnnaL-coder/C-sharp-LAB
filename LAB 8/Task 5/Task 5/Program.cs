using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_5
{
    public class Greeting
    {
        private delegate void Greetings();

        private static Dictionary<int, Greetings> _dictionary = new Dictionary<int, Greetings>()
        {
            {3, GoodNight },
            {9, GoodMorning},
            {16, GoodDay},
            {21, GoodEvening},
            {24, GoodNight}

        };
        public static void GetGreetings()
        {
            Greetings greetings = _dictionary.First(item => DateTime.Now.Hour <= item.Key).Value;
            greetings();
        }

        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning!");
        }
        private static void GoodDay()
        {
            Console.WriteLine("Good Day!");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening!");
        }
        private static void GoodNight()
        {
            Console.WriteLine("Good Night!");
        }
    }

    public class Program
    {
        public delegate double UseOperation(double a, double b);
        public static Dictionary<string, UseOperation> _operations = new Dictionary<string, UseOperation>()
        {
            {"+", Plus},
            {"-", Minus},
            {"/", Divide} ,
            {"*", Multiply}
        };
        public static void Main(string[] args)
        {
            Greeting.GetGreetings();
            Console.WriteLine("Input the first and second number for operation");
            var firstNumb = double.Parse(Console.ReadLine());
            var secondNumb = double.Parse(Console.ReadLine());
            Console.WriteLine("Input the operation you need: +,-,/,*");
            var operation = Console.ReadLine();
            double result = Operation(operation, firstNumb, secondNumb);
            Console.WriteLine($"The result = {result}");
        }

        public static double Operation(string keyOperation, double a, double b)
        {
            return _operations[keyOperation](a, b);
        }
        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

    }
}

