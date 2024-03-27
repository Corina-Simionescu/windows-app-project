using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item i1 = new Item();
            Item i2 = new Item(1, "a", "b", 1, 10);
        }
    }
}
