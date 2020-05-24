using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    class Sorter
    {
        public delegate List<Items> UseSort(List<Items> items);
        public static Dictionary<string, UseSort> dictionary = new Dictionary<string, UseSort> {
            { "name", NameSort },
            { "price", PriceSort },
            { "count", CountSort },
            { "expirationDay", ExpDaySort },
        };

        public static List<Items> SortItems(string crit, List<Items> items)
        {
            return dictionary[crit](items);
        }

        public static List<Items> PriceSort(List<Items> items)
        {
            Items t;
            for (int p = 0; p < items.Count() - 2; p++)
            {
                for (int i = 0; i <= items.Count() - 2; i++)
                {
                    if (items[i].Price > items[i + 1].Price)
                    {
                        t = items[i + 1];
                        items[i + 1] = items[i];
                        items[i] = t;
                    }
                }
            }
            return items;
        }

        public static List<Items> CountSort(List<Items> items)
        {
            Items t;
            for (int p = 0; p < items.Count() - 2; p++)
            {
                for (int i = 0; i <= items.Count() - 2; i++)
                {
                    if (items[i].Count > items[i + 1].Count)
                    {
                        t = items[i + 1];
                        items[i + 1] = items[i];
                        items[i] = t;
                    }
                }
            }
            return items;
        }

        public static List<Items> ExpDaySort(List<Items> items)
        {
            Items t;
            for (int p = 0; p < items.Count() - 2; p++)
            {
                for (int i = 0; i <= items.Count() - 2; i++)
                {
                    if (items[i].ExpirationDays > items[i + 1].ExpirationDays)
                    {
                        t = items[i + 1];
                        items[i + 1] = items[i];
                        items[i] = t;
                    }
                }
            }
            return items;
        }

        public static List<Items> NameSort(List<Items> items)
        {
            return null;
        }
    }
}
