using System;
using System.Collections.Generic;

namespace lab5._2
{
    class Program
    {

        static List<Books> books = new List<Books>();

        private static void SearchbyCode(string code)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books found");
                return;
            }

            Books book = books.Find(Book => code.Equals(Book.Code));
            Console.WriteLine($"Book with code: {code}" + book.ToString());
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Finding by code");
            SearchbyCode("M-141");
            books.Add(new Books("Petrov", "Poems", "I-123", 1820, 300, "Poem"));
            books.Add(new Books("Cambridge", "English", "E-001", 2020, 120, "Studying"));
            books.Add(new Books("Schevchenko", "Kobzar", "I-123", 1820, 300, "Poem"));
            books.Add(new Books("Ivanov", "Autos", "M-141", 2018, 120, "Magazine"));
            books.Add(new Books("SumDU", "Math", "S-99", 2001, 270, "Studying"));

            Console.WriteLine("Finding by code");
            SearchbyCode("M-141");
            Console.WriteLine("Finding by code");
            SearchbyCode("S-99");


        }



    }
}
