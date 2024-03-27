using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Item item1 = new Item();
            //Item item2 = new Item(2, "item2", "bbb", 2, 20);
            //Item item3 = new Item(3, "item3", "asdd", 300, 110);
            //Item item4 = new Item(4, "item4", "aaaaa", 1000, 1);

            //List<Item> items = new List<Item>();

            //items.Add(item1);
            //items.Add(item2);
            //items.Add(item3);

            //Operations operations = new Operations(items);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
