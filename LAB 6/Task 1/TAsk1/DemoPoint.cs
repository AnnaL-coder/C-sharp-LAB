using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class DemoPoint : IDemo
    {

        protected int x;
        protected int y;
        public DemoPoint(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public void Show()
        {
            Console.WriteLine($"Точка на плоскости: ({x}, {y})");
        }

        public double Length()
        {

            return Math.Sqrt(x * x + y * y);
        }

        public int X => x;

        public int Y => y;

        public int this[int i]
        {
            get
            {
                if (i == 0) return x;
                if (i == 1) return y;
                throw new Exception("недопустимое значение индекса");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else throw new Exception("недопустимое значение индекса");
            }
        }
    }

}
