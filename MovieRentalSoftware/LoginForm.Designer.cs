namespace MovieRentalSoftware
{
    partial class LoginForm
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
            this.txtLoginName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLoginSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtLoginPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtLoginName
            // 
            this.txtLoginName.BorderColor = System.Drawing.Color.DimGray;
            this.txtLoginName.BorderRadius = 5;
            this.txtLoginName.BorderThickness = 3;
            this.txtLoginName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginName.DefaultText = "";
            this.txtLoginName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginName.FillColor = System.Drawing.Color.LightGray;
            this.txtLoginName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginName.Location = new System.Drawing.Point(193, 45);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLoginName.PlaceholderText = "Name";
            this.txtLoginName.SelectedText = "";
            this.txtLoginName.Size = new System.Drawing.Size(419, 59);
            this.txtLoginName.TabIndex = 3;
            this.txtLoginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoginSubmit
            // 
            this.btnLoginSubmit.BorderColor = System.Drawing.Color.DimGray;
            this.btnLoginSubmit.BorderRadius = 5;
            this.btnLoginSubmit.BorderThickness = 2;
            this.btnLoginSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoginSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoginSubmit.FillColor = System.Drawing.Color.LightGray;
            this.btnLoginSubmit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnLoginSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnLoginSubmit.Location = new System.Drawing.Point(298, 283);
            this.btnLoginSubmit.Name = "btnLoginSubmit";
            this.btnLoginSubmit.Size = new System.Drawing.Size(191, 51);
            this.btnLoginSubmit.TabIndex = 9;
            this.btnLoginSubmit.Text = "Login";
            this.btnLoginSubmit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnLoginSubmit.Click += new System.EventHandler(this.btnLoginSubmit_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BorderColor = System.Drawing.Color.DimGray;
            this.txtLoginPassword.BorderRadius = 5;
            this.txtLoginPassword.BorderThickness = 3;
            this.txtLoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginPassword.DefaultText = "";
            this.txtLoginPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginPassword.FillColor = System.Drawing.Color.LightGray;
            this.txtLoginPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginPassword.Location = new System.Drawing.Point(193, 155);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLoginPassword.PlaceholderText = "Password";
            this.txtLoginPassword.SelectedText = "";
            this.txtLoginPassword.Size = new System.Drawing.Size(419, 59);
            this.txtLoginPassword.TabIndex = 10;
            this.txtLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.btnLoginSubmit);
            this.Controls.Add(this.txtLoginName);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtLoginName;
        private Guna.UI2.WinForms.Guna2Button btnLoginSubmit;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginPassword;
    }
}