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
                guna2CirclePictureBox1.Image = Image.FromStream(ms);
            }
            WinMatch.Text = userData.WinMatch.ToString();
            DrawMatch.Text = userData.DrawMatch.ToString();
            LoseMatch.Text = userData.LoseMatch.ToString();
        }
    }
}
