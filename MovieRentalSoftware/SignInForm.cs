using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSoftware
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int clientId = int.Parse(txtClientId.Text);
            string name = txtName.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            string creditCard = txtCreditCard.Text;
            string residAddress = txtResidAddress.Text;
            string bussAddress = txtBussAddress.Text;
            string billingAddress = txtBillingAddress.Text;

            MessageBox.Show("Registration successful!");
            var mainMenu = new MainMenu();
            mainMenu.Show();
            this.Owner.Hide();    
            this.Close();
        }
    }
}
