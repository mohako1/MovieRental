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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLoginSubmit_Click(object sender, EventArgs e)
        {

            string name = txtLoginName.Text;
            string password = txtLoginPassword.Text;

            MessageBox.Show($"Welcome, {name}");
            var mainMenu = new MainMenu();
            mainMenu.Show();
            this.Owner.Hide();       
            this.Close();
        }
    }
}
