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
        public ProfileForm(Form previous, UserData userData)
        {
            InitializeComponent();
            this.previous = previous;
            this.userData = userData;
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

        private void EditUsername_Click(object sender, EventArgs e)
        {
            UsernameTextbox.ReadOnly = false;
        }

        private void EditPassword_Click(object sender, EventArgs e)
        {
            PasswordTextbox.ReadOnly = false;
            NewPwTextbox.Visible = true;
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
        }
    }
}
