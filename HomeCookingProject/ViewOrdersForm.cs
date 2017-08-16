using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeCookingProject
{
    public partial class ViewOrdersForm : Form
    {
        public ViewOrdersForm()
        {
            InitializeComponent();
            startDateLabel.Hide();
            startDate.Hide();
            endDateLabel.Hide();
            endDate.Hide();
            lowestLabel.Hide();
            lowestPrice.Hide();
            highestLabel.Hide();
            highestPrice.Hide();
            ordersView.Hide();

        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'homeCookingDataSet1.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.homeCookingDataSet1.Purchase);
            // TODO: This line of code loads data into the 'homeCookingDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.homeCookingDataSet.Product);

        }

        private void lowestLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        


        private void viewOrdersButton_Click(object sender, EventArgs e)
        {
            showOrders();
            
        }

        private void showOrders()
        {
            ordersView.Show();
            ordersView.Items.Clear();
            ordersView.View = View.Details;

            using (LinqToSQLClassesDataContext context = new LinqToSQLClassesDataContext())
            {
                if (priceRangeButton.Checked && dateRangeButton.Checked)
                {
                    var purchases = context.Purchases.Where(p => p.CID == User.ID && p.OrderTotal >= lowestPrice.Value
                        && p.OrderTotal <= highestPrice.Value && p.OrderDate >= startDate.Value
                        && p.OrderDate <= endDate.Value).Select(p => p);
                    foreach (var v in purchases)
                    {
                        String product = context.Products.Where(p => p.ProductID == v.PID).Select(p => p.ProductName).First().ToString();
                        var item = new ListViewItem(new[] { v.OrderID.ToString(), v.CID.ToString(),
                            product, v.Quantity.ToString(), v.OrderDate.ToString(), v.OrderTotal.ToString() });
                        ordersView.Items.Add(item);
                    }
                }
                else if (priceRangeButton.Checked)
                {
                    var purchases = context.Purchases.Where(p => p.CID == User.ID && p.OrderTotal >= lowestPrice.Value
                       && p.OrderTotal <= highestPrice.Value).Select(p => p);
                    foreach (var v in purchases)
                    {
                        String product = context.Products.Where(p => p.ProductID == v.PID).Select(p => p.ProductName).First().ToString();
                        var item = new ListViewItem(new[] { v.OrderID.ToString(), v.CID.ToString(),
                            product, v.Quantity.ToString(), v.OrderDate.ToString(), v.OrderTotal.ToString() });
                        ordersView.Items.Add(item);
                    }
                }
                else if (dateRangeButton.Checked)
                {
                    var purchases = context.Purchases.Where(p => p.CID == User.ID && p.OrderDate >= startDate.Value
                        && p.OrderDate <= endDate.Value).Select(p => p);
                    foreach (var v in purchases)
                    {
                        String product = context.Products.Where(p => p.ProductID == v.PID).Select(p => p.ProductName).First().ToString();
                        var item = new ListViewItem(new[] { v.OrderID.ToString(), v.CID.ToString(),
                            product, v.Quantity.ToString(), v.OrderDate.ToString(), v.OrderTotal.ToString() });
                        ordersView.Items.Add(item);
                    }
                }
                else
                {
                    var purchases = context.Purchases.Where(p => p.CID == User.ID).Select(p => p);
                    foreach (var v in purchases)
                    {
                        String product = context.Products.Where(p => p.ProductID == v.PID).Select(p => p.ProductName).First().ToString();
                        var item = new ListViewItem(new[] { v.OrderID.ToString(), v.CID.ToString(),
                            product, v.Quantity.ToString(), v.OrderDate.ToString(), v.OrderTotal.ToString() });
                        ordersView.Items.Add(item);
                    }
                }
            }
        }

        private void dateRangeButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (dateRangeButton.Checked)
            {
                startDateLabel.Show();
                startDate.Show();
                endDateLabel.Show();
                endDate.Show();
            }
            else
            {
                startDateLabel.Hide();
                startDate.Hide();
                endDateLabel.Hide();
                endDate.Hide();
            }

        }

        private void priceRangeButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (priceRangeButton.Checked)
            {
                lowestLabel.Show();
                lowestPrice.Show();
                highestLabel.Show();
                highestPrice.Show();
            }
            else
            {
                lowestLabel.Hide();
                lowestPrice.Hide();
                highestLabel.Hide();
                highestPrice.Hide();
            }
        }
    }
}
