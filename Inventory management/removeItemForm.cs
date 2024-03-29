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
        public removeItemForm()
        {
            InitializeComponent();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                errorProviderRemoveItemForm.SetError(textBoxId, "Please enter an id");
            }
            else
            {
                errorProviderRemoveItemForm.Clear();

                try
                {
                    int id = Convert.ToInt32(textBoxId.Text);

                    if (!Form1.items.Any())
                    {
                        MessageBox.Show("No item to remove because the inventory is empty");
                    }
                    else
                    {
                        int itemWasFound = 0;
                        foreach (Item item in Form1.items)
                        {
                            if (id == item.Id)
                            {
                                MessageBox.Show("The following item was removed from inventory: " + Environment.NewLine + item.ToString());

                                Operations.removeItem(Form1.items, item);

                                itemWasFound++;
                                break;
                            }
                        }

                        if (itemWasFound != 1)
                        {
                            MessageBox.Show("No item in inventory with the id: " + id);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    textBoxId.Clear();
                }
            }
        }

        private void buttonGoBackToForm1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= '0' &&e.KeyChar<='9'||e.KeyChar==(char)8)
            {
                e.Handled = false;
                errorProviderRemoveItemForm.Clear();
            }
            else
            {
                e.Handled = true;
                errorProviderRemoveItemForm.SetError(textBoxId, "Only digits allowed");
            }
        }
    }
}
