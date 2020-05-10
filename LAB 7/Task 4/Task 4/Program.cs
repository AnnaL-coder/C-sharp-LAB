using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task4
{
    public class Program
    {
        private const string FilePath = "C:\\Users\\Home\\Desktop\\2 курс 2 семестр\\C# labs\\LAB 7\\Task 4\\Task 4\\TextFile1.txt";

        private static void Exit(string text)
        {
            Console.WriteLine(text);
            Environment.Exit(1);
        }

        public static void Main(string[] args)
        {
            if (!File.Exists(FilePath))
            {
                Exit("File TextFile1.txt does not exist");
            }
            var stack = new Stack<string>();

            string[] numbers = File.ReadAllText(FilePath).Split();
            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            Console.WriteLine("Reversed numbers");
            while (stack.Count != 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
        }
    }
}
