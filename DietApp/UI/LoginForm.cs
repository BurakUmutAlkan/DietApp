using DietApp.Data;
using DietApp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp
{
    public partial class LoginForm : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        #region Methods

        private void ClearForm()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void GoToRegisterForm()
        {
            var form = new RegisterFormLoginPart(db);
            form.Show();
            Hide();
        }

        private void GoToPasswordResetForm()
        {
            var form = new PasswordResetForm(db);
            form.Show();
            Hide();
        }

        private void GoToMainForm(bool isValid)
        {
            if (isValid)
            {
                var form = new MainForm(db);
                form.Show();
                Hide();
            }
            else
                return;
        }

        private bool CheckLoginCredentials()
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = db.Users.FirstOrDefault(u => u.Email == email);

            if (user == null || password != user.Password)
            {
                MessageBox.Show("Please check your login credentials.");
                return false;
            }
            else
                return true;
        }

        private void ChangePasswordVisibility()
        {
            if (btnPasswordVisibility.Text == "Show")
            {
                txtPassword.PasswordChar = new char();
                btnPasswordVisibility.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnPasswordVisibility.Text = "Show";
            }
        }

        #endregion

        #region Events

        private void btnGoToMainForm_Click(object sender, EventArgs e)
        {
            bool isValid = CheckLoginCredentials();
            ClearForm();
            GoToMainForm(isValid);
        }

        private void btnGoToRegisterForm_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToRegisterForm();
        }

        private void btnGoToPasswordResetForm_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToPasswordResetForm();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnPasswordVisibility_Click(object sender, EventArgs e)
        {
            ChangePasswordVisibility();
        }

        #endregion
    }
}
