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
    public partial class addItemForm : Form
    {
        List<Item> items = new List<Item>();

        public addItemForm()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                string name = textBoxName.Text;
                string description = textBoxDescription.Text;
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                int price = Convert.ToInt32(textBoxPrice.Text);

                Item item = new Item(id, name, description, quantity, price);

                MessageBox.Show(item.ToString());

                items.Add(item);
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

        private void buttonGoBackToForm1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
