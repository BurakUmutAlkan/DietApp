using DietApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp.UI
{
    public partial class RegisterFormLoginPart : Form
    {
        private readonly ApplicationDbContext _db;
        private string email;
        private string password;

        public RegisterFormLoginPart(ApplicationDbContext db)
        {
            InitializeComponent();
            _db = db;
        }

        #region Methods

        private void ClearForm()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private bool CheckAndAssignValues()
        {
            email = txtEmail.Text.Trim();
            password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email area cannot be empty.", "Invalid Email!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password area cannot be empty.", "Invalid Password");
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

        private void GoToLoginForm()
        {
            var form = new LoginForm();
            form.Show();
            Hide();
        }

        private void GoToRegisterFormPersonalPart(bool isValid)
        {
            if (isValid)
            {
                var form = new RegisterFormPersonalPart(_db, email, password);
                form.Show();
                Hide();
            }
            else
                return;
        }

        #endregion

        #region Events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToLoginForm();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool isValid = CheckAndAssignValues();
            ClearForm();
            GoToRegisterFormPersonalPart(isValid);
        }

        private void btnPasswordVisibility_Click(object sender, EventArgs e)
        {
            ChangePasswordVisibility();
        }

        private void RegisterFormLoginPart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion
    }
}
