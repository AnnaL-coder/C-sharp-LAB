using System;
using System.Collections.Generic;
using System.IO;

namespace lab7
{
    class Program
    {
        private const string FilePath = "C:\\Users\\Home\\Desktop\\2 курс 2 семестр\\C# labs\\LAB 7\\Task 2\\Task 2\\File.txt";

        public static void Main(string[] args)
        {

            var queue = new Queue<string>();
            {
                if (!File.Exists(FilePath))
                {
                    Console.WriteLine("File File.txt does not exist");
                    Environment.Exit(1);
                }
            }

            string[] person = File.ReadAllLines(FilePath);
            foreach (string element in person)
            {
                if (int.Parse(element.Split()[3]) < 40)
                {
                    queue.Enqueue(element);
                }
            }
            foreach (string element in person)
            {
                if (int.Parse(element.Split()[3]) >= 40)
                {
                    queue.Enqueue(element);
                }
            }
            Console.WriteLine("File:");
            while (queue.Count != 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
