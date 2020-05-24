using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Circle: IFigure
    {
        private double _r;
        private readonly string _name;

        public Circle()
        { }

        public Circle (string name, double r)
        {
            _r = r;
            _name = name;
        }

        public void GetSides()
        {
            Console.WriteLine(_r.ToString());
        }
        public double Perimeter()
        {

            return 2*Math.PI*_r;
        }

        public double Area()
        {
            return Math.PI*_r*_r;
        }

        public string Name
        {
            get { return _name; }
            
        }


        public double R
        {
            get { return _r; }
            set
            {
                if (_r > 0)
                {
                    _r = value;
                }
                else if (_r < 0)
                {
                    _r = 0;
                }
            }
        }


       
    }
}
