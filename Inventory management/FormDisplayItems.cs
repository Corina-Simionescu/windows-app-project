using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Inventory_management
{
    public partial class FormDisplayItems : Form
    {
        int[] quantities = new int[30];
        int numberOfElements = 0;
        bool quantityExists = false;

        Graphics graphics;
        const int edge = 10;

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

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.Create(saveFileDialog.FileName))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, FormMainMenu.items);
                }
            }
        }

        private void uploadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.OpenRead(openFileDialog.FileName))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FormMainMenu.items = (List<Item>)binaryFormatter.Deserialize(fileStream);

                    DisplayItems();
                }
            }
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Item item in FormMainMenu.items) 
            {
                quantities[numberOfElements] = Convert.ToInt32(item.Quantity);
                numberOfElements++;
                quantityExists = true;
            }
            listViewItems.Visible = false;
            panelStatistics.Visible = true;
            panelStatistics.Invalidate();
        }

        private void panelStatistics_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;

            if(quantityExists==true)
            {
                Rectangle rec = new Rectangle(panelStatistics.ClientRectangle.X + edge,
                    panelStatistics.ClientRectangle.Y + 2 * edge,
                    panelStatistics.ClientRectangle.Width - 2 * edge,
                    panelStatistics.ClientRectangle.Height - 3 * edge);
                Pen pen = new Pen(Color.Red, 3);
                graphics.DrawRectangle(pen, rec);

                double width = rec.Width / numberOfElements / 2;
                double distance = (rec.Width - numberOfElements * width) / (numberOfElements + 1);
                double vMax = quantities.Max();

                Brush br = new SolidBrush(Color.Black);

                Rectangle[] rectangles = new Rectangle[numberOfElements];
                for (int i = 0; i < numberOfElements; i++) 
                {
                    rectangles[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distance + i * width),
                        (int)(rec.Location.Y + rec.Height - rec.Height / vMax * quantities[i]),
                        (int)width,
                        (int)(rec.Height / vMax * quantities[i]));
                
                    graphics.DrawString(quantities[i].ToString(), this.Font,
                        br, new Point((int)(rectangles[i].Location.X + width / 2),
                        (int)(rectangles[i].Location.Y - this.Font.Height)));
                }

                graphics.FillRectangles(br, rectangles);
                for (int i = 0; i < numberOfElements - 1; i++)
                    graphics.DrawLine(pen, new Point((int)(rectangles[i].Location.X + width / 2),
                        (int)(rectangles[i].Location.Y)),
                        new Point((int)(rectangles[i + 1].Location.X + width / 2),
                        (int)(rectangles[i + 1].Location.Y)));
            }
        }

        private void printDocument_print(object sender, PrintPageEventArgs e)
        {
            graphics = e.Graphics;
            if (quantityExists == true)
            {
                Rectangle rec = new Rectangle(e.PageBounds.X + edge,
                    e.PageBounds.Y + 2 * edge,
                    e.PageBounds.Width - 2 * edge,
                    e.PageBounds.Height - 3 * edge);
                Pen pen = new Pen(Color.Red, 3);
                graphics.DrawRectangle(pen, rec);

                double latime = rec.Width / numberOfElements / 2;
                double distanta = (rec.Width - numberOfElements * latime) / (numberOfElements + 1);
                double vMax = quantities.Max();

                Brush br = new SolidBrush(Color.Black);

                Rectangle[] recs = new Rectangle[numberOfElements];
                for (int i = 0; i < numberOfElements; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - rec.Height / vMax * quantities[i]),
                        (int)latime,
                        (int)(rec.Height / vMax * quantities[i]));
                
                    graphics.DrawString(quantities[i].ToString(), this.Font,
                        br, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y - this.Font.Height)));
                }
                graphics.FillRectangles(br, recs);
                for (int i = 0; i < numberOfElements - 1; i++)
                    graphics.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2),
                        (int)(recs[i + 1].Location.Y)));
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_print);
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = printDocument;
            dialog.ShowDialog();
        }
    }
}
