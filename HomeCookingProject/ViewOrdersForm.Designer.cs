namespace HomeCookingProject
{
    partial class ViewOrdersForm
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
            this.homeCookingDataSet = new HomeCookingProject.HomeCookingDataSet();
            this.homeCookingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new HomeCookingProject.HomeCookingDataSetTableAdapters.ProductTableAdapter();
            this.homeCookingDataSet1 = new HomeCookingProject.HomeCookingDataSet1();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseTableAdapter = new HomeCookingProject.HomeCookingDataSet1TableAdapters.PurchaseTableAdapter();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.lowestPrice = new System.Windows.Forms.NumericUpDown();
            this.highestPrice = new System.Windows.Forms.NumericUpDown();
            this.lowestLabel = new System.Windows.Forms.Label();
            this.highestLabel = new System.Windows.Forms.Label();
            this.ordersView = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewOrdersButton = new System.Windows.Forms.Button();
            this.dateRangeButton = new System.Windows.Forms.CheckBox();
            this.priceRangeButton = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.homeCookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCookingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCookingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowestPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highestPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // homeCookingDataSet
            // 
            this.homeCookingDataSet.DataSetName = "HomeCookingDataSet";
            this.homeCookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // homeCookingDataSetBindingSource
            // 
            this.homeCookingDataSetBindingSource.DataSource = this.homeCookingDataSet;
            this.homeCookingDataSetBindingSource.Position = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.homeCookingDataSetBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // homeCookingDataSet1
            // 
            this.homeCookingDataSet1.DataSetName = "HomeCookingDataSet1";
            this.homeCookingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "Purchase";
            this.purchaseBindingSource.DataSource = this.homeCookingDataSet1;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(60, 62);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(211, 20);
            this.startDate.TabIndex = 2;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(288, 62);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(211, 20);
            this.endDate.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(60, 46);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(289, 46);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(55, 13);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date:";
            // 
            // lowestPrice
            // 
            this.lowestPrice.DecimalPlaces = 2;
            this.lowestPrice.Location = new System.Drawing.Point(63, 138);
            this.lowestPrice.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.lowestPrice.Name = "lowestPrice";
            this.lowestPrice.Size = new System.Drawing.Size(120, 20);
            this.lowestPrice.TabIndex = 6;
            // 
            // highestPrice
            // 
            this.highestPrice.DecimalPlaces = 2;
            this.highestPrice.Location = new System.Drawing.Point(200, 137);
            this.highestPrice.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.highestPrice.Name = "highestPrice";
            this.highestPrice.Size = new System.Drawing.Size(120, 20);
            this.highestPrice.TabIndex = 7;
            // 
            // lowestLabel
            // 
            this.lowestLabel.AutoSize = true;
            this.lowestLabel.Location = new System.Drawing.Point(61, 122);
            this.lowestLabel.Name = "lowestLabel";
            this.lowestLabel.Size = new System.Drawing.Size(100, 13);
            this.lowestLabel.TabIndex = 8;
            this.lowestLabel.Text = "Lowest Order Total:";
            this.lowestLabel.Click += new System.EventHandler(this.lowestLabel_Click);
            // 
            // highestLabel
            // 
            this.highestLabel.AutoSize = true;
            this.highestLabel.Location = new System.Drawing.Point(200, 121);
            this.highestLabel.Name = "highestLabel";
            this.highestLabel.Size = new System.Drawing.Size(102, 13);
            this.highestLabel.TabIndex = 9;
            this.highestLabel.Text = "Highest Order Total:";
            this.highestLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ordersView
            // 
            this.ordersView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.CustID,
            this.Product,
            this.Quantity,
            this.OrderDate,
            this.OrderTotal});
            this.ordersView.Location = new System.Drawing.Point(12, 203);
            this.ordersView.Name = "ordersView";
            this.ordersView.Size = new System.Drawing.Size(594, 237);
            this.ordersView.TabIndex = 11;
            this.ordersView.UseCompatibleStateImageBehavior = false;
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order ID:";
            // 
            // CustID
            // 
            this.CustID.Text = "Customer ID:";
            // 
            // Product
            // 
            this.Product.Text = "Product:";
            this.Product.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity:";
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "Order Date:";
            this.OrderDate.Width = 80;
            // 
            // OrderTotal
            // 
            this.OrderTotal.Text = "Order Total:";
            this.OrderTotal.Width = 80;
            // 
            // viewOrdersButton
            // 
            this.viewOrdersButton.Location = new System.Drawing.Point(219, 175);
            this.viewOrdersButton.Name = "viewOrdersButton";
            this.viewOrdersButton.Size = new System.Drawing.Size(134, 22);
            this.viewOrdersButton.TabIndex = 10;
            this.viewOrdersButton.Text = "View Orders";
            this.viewOrdersButton.UseVisualStyleBackColor = true;
            this.viewOrdersButton.Click += new System.EventHandler(this.viewOrdersButton_Click);
            // 
            // dateRangeButton
            // 
            this.dateRangeButton.AutoSize = true;
            this.dateRangeButton.Location = new System.Drawing.Point(22, 22);
            this.dateRangeButton.Name = "dateRangeButton";
            this.dateRangeButton.Size = new System.Drawing.Size(228, 17);
            this.dateRangeButton.TabIndex = 12;
            this.dateRangeButton.Text = "View Orders Within a Certain Date Range?";
            this.dateRangeButton.UseVisualStyleBackColor = true;
            this.dateRangeButton.CheckedChanged += new System.EventHandler(this.dateRangeButton_CheckedChanged_1);
            // 
            // priceRangeButton
            // 
            this.priceRangeButton.AutoSize = true;
            this.priceRangeButton.Location = new System.Drawing.Point(22, 97);
            this.priceRangeButton.Name = "priceRangeButton";
            this.priceRangeButton.Size = new System.Drawing.Size(229, 17);
            this.priceRangeButton.TabIndex = 13;
            this.priceRangeButton.Text = "View Orders Within a Certain Price Range?";
            this.priceRangeButton.UseVisualStyleBackColor = true;
            this.priceRangeButton.CheckedChanged += new System.EventHandler(this.priceRangeButton_CheckedChanged_1);
            // 
            // ViewOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 456);
            this.Controls.Add(this.priceRangeButton);
            this.Controls.Add(this.dateRangeButton);
            this.Controls.Add(this.ordersView);
            this.Controls.Add(this.viewOrdersButton);
            this.Controls.Add(this.highestLabel);
            this.Controls.Add(this.lowestLabel);
            this.Controls.Add(this.highestPrice);
            this.Controls.Add(this.lowestPrice);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Name = "ViewOrdersForm";
            this.Text = "View My Orders";
            this.Load += new System.EventHandler(this.ViewOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeCookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCookingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeCookingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowestPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highestPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource homeCookingDataSetBindingSource;
        private HomeCookingDataSet homeCookingDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private HomeCookingDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private HomeCookingDataSet1 homeCookingDataSet1;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private HomeCookingDataSet1TableAdapters.PurchaseTableAdapter purchaseTableAdapter;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.NumericUpDown lowestPrice;
        private System.Windows.Forms.NumericUpDown highestPrice;
        private System.Windows.Forms.Label lowestLabel;
        private System.Windows.Forms.Label highestLabel;
        private System.Windows.Forms.ListView ordersView;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader CustID;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.ColumnHeader OrderTotal;
        private System.Windows.Forms.Button viewOrdersButton;
        private System.Windows.Forms.CheckBox dateRangeButton;
        private System.Windows.Forms.CheckBox priceRangeButton;
    }
}