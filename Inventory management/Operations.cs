using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    public static class Operations
    {
        public static void addItem(List<Item> items, Item item)
        {
            items.Add(item);
        }

        public static void removeItem(List<Item> items, Item item)
        {
            items.Remove(item);
        }

        public static void printItems(List<Item> items)
        {
            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
