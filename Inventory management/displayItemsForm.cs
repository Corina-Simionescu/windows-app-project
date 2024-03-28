using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management
{
    public partial class displayItemsForm : Form
    {
        public displayItemsForm(List<Item> items)
        {
            InitializeComponent();

            foreach (Item item in items)
            {
                textBoxDisplayItems.Text += item.ToString() + Environment.NewLine;
            }
        }
    }
}
