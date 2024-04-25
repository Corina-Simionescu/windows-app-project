namespace Inventory_management
{
    partial class FormMainMenu
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
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonViewItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddItem.Location = new System.Drawing.Point(472, 23);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(462, 177);
            this.buttonAddItem.TabIndex = 0;
            this.buttonAddItem.Text = "ADD ITEM";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveItem.Location = new System.Drawing.Point(472, 296);
            this.buttonRemoveItem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(462, 177);
            this.buttonRemoveItem.TabIndex = 1;
            this.buttonRemoveItem.Text = "REMOVE ITEM";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonViewItems
            // 
            this.buttonViewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewItems.Location = new System.Drawing.Point(472, 579);
            this.buttonViewItems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonViewItems.Name = "buttonViewItems";
            this.buttonViewItems.Size = new System.Drawing.Size(462, 154);
            this.buttonViewItems.TabIndex = 2;
            this.buttonViewItems.Text = "VIEW ITEMS";
            this.buttonViewItems.UseVisualStyleBackColor = true;
            this.buttonViewItems.Click += new System.EventHandler(this.buttonViewItems_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.buttonViewItems);
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.buttonAddItem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Button buttonViewItems;
    }
}