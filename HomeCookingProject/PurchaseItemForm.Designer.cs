namespace HomeCookingProject
{
    partial class PurchaseItemForm
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
            this.menuItemsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.totalLabel = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.BalanceTooHighLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // menuItemsComboBox
            // 
            this.menuItemsComboBox.FormattingEnabled = true;
            this.menuItemsComboBox.Location = new System.Drawing.Point(25, 56);
            this.menuItemsComboBox.Name = "menuItemsComboBox";
            this.menuItemsComboBox.Size = new System.Drawing.Size(121, 21);
            this.menuItemsComboBox.TabIndex = 0;
            this.menuItemsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Item:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(167, 37);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(34, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price:";
            this.priceLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(170, 57);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(63, 20);
            this.price.TabIndex = 3;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(158, 152);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "Order Item";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(251, 37);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(49, 13);
            this.AmountLabel.TabIndex = 5;
            this.AmountLabel.Text = "Quantity:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(254, 56);
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(46, 20);
            this.quantity.TabIndex = 6;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.ValueChanged += new System.EventHandler(this.quantity_ValueChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(315, 37);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(63, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Order Total:";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(318, 57);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(60, 20);
            this.total.TabIndex = 8;
            // 
            // BalanceTooHighLabel
            // 
            this.BalanceTooHighLabel.AutoSize = true;
            this.BalanceTooHighLabel.Location = new System.Drawing.Point(97, 108);
            this.BalanceTooHighLabel.Name = "BalanceTooHighLabel";
            this.BalanceTooHighLabel.Size = new System.Drawing.Size(0, 13);
            this.BalanceTooHighLabel.TabIndex = 9;
            // 
            // PurchaseItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 187);
            this.Controls.Add(this.BalanceTooHighLabel);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.price);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuItemsComboBox);
            this.Name = "PurchaseItemForm";
            this.Text = "Purchase Food";
            this.Load += new System.EventHandler(this.PurchaseItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox menuItemsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label BalanceTooHighLabel;
    }
}