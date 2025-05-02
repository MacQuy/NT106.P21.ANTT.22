using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{
    public partial class RegisterForm : Form
    {
        private Form previous;
        public RegisterForm(Form previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            previous.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text;
            string password = PasswordTextbox.Text;
            string check = ConfirmTextBox.Text;

            string status = RegisterAPI.Register(username, password, check, Avatar.Image);
            if (status != "200") ErrorString.Text = status;
            else
            {
                this.Hide();
                previous.Show();
            }
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
