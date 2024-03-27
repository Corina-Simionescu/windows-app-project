using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    internal class Operations
    {
        private List<Item> items;

        public Operations()
        {
            items = new List<Item>();
        }

        public Operations(List<Item> items) 
        {
            this.items = items;
        }

        public void addItem(Item item)
        {
            items.Add(item);
        }

        public void removeItem(Item item)
        {
            items.Remove(item);
        }

        public void printItems()
        {
            foreach(Item item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
