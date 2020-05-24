using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    class Program
    {        
        static void Main(string[] args)
        {
            

            List<Items> items = new List<Items>()
            {
                new Items("item1", 5, 5, 10),
                new Items("item2", 3, 15, 30),
                new Items("item3", 4, 65, 20),
                new Items("item4", 1, 57, 90)
            };

            Sorter.SortItems("price",items);
            Console.WriteLine("Sorted by price: ");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Price);
            }
            Console.WriteLine("Sorted by count: ");
            Sorter.SortItems("count", items);
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Count);
            }
            Console.WriteLine("Sorted by Expiration Days: ");
            Sorter.SortItems("expirationDay", items);
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].ExpirationDays);
            }
        }

    }
}
