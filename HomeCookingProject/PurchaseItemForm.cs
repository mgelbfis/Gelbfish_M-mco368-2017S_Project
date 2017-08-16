using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeCookingProject
{
    public partial class PurchaseItemForm : Form
    {
        private ArrayList productIDs;

        public PurchaseItemForm()
        {
            InitializeComponent();
            using (LinqToSQLClassesDataContext context = new LinqToSQLClassesDataContext())
            {
                var menuItems = context.Products.Select(p => p);
                foreach (var m in menuItems)
                    menuItemsComboBox.Items.Add(m.ProductName);
                productIDs = new ArrayList();
                foreach (var m in menuItems)
                {
                    productIDs.Add(m.ProductID);
                }
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (LinqToSQLClassesDataContext context = new LinqToSQLClassesDataContext())
            {
                int ID = Convert.ToInt32(productIDs[menuItemsComboBox.SelectedIndex]);
                price.Text = context.Products.Where(p => p.ProductID == ID).Select(p => p.Price).First().ToString();
                total.Text = (Convert.ToDecimal(price.Text.ToString())* quantity.Value).ToString();
            }
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            total.Text = (Convert.ToDecimal(price.Text.ToString()) * quantity.Value).ToString();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            using (LinqToSQLClassesDataContext context = new LinqToSQLClassesDataContext())
            {
                Purchase p = new HomeCookingProject.Purchase
                {
                    CID = User.ID,
                    PID = Convert.ToInt32(productIDs[menuItemsComboBox.SelectedIndex]),
                    Quantity = Convert.ToInt32(quantity.Value),
                };

                try
                {
                    context.Purchases.InsertOnSubmit(p);
                    context.SubmitChanges();
                    this.Hide();
                }
                catch (SqlException excpt)
                {
                    if(excpt.Number == 50001)
                    {
                        BalanceTooHighLabel.Text = "Could not process. Balance too high.";
                    }
                };
            }
        }

        private void PurchaseItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
