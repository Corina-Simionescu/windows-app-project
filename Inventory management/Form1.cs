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
        public static List<Item> items = new List<Item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            addItemForm form = new addItemForm();
                form.ShowDialog();
        }

        private void buttonViewItems_Click(object sender, EventArgs e)
        {
            displayItemsForm form = new displayItemsForm();
            form.ShowDialog();
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            removeItemForm form = new removeItemForm();
            form.ShowDialog();
        }
    }
}
