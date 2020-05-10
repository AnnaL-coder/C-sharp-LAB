using System;
using System.Collections.Generic;
using System.IO;

namespace lab7
{
    class Program
    {
        private const string FilePath = "C:\\Users\\Home\\Desktop\\2 курс 2 семестр\\C# labs\\LAB 7\\Task 1\\Task 1\\TextFile1.txt";

        public static void Main(string[] args)
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("File TextFile1.txt does not exist");
                Environment.Exit(1);
            }

            string input = File.ReadAllText(FilePath);
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("File TextFile1.txt is empty");
                Environment.Exit(1);
            }

            var stack = new Stack<int>();
            foreach (char element in input)
            {
                if (element == '(') stack.Push(1);
                if (element == ')' && stack.Count != 0) stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Number of opened brackets equals number of closed brackets");
            }
            else
            {
                Console.WriteLine("Number of opened brackets doesn`t equal number of closed brackets");
            }
        }
    }
}
