using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5._2
{
    class Books
    {
        private string fio;
        private string name;
        private string code;
        private int year;
        private int pages;
        private string type;

        public Books()//конструктор без параметров
        { }

        public Books(string fio, string name, string code, int year,
            int pages, string type)
        {
            this.fio = fio;
            this.name = name;
            this.code = code;
            this.year = year;
            this.pages = pages;
            this.type = type;

        }

        public string Fio => fio;
        public string Name => name;
        public int Year => year;
        public int Pages => pages;
        public string Type => type;
        public string Code
        {
            get => code;
            set => code = value;
        }

        bool EqByFio(Books books)
        {
            return this.fio.Equals(books.fio);
        }
        bool EqByName(Books books)
        {
            return this.name.Equals(books.name);
        }
        bool EqByYear(Books books)
        {
            return this.year.Equals(books.year);
        }
        bool EqBypages(Books books)
        {
            return this.pages.Equals(books.pages);
        }
        bool EqBytype(Books books)
        {
            return this.type.Equals(books.type);
        }
        bool EqByCode(Books books)
        {
            return this.code.Equals(books.code);
        }

        public override string ToString()
        {
            return $"\n{nameof(fio)}: {fio}, {nameof(name)}: {name}, {nameof(code)}:" +
             $" {code}, {nameof(year)}: {year}, {nameof(pages)}: {pages}, {nameof(type)}: {type}";
        }
    }
}
