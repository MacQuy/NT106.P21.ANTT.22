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
    public partial class HomepageForm : Form
    {
        private UserData userData;
        public HomepageForm(UserData userData)
        {
            InitializeComponent();
            this.userData = userData;
            this.Activated += LoadUserData;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SingleButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm game = new GameForm();
            game.Show();
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomForm roomForm = new RoomForm(this);
            roomForm.Show();
        }

        private void AvatarClick(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm(this, userData);
            profileForm.Show();
        }

        private void LoadUserData(object sender, EventArgs e)
        {
            Username.Text = userData.Username;
            using (MemoryStream ms = new MemoryStream(userData.Img))
            {
                Avatar.Image = Image.FromStream(ms);
            }
        }
    }
}
