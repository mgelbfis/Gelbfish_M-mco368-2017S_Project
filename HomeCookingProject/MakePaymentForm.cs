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
    public partial class MakePaymentForm : Form
    {
        public MakePaymentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LinqToSQLClassesDataContext context = new LinqToSQLClassesDataContext())
            {
                var cust = context.GetTable<Customer>().Where(c => c.CustID == User.ID).First();
                cust.CustBalance = cust.CustBalance - paymentAmount.Value;
                context.SubmitChanges();
            }
            this.Hide();
        }
    }
}
