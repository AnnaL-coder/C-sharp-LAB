using System;

namespace ConsoleApp3.1
{
    public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Массивы которые будут отсортированны");
        double[] z = new double[12];
        double[] q = new double[12];
        Random sluch = new Random();
        double amin = 1, amax = 20;
        double bmin = 10, bmax = 50;
        for (int i = 0; i < 12; i++)
        {
            z[i] = amin + (amax - amin) * sluch.NextDouble();
            q[i] = bmin + (bmax - bmin) * sluch.NextDouble();
            Console.WriteLine("z[{0}]={1} q[{2}]={3}", i, z[i], i, q[i]);
        }
        Array.Sort(z, q);
        Console.WriteLine(" ");
        Console.WriteLine("Отсортированные массивы относительно массива z");
        for (int i = 0; i < 12; i++)
        {

            Console.WriteLine("z[{0}]={1} q[{2}]={3}", i, z[i], i, q[i]);
        }
        Array.Sort(q, z);
        Console.WriteLine(" ");
        Console.WriteLine("Отсортированные массивы относительно массива q");
        for (int i = 0; i < 12; i++)
        {

            Console.WriteLine(" q[{0}]={1} z[{2}]={3}", i, q[i], i, z[i]);
        }
    }
}
}
