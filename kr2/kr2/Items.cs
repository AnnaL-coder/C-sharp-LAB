using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kr2
{
    class Items
    {
        private string _name;
        private double _price;
        private double _count;
        private int _expirationDays;
        public Items()
        {

        }
        public Items(string name, double price, double count, int expirationDays)
        {
            _name = name;
            _price = price;
            _count = count;
            _expirationDays = expirationDays;
    }

        public double Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public int ExpirationDays
        {
            get { return _expirationDays; }
            set { _expirationDays = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
