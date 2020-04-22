using System;

namespace task4
{
    public class Sklad
    {
        private string name;
        private string Datetocome;
        private double price;
        private int size;


        public Sklad()
        {
        }

        public void Inputonfo()
        {
            string name;
            string Datetocome;
            double price;
            int size;
            Console.WriteLine("\n Enter name");
            name = Console.ReadLine();
            Console.WriteLine("\n Enter datetocome");
            Datetocome = Console.ReadLine();
            Console.WriteLine("\n Enter price");
            price = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter size");
            size = int.Parse(Console.ReadLine());

            this.name = name;
            this.Datetocome = Datetocome;
            this.price = price;
            this.size = size;
        }

        public void Getinfo(Sklad info)
        {
            Console.WriteLine("name: {0}, datetocome: {1}, price: {2}, size: {3}", name, Datetocome, price, size);
        }

        public void FindByDatetocome(Sklad info, string datetocome)
        {
            if (info.Datetocome == datetocome)
            {
                Getinfo(info);
            }
        }

        public void FindBySize(Sklad info, int size)
        {
            if (info.size == size)
                Getinfo(info);
        }

        public void FindByPrice(Sklad info, double price)
        {
            if (info.price == price)
                Getinfo(info);
        }

    }
}

