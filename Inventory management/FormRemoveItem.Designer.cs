namespace Inventory_management
{
    partial class FormRemoveItem
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
            this.labelRemovetemTitle = new System.Windows.Forms.Label();
            this.labelIndication = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.errorProviderRemoveItemForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRemoveItemForm)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRemovetemTitle
            // 
            this.labelRemovetemTitle.AutoSize = true;
            this.labelRemovetemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemovetemTitle.Location = new System.Drawing.Point(530, 77);
            this.labelRemovetemTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRemovetemTitle.Name = "labelRemovetemTitle";
            this.labelRemovetemTitle.Size = new System.Drawing.Size(415, 63);
            this.labelRemovetemTitle.TabIndex = 0;
            this.labelRemovetemTitle.Text = "REMOVE ITEM";
            // 
            // labelIndication
            // 
            this.labelIndication.AutoSize = true;
            this.labelIndication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndication.Location = new System.Drawing.Point(348, 212);
            this.labelIndication.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIndication.Name = "labelIndication";
            this.labelIndication.Size = new System.Drawing.Size(817, 44);
            this.labelIndication.TabIndex = 1;
            this.labelIndication.Text = "Introduce the ID of the item you want to remove";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(532, 302);
            this.labelId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(74, 48);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(758, 296);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(196, 55);
            this.textBoxId.TabIndex = 3;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // buttonDelete
            // 
            this.buttonDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(588, 433);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(286, 77);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "REMOVE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // errorProviderRemoveItemForm
            // 
            this.errorProviderRemoveItemForm.ContainerControl = this;
            // 
            // FormRemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelIndication);
            this.Controls.Add(this.labelRemovetemTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormRemoveItem";
            this.Text = "removeItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRemoveItemForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRemovetemTitle;
        private System.Windows.Forms.Label labelIndication;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ErrorProvider errorProviderRemoveItemForm;
    }
}