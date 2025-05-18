using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace MovieRentalSoftware
{
    public partial class SignInForm : Form
    {
        private Movie_Rental_ManagementDataSetTableAdapters.CLIENTTableAdapter clientTableAdapter;
        private Movie_Rental_ManagementDataSetTableAdapters.ADDRESSTableAdapter addressTableAdapter;

        public SignInForm()
        {
            InitializeComponent();
            // Ensure password characters are used
            if (this.txtPassword != null) this.txtPassword.PasswordChar = '*';
            if (this.txtConfirmPassword != null) this.txtConfirmPassword.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string phone = txtPhone.Text.Trim();
            string creditCard = txtCreditCard.Text.Trim();
            string residAddress = txtResidAddress.Text.Trim();
            string bussAddress = txtBussAddress.Text.Trim(); // Optional
            string billingAddress = txtBillingAddress.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(creditCard) ||
                string.IsNullOrWhiteSpace(residAddress) ||
                string.IsNullOrWhiteSpace(billingAddress))
            {
                MessageBox.Show("Please fill in all required fields (Name, Password, Confirm Password, Credit Card, Residential Address, Billing Address).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Add more specific validation for phone, credit card formats if needed

            try
            {
                clientTableAdapter = new Movie_Rental_ManagementDataSetTableAdapters.CLIENTTableAdapter();
                addressTableAdapter = new Movie_Rental_ManagementDataSetTableAdapters.ADDRESSTableAdapter();
                
                // Get current count of clients to determine the next CLIENT_ID
                Movie_Rental_ManagementDataSet.CLIENTDataTable clientTableForCount = new Movie_Rental_ManagementDataSet.CLIENTDataTable();
                clientTableAdapter.Fill(clientTableForCount);
                int currentClientCount = clientTableForCount.Rows.Count;
                int nextClientId = currentClientCount + 1; 

                Movie_Rental_ManagementDataSet.CLIENTDataTable clientTable = new Movie_Rental_ManagementDataSet.CLIENTDataTable();
                
                // Create and populate new client row
                Movie_Rental_ManagementDataSet.CLIENTRow newClientRow = clientTable.NewCLIENTRow();
                newClientRow.CLIENT_ID = nextClientId; // Set CLIENT_ID based on count + 1
                newClientRow.NAME = name;
                newClientRow.PASSWORD = password; // Security: Passwords should be hashed!
                if (!string.IsNullOrWhiteSpace(phone)) newClientRow.PHONE = phone;
                else newClientRow.SetPHONENull(); // Explicitly set null if optional and empty
                newClientRow.CREDIT_CARD = creditCard;

                clientTable.AddCLIENTRow(newClientRow);
                clientTableAdapter.Update(clientTable); 

                // Get the newly generated Client ID (if auto-generated)
                // The newClientRow should be updated by the TableAdapter.Update if the primary key is returned (common for identity columns)
                // With the manual setting, newClientId is already known.
                int newClientIdFromRow = newClientRow.CLIENT_ID; 

                // Create and populate new address row
                Movie_Rental_ManagementDataSet.ADDRESSDataTable addressTable = new Movie_Rental_ManagementDataSet.ADDRESSDataTable();
                Movie_Rental_ManagementDataSet.ADDRESSRow newAddressRow = addressTable.NewADDRESSRow();
                newAddressRow.CLIENT_ID = newClientIdFromRow; // Use the ID from the row
                newAddressRow.RESID_ADRS = residAddress;
                if (!string.IsNullOrWhiteSpace(bussAddress)) newAddressRow.BUSS_ADRS = bussAddress;
                else newAddressRow.BUSS_ADRS = ""; // Set to empty string if optional and not provided
                newAddressRow.BILLING_ADRS = billingAddress;
                
                addressTable.AddADDRESSRow(newAddressRow);
                addressTableAdapter.Update(addressTable);

                MessageBox.Show("Registration successful! You can now log in.", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Navigate to LoginForm
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            catch (System.Data.ConstraintException ex)
            {
                 MessageBox.Show("Error during registration: A client with this information might already exist or there was a data conflict. \nDetails: " + ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        // Remove unused guna2TextBox7_TextChanged if it's still present from the old design
        // private void guna2TextBox7_TextChanged(object sender, EventArgs e) { /* ... */ }
    }
}
