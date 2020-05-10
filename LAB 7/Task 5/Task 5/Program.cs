using System;
using System.Collections;
using System.IO;

namespace Task5
{
    public class Program
    {
        private static readonly Random _random = new Random();
        private static void PrintAll(ArrayList arrayList)
        {
            foreach (int item in arrayList)
            {
                Console.Write($"{item} ");
            }
            if (arrayList.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            var numbers = new ArrayList();
            for (var i = 0; i < 2080; i++)
            {
                numbers.Add(_random.Next(100, 400));
            }

            numbers.Sort();
            Console.WriteLine("Sorted list:");
            PrintAll(numbers);

            numbers.Insert(1, 2);
            var newValue = _random.Next(0, 10 + 1000);
            Console.WriteLine(numbers.Contains(newValue)
                ? $"Index of newValue = {numbers.IndexOf(newValue)}"
                : "New value doesn`t exist in this list");

            newValue = _random.Next(0, numbers.Count - 1);
            Console.WriteLine($"Delete element with value = {newValue}");
            numbers.Remove(newValue);
            PrintAll(numbers);

            Console.WriteLine("Delete all elements");
            numbers.Clear();
            PrintAll(numbers);
        }
    }
}
