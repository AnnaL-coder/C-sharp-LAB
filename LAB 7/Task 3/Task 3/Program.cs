using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Task3
{
    class PersonComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x != null && y != null && x is string && y is string)
            {
                string person1 = (string)x;
                string person2 = (string)y;
                return int.Parse(person1.Split()[4]).CompareTo(int.Parse(person2.Split()[4]));
            }
            return 0;
        }
    }
    public class Program
    {
        private const string FilePath = "C:\\Users\\Home\\Desktop\\2 курс 2 семестр\\C# labs\\LAB 7\\ConsoleApp2\\ConsoleApp2\\TextFile1.txt";

        private static void Exit(string text)
        {
            Console.WriteLine(text);
            Environment.Exit(1);
        }

        public static void Main(string[] args)
        {
            if (!File.Exists(FilePath))
            {
                Exit("File TextFile1.txt doesn`t exist");
            }


            var arrayList = new ArrayList(File.ReadAllLines(FilePath));
            arrayList.Sort(new PersonComparer());
            Console.WriteLine("Sorted:");
            foreach (string item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}