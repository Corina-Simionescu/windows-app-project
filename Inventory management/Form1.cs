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
    public partial class Form1 : Form
    {
        private List<Item> items;
        public Form1()
        {
            InitializeComponent();
            this.items = new List<Item>();
        }
        public Form1(List<Item> items)
        {
            InitializeComponent();
            this.items = items;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            addItemForm form = new addItemForm();
            form.ShowDialog();
        }

        private void buttonViewItems_Click(object sender, EventArgs e)
        {
            this.Hide();

            displayItemsForm form = new displayItemsForm(items);
            form.ShowDialog();
        }
    }
}
