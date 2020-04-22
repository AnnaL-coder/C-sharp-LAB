using System;

namespace lab5
{
    class Circle : Figure
    {
        public int r;

        public override void Show()
        {
            Console.WriteLine("r={0}", r);
        }
        public override double Param()
        {
            return 2 * Math.PI * r;
        }

        public override double Plosh()
        {
            return Math.PI * r * r;
        }
    }
}
