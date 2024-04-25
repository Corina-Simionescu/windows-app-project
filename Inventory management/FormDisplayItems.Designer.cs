namespace Inventory_management
{
    partial class FormDisplayItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripForFileOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripForFileOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnName,
            this.columnDescription,
            this.columnQuantity,
            this.columnPrice});
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(46, 45);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(1300, 792);
            this.listViewItems.TabIndex = 0;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            // 
            // columnName
            // 
            this.columnName.Text = "NAME";
            this.columnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnName.Width = 120;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "DESCRIPTION";
            this.columnDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDescription.Width = 200;
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "QUANTITY";
            this.columnQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnQuantity.Width = 120;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "PRICE";
            this.columnPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnPrice.Width = 120;
            // 
            // contextMenuStripForFileOperations
            // 
            this.contextMenuStripForFileOperations.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripForFileOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.contextMenuStripForFileOperations.Name = "contextMenuStripForFileOperations";
            this.contextMenuStripForFileOperations.Size = new System.Drawing.Size(301, 124);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.serializeToolStripMenuItem.Text = "Save to file";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.deserializeToolStripMenuItem.Text = "Upload from file";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // FormDisplayItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 864);
            this.ContextMenuStrip = this.contextMenuStripForFileOperations;
            this.Controls.Add(this.listViewItems);
            this.Name = "FormDisplayItems";
            this.Text = "displayItemsForm";
            this.contextMenuStripForFileOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForFileOperations;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
    }
}