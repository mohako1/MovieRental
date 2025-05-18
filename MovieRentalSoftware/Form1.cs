using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MovieRentalSoftware
{
    public partial class Form1 : Form
    {
        private Movie_Rental_ManagementDataSetTableAdapters.MOVIETableAdapter movieTableAdapter;
        private Movie_Rental_ManagementDataSet.MOVIEDataTable movieDataTable;

        public Form1()
        {
            InitializeComponent();
            CustomizeDataGridView();
            LoadMoviesData();
        }

        private void CustomizeDataGridView()
        {
            if (moviesDataGridView != null)
            {
                // Style the DataGridView if it's a Guna2DataGridView
                if (moviesDataGridView is Guna.UI2.WinForms.Guna2DataGridView gdgv)
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

        private void LoadMoviesData()
        {
            try
            {
                movieTableAdapter = new Movie_Rental_ManagementDataSetTableAdapters.MOVIETableAdapter();
                movieDataTable = new Movie_Rental_ManagementDataSet.MOVIEDataTable();
                movieTableAdapter.Fill(movieDataTable);
                moviesDataGridView.DataSource = movieDataTable;

                // Set column headers and formatting
                if (moviesDataGridView.Columns.Count > 0)
                {
                    if (moviesDataGridView.Columns.Contains("MOVIE_ID")) 
                        moviesDataGridView.Columns["MOVIE_ID"].HeaderText = "Movie ID";
                    
                    if (moviesDataGridView.Columns.Contains("ADMIN_ID")) 
                        moviesDataGridView.Columns["ADMIN_ID"].HeaderText = "Admin ID";
                    
                    if (moviesDataGridView.Columns.Contains("SUPPLIER_ID")) 
                        moviesDataGridView.Columns["SUPPLIER_ID"].HeaderText = "Supplier ID";
                    
                    if (moviesDataGridView.Columns.Contains("NAME")) 
                        moviesDataGridView.Columns["NAME"].HeaderText = "Movie Title";
                    
                    if (moviesDataGridView.Columns.Contains("TYPE")) 
                        moviesDataGridView.Columns["TYPE"].HeaderText = "Genre";
                    
                    if (moviesDataGridView.Columns.Contains("PRICE")) 
                        moviesDataGridView.Columns["PRICE"].HeaderText = "Price";
                    
                    if (moviesDataGridView.Columns.Contains("LEAD_ACTOR")) 
                        moviesDataGridView.Columns["LEAD_ACTOR"].HeaderText = "Lead Actor";
                    
                    if (moviesDataGridView.Columns.Contains("YEAR")) 
                        moviesDataGridView.Columns["YEAR"].HeaderText = "Release Year";
                    
                    if (moviesDataGridView.Columns.Contains("AGE_RESTRIECTION")) 
                        moviesDataGridView.Columns["AGE_RESTRIECTION"].HeaderText = "Age Restriction";
                    
                    if (moviesDataGridView.Columns.Contains("ADDING_YEAR")) 
                        moviesDataGridView.Columns["ADDING_YEAR"].HeaderText = "Date Added";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading movies: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            // Temporary workaround for MainMenu error - in production use: new MainMenu().Show();
            Application.Exit();
        }

        private void btnRentMovie_Click(object sender, EventArgs e)
        {
            if (moviesDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected movie ID
                int movieId = Convert.ToInt32(moviesDataGridView.SelectedRows[0].Cells["MOVIE_ID"].Value);
                string movieName = moviesDataGridView.SelectedRows[0].Cells["NAME"].Value.ToString();
                double price = Convert.ToDouble(moviesDataGridView.SelectedRows[0].Cells["PRICE"].Value);

                // For now we'll just show a confirmation message
                MessageBox.Show($"Do you want to rent '{movieName}' for ${price}?\n\nThis feature will be implemented in the future.", 
                    "Rent Movie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // In a complete implementation, you would:
                // 1. Get the logged-in user's CLIENT_ID
                // 2. Create a new record in RENTAL_DETAIL table
                // 3. Show confirmation and/or navigate to checkout
            }
            else
            {
                MessageBox.Show("Please select a movie to rent.", "Rent Movie", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
