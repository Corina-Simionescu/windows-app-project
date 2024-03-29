using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    public class Operations
    {
        public Operations()
        {
        }

        public void addItem(List<Item> items, Item item)
        {
            items.Add(item);
        }

        public void removeItem(List<Item> items, Item item)
        {
            items.Remove(item);
        }

        public void printItems(List<Item> items)
        {
            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
