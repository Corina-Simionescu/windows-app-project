using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_management
{
    public class Item
    {
        private int id;
        private string name;
        private string description;
        private int quantity;
        private int price;

        public Item()
        {
            id = 0;
            name = string.Empty;
            description = string.Empty;
            quantity = 0;
            price = 0;
        }

        public Item(int id, string name, string description, int quantity, int price)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.quantity = quantity;
            this.price = price;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return "id: " + id + ", name: " + name + ", description: " + description +
                ", quantity: " + quantity + ", price: " + price;
        }
    }
}
