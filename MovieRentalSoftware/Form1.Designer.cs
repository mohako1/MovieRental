namespace MovieRentalSoftware
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.signinButton = new Guna.UI2.WinForms.Guna2Button();
            this.AdminButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.BorderColor = System.Drawing.Color.DimGray;
            this.loginButton.BorderRadius = 5;
            this.loginButton.BorderThickness = 3;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.LightGray;
            this.loginButton.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginButton.Location = new System.Drawing.Point(259, 179);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(328, 80);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "login";
            this.loginButton.Click += new System.EventHandler(this.login_Click);
            // 
            // signinButton
            // 
            this.signinButton.Animated = true;
            this.signinButton.BorderColor = System.Drawing.Color.DimGray;
            this.signinButton.BorderRadius = 5;
            this.signinButton.BorderThickness = 3;
            this.signinButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signinButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signinButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signinButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signinButton.FillColor = System.Drawing.Color.LightGray;
            this.signinButton.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold);
            this.signinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signinButton.HoverState.BorderColor = System.Drawing.Color.White;
            this.signinButton.Location = new System.Drawing.Point(259, 47);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(328, 80);
            this.signinButton.TabIndex = 3;
            this.signinButton.Text = "sign up";
            this.signinButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Animated = true;
            this.AdminButton.BorderColor = System.Drawing.Color.DimGray;
            this.AdminButton.BorderRadius = 5;
            this.AdminButton.BorderThickness = 3;
            this.AdminButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AdminButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AdminButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AdminButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AdminButton.FillColor = System.Drawing.Color.LightGray;
            this.AdminButton.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminButton.Location = new System.Drawing.Point(259, 314);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(328, 80);
            this.AdminButton.TabIndex = 4;
            this.AdminButton.Text = "login as Admin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 426);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2Button signinButton;
        private Guna.UI2.WinForms.Guna2Button AdminButton;
    }
}

