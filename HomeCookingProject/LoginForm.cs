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
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LinqToSQLClassesDataContext context = new LinqToSQLClassesDataContext())
            {

                if (context.Customers.Any(c => c.UserName == Username.Text))
                {
                    User.Username = Username.Text;

                    User.ID = context.Customers.Where(c => c.UserName == User.Username).Select(c => c.CustID).First();

                    string password = context.Customers.Where(c => c.UserName == Username.Text).Select(c => c.CustPassword).First();

                    if (password == Password.Text)
                    {
                        MenuForm menu = new MenuForm();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        wrongPassword.Text = "Wrong Username and/or Password. Try Again.";
                    }

                }

               
                else
                {
                    wrongPassword.Text = "Wrong Username and/or Password. Try Again.";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void wrongPassword_Click(object sender, EventArgs e)
        {

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            NewAccountForm account = new NewAccountForm();
            account.Show();
            this.Hide();
        }
    }
}
