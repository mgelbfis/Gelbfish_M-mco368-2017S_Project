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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void viewFoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBalanceForm balance = new ViewBalanceForm();
            balance.Show();
        }

        private void viewItems_Click(object sender, EventArgs e)
        {
            ListItemsForm items = new ListItemsForm();
            items.Show();
        }

        private void buyFood_Click(object sender, EventArgs e)
        {
            PurchaseItemForm purchase = new PurchaseItemForm();
            purchase.Show();
        }

        private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakePaymentForm pay = new MakePaymentForm();
            pay.Show();
        }

        private void myOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrdersForm orders = new ViewOrdersForm();
            orders.Show();
        }
    }
}
