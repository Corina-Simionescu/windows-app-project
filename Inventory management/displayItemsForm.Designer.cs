namespace Inventory_management
{
    partial class displayItemsForm
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
            this.textBoxDisplayItems = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDisplayItems
            // 
            this.textBoxDisplayItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDisplayItems.Location = new System.Drawing.Point(0, 0);
            this.textBoxDisplayItems.Multiline = true;
            this.textBoxDisplayItems.Name = "textBoxDisplayItems";
            this.textBoxDisplayItems.ReadOnly = true;
            this.textBoxDisplayItems.Size = new System.Drawing.Size(1813, 914);
            this.textBoxDisplayItems.TabIndex = 0;
            // 
            // displayItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1813, 914);
            this.Controls.Add(this.textBoxDisplayItems);
            this.Name = "displayItemsForm";
            this.Text = "displayItemsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplayItems;
    }
}