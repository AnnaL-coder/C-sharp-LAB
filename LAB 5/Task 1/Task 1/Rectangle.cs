using System;

namespace lab5
{
    class Rectangle : Figure
    {
        public int a;
        public int b;

        public override void Show()
        {
            Console.WriteLine("a={0}, b={1}", a, b);
        }
        public override double Param()
        {
            return a + b;
        }

        public override double Plosh()
        {
            return a * b;
        }
    }
}
