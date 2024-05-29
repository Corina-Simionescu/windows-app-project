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
    public partial class FormAddItem : Form
    {
        private List<Item> items = new List<Item>();
        public FormAddItem(List<Item> items)
        {
            InitializeComponent();
            this.items = items;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                errorProviderFormAddItem.SetError(textBoxId, "Please enter an id");
            }
            else if (textBoxName.Text == "")
            {
                errorProviderFormAddItem.SetError(textBoxName, "Please enter a name");
            }
            else if (textBoxDescription.Text == "")
            {
                errorProviderFormAddItem.SetError(textBoxDescription, "Please enter a description");
            }
            else if (textBoxQuantity.Text == "")
            {
                errorProviderFormAddItem.SetError(textBoxQuantity, "Please enter a quantity");
            }
            else if (textBoxPrice.Text == "")
            {
                errorProviderFormAddItem.SetError(textBoxPrice, "Please enter a price");
            }
            else
            {
                errorProviderFormAddItem.Clear();

                try
                {
                    int id = Convert.ToInt32(textBoxId.Text);
                    string name = textBoxName.Text;
                    string description = textBoxDescription.Text;
                    int quantity = Convert.ToInt32(textBoxQuantity.Text);
                    int price = Convert.ToInt32(textBoxPrice.Text);

                    Item item = new Item(id, name, description, quantity, price);

                    Operations.addItem(items, item);

                    MessageBox.Show(item.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    textBoxId.Clear();
                    textBoxName.Clear();
                    textBoxDescription.Clear();
                    textBoxQuantity.Clear();
                    textBoxPrice.Clear();
                }
            }
        }

        private void textBoxIdQuantityPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
            {
                e.Handled = false;
                errorProviderFormAddItem.Clear();
            }
            else
            {
                e.Handled = true;

                if(sender == textBoxId)
                {
                    errorProviderFormAddItem.SetError(textBoxId, "Only digits allowed");
                }
                else if(sender == textBoxQuantity)
                {
                    errorProviderFormAddItem.SetError(textBoxQuantity, "Only digits allowed");
                }
                else if(sender == textBoxPrice)
                {
                    errorProviderFormAddItem.SetError(textBoxPrice, "Only digits allowed");
                }
            }
        }

        private void textBoxIdQuantityPrice_Leave(object sender, EventArgs e)
        {
            errorProviderFormAddItem.Clear();
        }
    }
}
