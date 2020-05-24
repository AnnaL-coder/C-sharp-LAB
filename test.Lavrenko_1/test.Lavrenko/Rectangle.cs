using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Rectangle: IFigure
    {
        private double _a;
        private double _b;
        private readonly string _name;

        public Rectangle()
        { }

        public Rectangle(string name, double a, double b)
        {
            _a = a;
            _b = b;
            _name = name;
        }

        public void GetSides()
        {
            Console.WriteLine(_a.ToString() + _b.ToString());
        }
        public double Perimeter()
        {
            
            return 2*(_a+_b);
        }

        public double Area()
        {
            return _b*_a;
        }

        public string Name
        {
            get { return _name; }
            
        }

        public double A
        {
            get { return _a; }
            set
            {
                if (_a > 0)
                {
                    _a = value;
                }
                else if (_a < 0)
                {
                    _a = 0;
                }
            }
        }

        public double B
        {
            get { return _b; }
            set
            {
                if (_b > 0)
                {
                    _b = value;
                }
                else if (_b < 0)
                {
                    _b = 0;
                }
            }
        }
    }
}
