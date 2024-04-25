using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_management
{
    public partial class FormDisplayItems : Form
    {
        public FormDisplayItems()
        {
            InitializeComponent();
            DisplayItems();
        }

        public void DisplayItems()
        {
            listViewItems.Items.Clear();
            foreach (Item item in FormMainMenu.items)
            {
                ListViewItem listViewItem = new ListViewItem(item.Id.ToString());
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Description);
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());

                listViewItems.Items.Add(listViewItem);
            }
        }

        private void serializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(FileStream fileStream = File.Create(saveFileDialog.FileName))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, FormMainMenu.items);
                }
            }
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.OpenRead(openFileDialog.FileName))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FormMainMenu.items = (List<Item>) binaryFormatter.Deserialize(fileStream);
                    
                    DisplayItems();
                }
            }
        }
    }
}
