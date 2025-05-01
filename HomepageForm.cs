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
    public partial class HomepageForm : Form
    {
        public HomepageForm()
        {
            InitializeComponent();
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

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm(this);
            profileForm.Show();
        }
    }
}
