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
            this.menuStripFormDisplayItems = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractDataFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItemsValuesToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadItemsValuesFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.buttonAddNewItem = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.listViewItemValue = new System.Windows.Forms.ListView();
            this.columnItemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripForFileOperations.SuspendLayout();
            this.menuStripFormDisplayItems.SuspendLayout();
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
            this.listViewItems.GridLines = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(46, 74);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(1202, 589);
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
            this.contextMenuStripForFileOperations.Size = new System.Drawing.Size(263, 80);
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.serializeToolStripMenuItem.Text = "Save to file";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.deserializeToolStripMenuItem.Text = "Upload from file";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // menuStripFormDisplayItems
            // 
            this.menuStripFormDisplayItems.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripFormDisplayItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripFormDisplayItems.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripFormDisplayItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.menuStripFormDisplayItems.Location = new System.Drawing.Point(0, 0);
            this.menuStripFormDisplayItems.Name = "menuStripFormDisplayItems";
            this.menuStripFormDisplayItems.Size = new System.Drawing.Size(2254, 42);
            this.menuStripFormDisplayItems.TabIndex = 1;
            this.menuStripFormDisplayItems.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem,
            this.extractDataFromFileToolStripMenuItem,
            this.saveItemsValuesToFileToolStripMenuItem,
            this.uploadItemsValuesFromFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(460, 44);
            this.saveToFileToolStripMenuItem.Text = "Save to file";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // extractDataFromFileToolStripMenuItem
            // 
            this.extractDataFromFileToolStripMenuItem.Name = "extractDataFromFileToolStripMenuItem";
            this.extractDataFromFileToolStripMenuItem.Size = new System.Drawing.Size(460, 44);
            this.extractDataFromFileToolStripMenuItem.Text = "Upload from file";
            this.extractDataFromFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFromFileToolStripMenuItem_Click);
            // 
            // saveItemsValuesToFileToolStripMenuItem
            // 
            this.saveItemsValuesToFileToolStripMenuItem.Name = "saveItemsValuesToFileToolStripMenuItem";
            this.saveItemsValuesToFileToolStripMenuItem.Size = new System.Drawing.Size(460, 44);
            this.saveItemsValuesToFileToolStripMenuItem.Text = "Save items values to file";
            this.saveItemsValuesToFileToolStripMenuItem.Click += new System.EventHandler(this.saveItemsValuesToFileToolStripMenuItem_Click);
            // 
            // uploadItemsValuesFromFileToolStripMenuItem
            // 
            this.uploadItemsValuesFromFileToolStripMenuItem.Name = "uploadItemsValuesFromFileToolStripMenuItem";
            this.uploadItemsValuesFromFileToolStripMenuItem.Size = new System.Drawing.Size(460, 44);
            this.uploadItemsValuesFromFileToolStripMenuItem.Text = "Upload items values from file";
            this.uploadItemsValuesFromFileToolStripMenuItem.Click += new System.EventHandler(this.uploadItemsValuesFromFileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(334, 44);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(125, 38);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(173, 36);
            this.printPreviewToolStripMenuItem.Text = "Print preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadFromDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(132, 36);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // uploadFromDatabaseToolStripMenuItem
            // 
            this.uploadFromDatabaseToolStripMenuItem.Name = "uploadFromDatabaseToolStripMenuItem";
            this.uploadFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(383, 44);
            this.uploadFromDatabaseToolStripMenuItem.Text = "Upload from database";
            this.uploadFromDatabaseToolStripMenuItem.Click += new System.EventHandler(this.uploadFromDatabaseToolStripMenuItem_Click);
            // 
            // panelStatistics
            // 
            this.panelStatistics.Location = new System.Drawing.Point(1410, 669);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(492, 462);
            this.panelStatistics.TabIndex = 2;
            this.panelStatistics.Visible = false;
            this.panelStatistics.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStatistics_Paint);
            // 
            // buttonAddNewItem
            // 
            this.buttonAddNewItem.Location = new System.Drawing.Point(306, 734);
            this.buttonAddNewItem.Name = "buttonAddNewItem";
            this.buttonAddNewItem.Size = new System.Drawing.Size(185, 97);
            this.buttonAddNewItem.TabIndex = 3;
            this.buttonAddNewItem.Text = "ADD";
            this.buttonAddNewItem.UseVisualStyleBackColor = true;
            this.buttonAddNewItem.Click += new System.EventHandler(this.buttonAddNewItem_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(725, 734);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(185, 97);
            this.buttonRemoveItem.TabIndex = 4;
            this.buttonRemoveItem.Text = "REMOVE";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // listViewItemValue
            // 
            this.listViewItemValue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItemId,
            this.columnItemValue});
            this.listViewItemValue.GridLines = true;
            this.listViewItemValue.HideSelection = false;
            this.listViewItemValue.Location = new System.Drawing.Point(1414, 74);
            this.listViewItemValue.Name = "listViewItemValue";
            this.listViewItemValue.Size = new System.Drawing.Size(488, 589);
            this.listViewItemValue.TabIndex = 5;
            this.listViewItemValue.UseCompatibleStateImageBehavior = false;
            this.listViewItemValue.View = System.Windows.Forms.View.Details;
            // 
            // columnItemId
            // 
            this.columnItemId.Text = "ID";
            // 
            // columnItemValue
            // 
            this.columnItemValue.Text = "VALUE (PRICE*QUANTITY)";
            this.columnItemValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnItemValue.Width = 180;
            // 
            // FormDisplayItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2254, 1132);
            this.ContextMenuStrip = this.contextMenuStripForFileOperations;
            this.Controls.Add(this.listViewItemValue);
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.buttonAddNewItem);
            this.Controls.Add(this.panelStatistics);
            this.Controls.Add(this.menuStripFormDisplayItems);
            this.Controls.Add(this.listViewItems);
            this.MainMenuStrip = this.menuStripFormDisplayItems;
            this.Name = "FormDisplayItems";
            this.Text = "displayItemsForm";
            this.contextMenuStripForFileOperations.ResumeLayout(false);
            this.menuStripFormDisplayItems.ResumeLayout(false);
            this.menuStripFormDisplayItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStripFormDisplayItems;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractDataFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.Panel panelStatistics;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddNewItem;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.ListView listViewItemValue;
        private System.Windows.Forms.ColumnHeader columnItemId;
        private System.Windows.Forms.ColumnHeader columnItemValue;
        private System.Windows.Forms.ToolStripMenuItem saveItemsValuesToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadItemsValuesFromFileToolStripMenuItem;
    }
}