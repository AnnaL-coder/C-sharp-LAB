using System;

namespace lab5
{
    class Triangle : Figure
    {
        public int a;
        public int b;
        public int c;

        public override void Show()
        {
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
        }
        public override double Param()
        {
            return a + b + c;
        }

        public override double Plosh()
        {
            return Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
        }
    }
}
