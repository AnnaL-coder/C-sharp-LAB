using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            Console.WriteLine(square.ToString());
            Console.WriteLine($"P = {square.Perimeter()}");
            Console.WriteLine($"S = {square.Area()}");

            var squar = new List<Square>
        {
           square, new Square(33), new Square(11), new Square(99)
        };
            squar.Sort();

            Console.WriteLine("All sorted squares:");
            foreach (Square item in squar)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
