using System;
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
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            if (confirmPassword.Text != passwordEntry.Text)
            {
                passwordMismatch.Text = "Passwords do not match. Please Re-enter.";
            }
            else
            {
                using (LinqToSQLClassesDataContext context = new LinqToSQLClassesDataContext())
                {
                    Customer c = new HomeCookingProject.Customer
                    {
                        UserName = usernameEntry.Text,
                        CustPassword = passwordEntry.Text
                    };
                    try
                    {
                        context.Customers.InsertOnSubmit(c);
                        context.SubmitChanges();
                        this.Hide();
                    }
                    catch (SqlException except)
                    {
                        Console.Write(except.Message);
                    }
                    User.Username = usernameEntry.Text;

                    User.ID = context.Customers.Where(cu => cu.UserName == User.Username).Select(cu => cu.CustID).First();
                }
                MenuForm menu = new MenuForm();
                menu.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
