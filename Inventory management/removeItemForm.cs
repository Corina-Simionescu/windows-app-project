using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management
{
    public partial class removeItemForm : Form
    {
        List<Item> items;

        public removeItemForm(List<Item> items)
        {
            InitializeComponent();

            this.items = items;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                
                if(!items.Any())
                {
                    MessageBox.Show("No item to remove because the inventory is empty");
                }
                else
                {
                    int itemWasFound = 0;
                    foreach(Item item in items)
                    {
                        if(id == item.Id)
                        {
                            Operations operation = new Operations();
                            MessageBox.Show("The following item was removed from inventory: " + Environment.NewLine);
                            MessageBox.Show(item.ToString());
                            operation.removeItem(items, item);

                            itemWasFound++;
                        }
                    }

                    if(itemWasFound != 1)
                    {
                        MessageBox.Show("No item in inventory with the id: " + id);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGoBackToForm1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
