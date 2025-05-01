using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            DatabaseConnection.CheckConnectionDatabase();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this);
            this.Hide();
            registerForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextbox.Text;
            string password = PasswordTextbox.Text;

            string status = LoginAPI.Login(username, password);

            if (status != "200") ErrorString.Text = status;
            else
            {
                UserData userData = new UserData();
                userData = LoginAPI.getUserData(username);
                MessageBox.Show(userData.Username);
                /*HomepageForm homepage = new HomepageForm();
                this.Hide();
                homepage.Show();*/
            }
        }
    }
}
