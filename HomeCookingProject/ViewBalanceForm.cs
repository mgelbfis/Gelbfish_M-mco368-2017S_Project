using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeCookingProject
{
    public partial class ViewBalanceForm : Form
    {
        public ViewBalanceForm()
        {
            InitializeComponent();

            using (LinqToSQLClassesDataContext context = new LinqToSQLClassesDataContext())
            {
                decimal balance = Convert.ToDecimal(context.Customers.Where(c => c.CustID == User.ID).Select(c => c.CustBalance).First());
                custBalance.Text = "Your current balance is: " + String.Format("{0:C}", balance);
            }
               
        }

        private void payBalanceButton_Click(object sender, EventArgs e)
        {
            MakePaymentForm pay = new MakePaymentForm();
            pay.Show();
            this.Hide();
        }
    }
}
