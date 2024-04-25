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
    [Serializable]
    public partial class FormMainMenu : Form
    {
        public static List<Item> items = new List<Item>();
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormAddItem form = new FormAddItem();
                form.ShowDialog();
        }

        private void buttonViewItems_Click(object sender, EventArgs e)
        {
            FormDisplayItems form = new FormDisplayItems();
            form.ShowDialog();
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRemoveItem form = new FormRemoveItem();
            form.ShowDialog();
        }
    }
}
