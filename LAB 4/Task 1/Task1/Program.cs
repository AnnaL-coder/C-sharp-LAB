using System;

namespace lab4
{
    class A
    {
        public int a;
        public int b;

        public double c
        {
            get { if (a > b) return a - b; else return b - a; }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Enter a");
            a.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            a.b = int.Parse(Console.ReadLine());
            var k = a.c;
            Console.WriteLine($"Result ={k}");
        }
    }
}
