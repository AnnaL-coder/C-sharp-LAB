using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_5
{   
    public enum Operations
    {
        CreateMatrix,
        PrintElements,
        PositiveElements,
        Multiply
    }
    public class Operation
    {
        private static readonly Random _random = new Random();
        public static readonly Dictionary<Operations, Action<double[,]>> _operations = new Dictionary<Operations, Action<double[,]>>()
            {                                     
            {Operations.CreateMatrix, CreateMatrix},
            {Operations.PrintElements, PrintElements},
            {Operations.Multiply, MultiplyMatrix3},
            {Operations.PositiveElements, PositiveElements},
            };
     
        public static void PerformOperation(Operations operation, double[,] matrix)
        {
                _operations[operation](matrix);  
        }
        public static void Actions(double[,] matrix, List<Operations> operations)
        {
            foreach (Operations operation in operations)
            {
                PerformOperation(operation, matrix);
            }
        }
       public static void CreateMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] =  -5+_random.NextDouble()*10;
        }

        public static void PrintElements(double[,] matrix)
        {
            Console.WriteLine("Printing all elements of matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void MultiplyMatrix3(double[,] matrix)
        {
            Console.WriteLine("Multiply elements of matrix by 3:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *=3;
                }
            }
        }
        public static void PositiveElements(double[,] matrix)
        {
            Console.WriteLine("Showing all positive Elements:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0) Console.Write($"{matrix[i, j]} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n");
        }
    }
}

