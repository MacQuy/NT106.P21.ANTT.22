using System.Windows.Forms;

namespace NT106
{
    partial class RegisterForm
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
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            this.ConfirmTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AvatarButton = new Guna.UI2.WinForms.Guna2Button();
            this.BackButton = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ExitButton = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ChessIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CheckImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.UserImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PassImg = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChessIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckImg)).BeginInit();
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
            this.UsernameTextbox.Location = new System.Drawing.Point(111, 108);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UsernameTextbox.PlaceholderText = "Username";
            this.UsernameTextbox.SelectedText = "";
            this.UsernameTextbox.Size = new System.Drawing.Size(423, 48);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(208, 72);
            this.Title.TabIndex = 3;
            this.Title.Text = "Register";
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
            this.PasswordTextbox.Location = new System.Drawing.Point(111, 185);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PasswordTextbox.PlaceholderText = "Password";
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.Size = new System.Drawing.Size(423, 48);
            this.PasswordTextbox.TabIndex = 4;
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
            this.RegisterButton.Location = new System.Drawing.Point(355, 466);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(180, 46);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Register";
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.BorderRadius = 10;
            this.ConfirmTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmTextBox.DefaultText = "";
            this.ConfirmTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConfirmTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConfirmTextBox.Location = new System.Drawing.Point(111, 260);
            this.ConfirmTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.PasswordChar = '*';
            this.ConfirmTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ConfirmTextBox.PlaceholderText = "Enter password again";
            this.ConfirmTextBox.SelectedText = "";
            this.ConfirmTextBox.Size = new System.Drawing.Size(423, 48);
            this.ConfirmTextBox.TabIndex = 9;
            // 
            // AvatarButton
            // 
            this.AvatarButton.BorderRadius = 10;
            this.AvatarButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AvatarButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AvatarButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AvatarButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AvatarButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(70)))), ((int)(((byte)(84)))));
            this.AvatarButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AvatarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(241)))));
            this.AvatarButton.Location = new System.Drawing.Point(616, 360);
            this.AvatarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvatarButton.Name = "AvatarButton";
            this.AvatarButton.Size = new System.Drawing.Size(180, 46);
            this.AvatarButton.TabIndex = 11;
            this.AvatarButton.Text = "Upload your avatar";
            // 
            // BackButton
            // 
            this.BackButton.Image = global::NT106.Properties.Resources.Back;
            this.BackButton.ImageRotate = 0F;
            this.BackButton.Location = new System.Drawing.Point(25, 475);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BackButton.Size = new System.Drawing.Size(40, 37);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackButton.TabIndex = 16;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Image = global::NT106.Properties.Resources.Exit;
            this.ExitButton.ImageRotate = 0F;
            this.ExitButton.Location = new System.Drawing.Point(843, 15);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ExitButton.Size = new System.Drawing.Size(40, 37);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 15;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::NT106.Properties.Resources.Avatar;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(583, 92);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(250, 250);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 14;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // ChessIcon
            // 
            this.ChessIcon.Image = global::NT106.Properties.Resources.ChessIcon;
            this.ChessIcon.ImageRotate = 0F;
            this.ChessIcon.Location = new System.Drawing.Point(228, 9);
            this.ChessIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChessIcon.Name = "ChessIcon";
            this.ChessIcon.Size = new System.Drawing.Size(72, 71);
            this.ChessIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChessIcon.TabIndex = 13;
            this.ChessIcon.TabStop = false;
            // 
            // CheckImg
            // 
            this.CheckImg.Image = global::NT106.Properties.Resources.Check;
            this.CheckImg.ImageRotate = 0F;
            this.CheckImg.Location = new System.Drawing.Point(24, 260);
            this.CheckImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckImg.Name = "CheckImg";
            this.CheckImg.Size = new System.Drawing.Size(48, 48);
            this.CheckImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckImg.TabIndex = 10;
            this.CheckImg.TabStop = false;
            // 
            // UserImg
            // 
            this.UserImg.BackColor = System.Drawing.Color.Transparent;
            this.UserImg.Image = global::NT106.Properties.Resources.User;
            this.UserImg.ImageRotate = 0F;
            this.UserImg.Location = new System.Drawing.Point(24, 108);
            this.UserImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserImg.Name = "UserImg";
            this.UserImg.Size = new System.Drawing.Size(48, 48);
            this.UserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserImg.TabIndex = 8;
            this.UserImg.TabStop = false;
            // 
            // PassImg
            // 
            this.PassImg.Image = global::NT106.Properties.Resources.Password;
            this.PassImg.ImageRotate = 0F;
            this.PassImg.Location = new System.Drawing.Point(24, 185);
            this.PassImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassImg.Name = "PassImg";
            this.PassImg.Size = new System.Drawing.Size(48, 48);
            this.PassImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassImg.TabIndex = 7;
            this.PassImg.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(899, 535);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.ChessIcon);
            this.Controls.Add(this.AvatarButton);
            this.Controls.Add(this.CheckImg);
            this.Controls.Add(this.ConfirmTextBox);
            this.Controls.Add(this.UserImg);
            this.Controls.Add(this.PassImg);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.UsernameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChessIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox UsernameTextbox;
        private Label Title;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
        private Guna.UI2.WinForms.Guna2PictureBox PassImg;
        private Guna.UI2.WinForms.Guna2PictureBox UserImg;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmTextBox;
        private Guna.UI2.WinForms.Guna2PictureBox CheckImg;
        private Guna.UI2.WinForms.Guna2Button AvatarButton;
        private Guna.UI2.WinForms.Guna2PictureBox ChessIcon;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ExitButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox BackButton;
    }
}