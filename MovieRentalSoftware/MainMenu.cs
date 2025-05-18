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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            if (this.btnShowRentedMovies != null) // Check if the button exists
            {
                this.btnShowRentedMovies.Click += new System.EventHandler(this.btnShowRentedMovies_Click);
            }
        }

        private void btnListAllMovies_Click(object sender, EventArgs e)
        {
            Form1 allMoviesForm = new Form1();
            allMoviesForm.Show();
            this.Hide(); 
        }

        private void btnShowRentedMovies_Click(object sender, EventArgs e)
        {
            Form2 rentedMoviesForm = new Form2();
            rentedMoviesForm.Show();
            this.Hide();
        }
    }
}
