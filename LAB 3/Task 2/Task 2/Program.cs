using System;

namespace ConsoleApp3._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Массивы которые будут отсортированны");
            Console.WriteLine("Enter k:");
            int k = int.Parse(Console.ReadLine());
            double[] z = new double[k];
            double[] q = new double[k];
            Random sluch = new Random();
            double amin = 1, amax = 20;
            double bmin = 10, bmax = 50;
            for (int i = 0; i < k; i++)
            {
                z[i] = amin + (amax - amin) * sluch.NextDouble();
                q[i] = bmin + (bmax - bmin) * sluch.NextDouble();
                Console.WriteLine("z[{0}]={1} q[{2}]={3}", i, z[i], i, q[i]);
            }
            Array.Sort(z, q);
            Console.WriteLine(" ");
            Console.WriteLine("Отсортированные массивы относительно массива z");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("z[{0}]={1} q[{2}]={3}", i, z[i], i, q[i]);
            }
        }
    }
}
