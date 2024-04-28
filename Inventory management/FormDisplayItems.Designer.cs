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
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStatistics = new System.Windows.Forms.Panel();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.listViewItems.Size = new System.Drawing.Size(1300, 763);
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
            this.printPreviewToolStripMenuItem});
            this.menuStripFormDisplayItems.Location = new System.Drawing.Point(0, 0);
            this.menuStripFormDisplayItems.Name = "menuStripFormDisplayItems";
            this.menuStripFormDisplayItems.Size = new System.Drawing.Size(1474, 42);
            this.menuStripFormDisplayItems.TabIndex = 1;
            this.menuStripFormDisplayItems.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem,
            this.extractDataFromFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.saveToFileToolStripMenuItem.Text = "Save to file";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // extractDataFromFileToolStripMenuItem
            // 
            this.extractDataFromFileToolStripMenuItem.Name = "extractDataFromFileToolStripMenuItem";
            this.extractDataFromFileToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.extractDataFromFileToolStripMenuItem.Text = "Upload from file";
            this.extractDataFromFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFromFileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(120, 38);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(125, 38);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // panelStatistics
            // 
            this.panelStatistics.Location = new System.Drawing.Point(188, 143);
            this.panelStatistics.Name = "panelStatistics";
            this.panelStatistics.Size = new System.Drawing.Size(896, 537);
            this.panelStatistics.TabIndex = 2;
            this.panelStatistics.Visible = false;
            this.panelStatistics.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStatistics_Paint);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.printPreviewToolStripMenuItem.Text = "Print preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // FormDisplayItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 864);
            this.ContextMenuStrip = this.contextMenuStripForFileOperations;
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
    }
}