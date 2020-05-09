using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_3
{
    class Square : IMeasurable, ICircumcircleIncircle, IComparable<Square>
    {
        private readonly double a;

        public double Perimeter()
        {
            return 4 * a;
        }
        public double Area()
        {
            return a * a;
        }
        public double R
        {
            get => a / Math.Sqrt(2);
        }

        public double r
        {
            get => a / 2;
        }
        public int CompareTo(Square a)
        {
            if (a == null) return -1;
            return Perimeter().CompareTo(a.Perimeter());
        }

        public Square(double a)
        {
            this.a = a;
        }

        public double Sidea
        {
            get => a;
        }

        public override string ToString()
        {
            return $"Info about square : {nameof(a)}: {a}, {nameof(r)}: {r}, {nameof(R)}: {R}";
        }
    }

}
