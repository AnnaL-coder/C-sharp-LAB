using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    interface IDemo
    {
        void Show();
        double Length();
        int X { get; }
        int Y { get; }
        int this[int i] { get; set; }

    }
}
