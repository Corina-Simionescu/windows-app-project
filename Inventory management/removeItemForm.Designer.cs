﻿namespace Inventory_management
{
    partial class removeItemForm
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
            this.labelRemoveItemTitle = new System.Windows.Forms.Label();
            this.labelIndication = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonGoBackToForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRemoveItemTitle
            // 
            this.labelRemoveItemTitle.AutoSize = true;
            this.labelRemoveItemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemoveItemTitle.Location = new System.Drawing.Point(530, 77);
            this.labelRemoveItemTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRemoveItemTitle.Name = "labelRemoveItemTitle";
            this.labelRemoveItemTitle.Size = new System.Drawing.Size(415, 63);
            this.labelRemoveItemTitle.TabIndex = 0;
            this.labelRemoveItemTitle.Text = "REMOVE ITEM";
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
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(588, 433);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(286, 77);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "REMOVE";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonGoBackToForm1
            // 
            this.buttonGoBackToForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBackToForm1.Location = new System.Drawing.Point(78, 613);
            this.buttonGoBackToForm1.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGoBackToForm1.Name = "buttonGoBackToForm1";
            this.buttonGoBackToForm1.Size = new System.Drawing.Size(228, 181);
            this.buttonGoBackToForm1.TabIndex = 5;
            this.buttonGoBackToForm1.Text = "GO BACK";
            this.buttonGoBackToForm1.UseVisualStyleBackColor = true;
            this.buttonGoBackToForm1.Click += new System.EventHandler(this.buttonGoBackToForm1_Click);
            // 
            // removeItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.buttonGoBackToForm1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelIndication);
            this.Controls.Add(this.labelRemoveItemTitle);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "removeItemForm";
            this.Text = "removeItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRemoveItemTitle;
        private System.Windows.Forms.Label labelIndication;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonGoBackToForm1;
    }
}