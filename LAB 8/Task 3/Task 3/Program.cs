using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        private delegate double Del(double r);
        private static Calculations _calculations = new Calculations();
        static void Main(string[] args)
        {
            var r = 0.0;
            Console.WriteLine("Input R of circle");
            r = double.Parse(Console.ReadLine());
            if (r < 0) throw new ArgumentException();

            Del del = _calculations.Volume;
            Console.WriteLine($"Volume of circle is calculated. Result = {del(r)}");
            del = _calculations.Square;
            Console.WriteLine($"Square of circle is calculated. Result = {del(r)}");
            del = _calculations.Length;
            Console.WriteLine($"Lenght of circle is calculated. Result = {del(r)}");
        }
    }

}
