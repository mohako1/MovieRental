namespace MovieRentalSoftware
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListAllMovies = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowRentedMovies = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnListAllMovies
            // 
            this.btnListAllMovies.Animated = true;
            this.btnListAllMovies.BorderColor = System.Drawing.Color.DimGray;
            this.btnListAllMovies.BorderRadius = 5;
            this.btnListAllMovies.BorderThickness = 3;
            this.btnListAllMovies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListAllMovies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListAllMovies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListAllMovies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListAllMovies.FillColor = System.Drawing.Color.LightGray;
            this.btnListAllMovies.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnListAllMovies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListAllMovies.Location = new System.Drawing.Point(221, 107);
            this.btnListAllMovies.Name = "btnListAllMovies";
            this.btnListAllMovies.Size = new System.Drawing.Size(328, 80);
            this.btnListAllMovies.TabIndex = 4;
            this.btnListAllMovies.Text = "List All Movies";
            this.btnListAllMovies.Click += new System.EventHandler(this.btnListAllMovies_Click);
            // 
            // btnShowRentedMovies
            // 
            this.btnShowRentedMovies.Animated = true;
            this.btnShowRentedMovies.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowRentedMovies.BorderRadius = 5;
            this.btnShowRentedMovies.BorderThickness = 3;
            this.btnShowRentedMovies.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowRentedMovies.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowRentedMovies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowRentedMovies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowRentedMovies.FillColor = System.Drawing.Color.LightGray;
            this.btnShowRentedMovies.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnShowRentedMovies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowRentedMovies.Location = new System.Drawing.Point(221, 274);
            this.btnShowRentedMovies.Name = "btnShowRentedMovies";
            this.btnShowRentedMovies.Size = new System.Drawing.Size(328, 80);
            this.btnShowRentedMovies.TabIndex = 5;
            this.btnShowRentedMovies.Text = "Show My Rented Movies";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowRentedMovies);
            this.Controls.Add(this.btnListAllMovies);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnListAllMovies;
        private Guna.UI2.WinForms.Guna2Button btnShowRentedMovies;
    }
}