using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{
    public partial class ProfileForm : Form
    {
        private Form previous;
        private UserData userData;
        private bool isEditUsername, isEditPassword, isEditAvatar;
        public ProfileForm(Form previous, UserData userData)
        {
            InitializeComponent();
            this.previous = previous;
            this.userData = userData;
            isEditUsername = false;
            isEditPassword = false;
            isEditAvatar = false;
            LoadUserData();
        }

        private void LoadUserData()
        {
            UsernameTextbox.Text = userData.Username;
            using (MemoryStream ms = new MemoryStream(userData.Img))
            {
                Avatar.Image = Image.FromStream(ms);
            }
            WinMatch.Text = userData.WinMatch.ToString();
            DrawMatch.Text = userData.DrawMatch.ToString();
            LoseMatch.Text = userData.LoseMatch.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            previous.Show();
        }

        private void EditPassword_Click(object sender, EventArgs e)
        {
            isEditPassword = !isEditPassword;
            PasswordTextbox.ReadOnly = !PasswordTextbox.ReadOnly;
            NewPwTextbox.Visible = !NewPwTextbox.Visible;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (isEditUsername)
            {
                if (UsernameTextbox.Text == userData.Username)
                {
                    ErrorString.Text = "*Your new username is your old username";
                    return;
                }
                
                if (UsernameTextbox.Text == "")
                {
                    ErrorString.Text = "*Your new username must not be blank";
                    return;
                }
            }

            if (isEditPassword)
            {
                if (SHA256Compute.ComputeSha256Hash(PasswordTextbox.Text) != userData.HashedPassword)
                {
                    ErrorString.Text = "*Incorrect password";
                    return;
                }

                if (NewPwTextbox.Text == "")
                {
                    ErrorString.Text = "*New password must not be blank";
                    return;
                }

                if (PasswordTextbox.Text == NewPwTextbox.Text)
                {
                    ErrorString.Text = "*Your new password is your old password";
                    return;
                }
            }

            if (isEditAvatar)
            {
                byte[] data;
                using (MemoryStream ms = new MemoryStream())
                {
                    Avatar.Image.Save(ms, Avatar.Image.RawFormat);
                    data = ms.ToArray();
                }

                if (data == userData.Img)
                {
                    ErrorString.Text = "*Your uploaded photo is already your avatar";
                    return;
                }
            }

            ErrorString.Text = "";

            if (isEditUsername) UpdateProfileAPI.UpdateUsername(userData, UsernameTextbox.Text);
            if (isEditPassword) UpdateProfileAPI.UpdatePassword(userData, NewPwTextbox.Text);
            if (isEditAvatar) UpdateProfileAPI.UpdateAvatar(userData, Avatar.Image);
        }

        private void AvatarButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Avatar Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    Avatar.Image = Image.FromFile(selectedFilePath);
                    Avatar.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            isEditAvatar = true;
        }

        private void EditUsername_Click(object sender, EventArgs e)
        {
            UsernameTextbox.ReadOnly = !UsernameTextbox.ReadOnly;
            isEditUsername = !isEditUsername;
        }
    }
}
