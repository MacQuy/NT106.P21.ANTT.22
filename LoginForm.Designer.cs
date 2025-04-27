using System.Windows.Forms;

namespace NT106
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
            this.UsernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.ExitButton = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ChessIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.UserImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PassImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChessIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassImg)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.BorderRadius = 10;
            this.UsernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextbox.DefaultText = "";
            this.UsernameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UsernameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextbox.Location = new System.Drawing.Point(180, 186);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UsernameTextbox.PlaceholderText = "Username";
            this.UsernameTextbox.SelectedText = "";
            this.UsernameTextbox.Size = new System.Drawing.Size(317, 39);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Title.Location = new System.Drawing.Point(235, 19);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(362, 117);
            this.Title.TabIndex = 3;
            this.Title.Text = "Chess AI";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BorderRadius = 10;
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.DefaultText = "";
            this.PasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.Location = new System.Drawing.Point(180, 261);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PasswordTextbox.PlaceholderText = "Password";
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.Size = new System.Drawing.Size(317, 39);
            this.PasswordTextbox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.BorderRadius = 10;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.LoginButton.Location = new System.Drawing.Point(266, 322);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(135, 37);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            // 
            // ExitButton
            // 
            this.ExitButton.Image = global::NT106.Properties.Resources.Exit;
            this.ExitButton.ImageRotate = 0F;
            this.ExitButton.Location = new System.Drawing.Point(632, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButton.Size = new System.Drawing.Size(30, 30);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 10;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChessIcon
            // 
            this.ChessIcon.Image = global::NT106.Properties.Resources.ChessIcon;
            this.ChessIcon.ImageRotate = 0F;
            this.ChessIcon.Location = new System.Drawing.Point(108, 19);
            this.ChessIcon.Margin = new System.Windows.Forms.Padding(2);
            this.ChessIcon.Name = "ChessIcon";
            this.ChessIcon.Size = new System.Drawing.Size(110, 119);
            this.ChessIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChessIcon.TabIndex = 9;
            this.ChessIcon.TabStop = false;
            // 
            // UserImg
            // 
            this.UserImg.BackColor = System.Drawing.Color.Transparent;
            this.UserImg.Image = global::NT106.Properties.Resources.User;
            this.UserImg.ImageRotate = 0F;
            this.UserImg.Location = new System.Drawing.Point(122, 186);
            this.UserImg.Margin = new System.Windows.Forms.Padding(2);
            this.UserImg.Name = "UserImg";
            this.UserImg.Size = new System.Drawing.Size(36, 39);
            this.UserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserImg.TabIndex = 8;
            this.UserImg.TabStop = false;
            // 
            // PassImg
            // 
            this.PassImg.Image = global::NT106.Properties.Resources.Password;
            this.PassImg.ImageRotate = 0F;
            this.PassImg.Location = new System.Drawing.Point(122, 261);
            this.PassImg.Margin = new System.Windows.Forms.Padding(2);
            this.PassImg.Name = "PassImg";
            this.PassImg.Size = new System.Drawing.Size(36, 39);
            this.PassImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassImg.TabIndex = 7;
            this.PassImg.TabStop = false;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BorderRadius = 10;
            this.RegisterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.RegisterButton.Location = new System.Drawing.Point(266, 387);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(135, 37);
            this.RegisterButton.TabIndex = 11;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(674, 435);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ChessIcon);
            this.Controls.Add(this.UserImg);
            this.Controls.Add(this.PassImg);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.UsernameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChessIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextbox;
        private Label Title;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2PictureBox PassImg;
        private Guna.UI2.WinForms.Guna2PictureBox UserImg;
        private Guna.UI2.WinForms.Guna2PictureBox ChessIcon;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ExitButton;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
    }
}

