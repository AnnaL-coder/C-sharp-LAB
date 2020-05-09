using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class DemoShape : DemoPoint, IDemo
    {
        protected int z;
        public DemoShape(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        // реалізація методу, оголошеного в інтерфейсі, з приховуванням однойменного

        public new void Show()
        {
            Console.WriteLine("точка в пространстве: ({0}, {1}, {2})", x, y,
            z);
        }
        // реалізація методу, оголошеного в інтерфейсі, з приховуванням однойменного

        public new double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        // реалізація індексатора, оголошеного в інтерфейсі, з приховуванням
        // однойменного індексатора з базового класу
        public new int this[int i]
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;

                else if (i == 2) return z;
                else throw new Exception("недопустимое значение индекса");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else if (i == 2) z = value;
                else throw new Exception("недопустимое значение индекса");
            }
        }
    }

}
