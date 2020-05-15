using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_5
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input size of matrix");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            var matrix = new double[a, b];

            var operations = new List<Operations>()
            {
                Operations.CreateMatrix,
                Operations.PrintElements,
                Operations.PositiveElements,
                Operations.Multiply,
                Operations.PrintElements

            };

            Operation.Actions(matrix, operations);
           
        }
    }
}

