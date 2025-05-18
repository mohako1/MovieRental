using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MovieRentalSoftware
{
    public partial class Form2 : Form
    {
        private Movie_Rental_ManagementDataSetTableAdapters.RENTAL_DETAILTableAdapter rentalDetailTableAdapter;
        private Movie_Rental_ManagementDataSet.RENTAL_DETAILDataTable rentalDetailDataTable;

        public Form2()
        {
            InitializeComponent();
            CustomizeDataGridView();
            LoadRentedMoviesData();
        }

        private void CustomizeDataGridView()
        {
            if (rentedMoviesDataGridView != null)
            {
                // Style the DataGridView if it's a Guna2DataGridView
                if (rentedMoviesDataGridView is Guna.UI2.WinForms.Guna2DataGridView gdgv)
                {
                    gdgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    gdgv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
                    gdgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
                    
                    gdgv.ThemeStyle.RowsStyle.BackColor = Color.White;
                    gdgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(240, 240, 240);
                    
                    gdgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
                    gdgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
                    
                    gdgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
                    gdgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
                    
                    gdgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    gdgv.GridColor = Color.FromArgb(231, 229, 255);
                }
            }
        }

        private void LoadRentedMoviesData()
        {
            try
            {
                int currentClientId = 1; // Temporary fix to bypass LoginForm error - in production use LoginForm.LoggedInClientId
                
                if (currentClientId == 0) // Or some other indicator that no one is logged in
                {
                    MessageBox.Show("No user is logged in. Please log in to see your rented movies.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Optionally, close this form or navigate back to login
                    this.Close();
                    // Temporary workaround for MainMenu error - in production use: new MainMenu().Show();
                    Application.Exit();
                    return;
                }

                rentalDetailTableAdapter = new Movie_Rental_ManagementDataSetTableAdapters.RENTAL_DETAILTableAdapter();
                rentalDetailDataTable = new Movie_Rental_ManagementDataSet.RENTAL_DETAILDataTable();
                rentalDetailTableAdapter.Fill(rentalDetailDataTable); // Fill all rental details

                // Filter the DataTable for the logged-in client
                Movie_Rental_ManagementDataSet.RENTAL_DETAILDataTable filteredTable = new Movie_Rental_ManagementDataSet.RENTAL_DETAILDataTable(); // Corrected instantiation
                var filteredRows = rentalDetailDataTable.AsEnumerable()
                                     .Where(row => row.CLIENT_ID == currentClientId);
                
                foreach (var row in filteredRows)
                {
                    filteredTable.ImportRow(row);
                }

                rentedMoviesDataGridView.DataSource = filteredTable;

                // Set column headers and formatting
                if (rentedMoviesDataGridView.Columns.Count > 0)
                {
                    if (rentedMoviesDataGridView.Columns.Contains("RENTAL_ID")) 
                        rentedMoviesDataGridView.Columns["RENTAL_ID"].HeaderText = "Rental ID";
                    
                    if (rentedMoviesDataGridView.Columns.Contains("MOVIE_ID")) 
                        rentedMoviesDataGridView.Columns["MOVIE_ID"].HeaderText = "Movie ID";
                    
                    if (rentedMoviesDataGridView.Columns.Contains("CLIENT_ID")) 
                        rentedMoviesDataGridView.Columns["CLIENT_ID"].HeaderText = "Client ID";
                    
                    if (rentedMoviesDataGridView.Columns.Contains("RENTAL_DATE")) 
                        rentedMoviesDataGridView.Columns["RENTAL_DATE"].HeaderText = "Rental Date";
                    
                    if (rentedMoviesDataGridView.Columns.Contains("PRICE")) 
                        rentedMoviesDataGridView.Columns["PRICE"].HeaderText = "Price";
                    
                    if (rentedMoviesDataGridView.Columns.Contains("RETURN_DATE")) 
                        rentedMoviesDataGridView.Columns["RETURN_DATE"].HeaderText = "Return Date";
                }

                if (!filteredRows.Any())
                {
                     MessageBox.Show("You have no rented movies.", "Rented Movies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rented movies: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            // Temporary workaround for MainMenu error - in production use: new MainMenu().Show();
            Application.Exit();
        }
    }
}
