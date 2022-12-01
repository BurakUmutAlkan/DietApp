using DietApp.Data;
using DietApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DietApp.UI
{
    public partial class RegisterFormPersonalPart : Form
    {
        private readonly ApplicationDbContext _db;
        private readonly string _email;
        private readonly string _password;
        private string firstName;
        private string lastName;
        private Gender gender;

        public RegisterFormPersonalPart(ApplicationDbContext db, string email, string password)
        {
            InitializeComponent();
            ClearForm();
            rbMale.Checked = true;
            _db = db;
            _email = email;
            _password = password;
        }

        #region Methods

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();

            rbFemale.Checked = false;
            rbMale.Checked = false;
            rbNonBinary.Checked = false;
        }

        private bool CheckAndAssignValues()
        {
            firstName = txtFirstName.Text.Trim();
            lastName = txtLastName.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("First name area cannot be empty.", "Invalid Email!");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Last name area cannot be empty.", "Invalid Password");
                return false;
            }
            else
                return true;
        }

        private void GoToRegisterFormLoginPart()
        {
            var form = new RegisterFormLoginPart(_db);
            form.Show();
            Hide();
        }

        private void GoToRegisterFormBodyInfoPart(bool isValid)
        {
            if (isValid)
            {
                var form = new RegisterFormBodyInfoPart(_db, _email, _password, firstName, lastName, gender);
                form.Show();
                Hide();
            }
            else
                return;
        }

        #endregion

        #region Events

        private void RegisterFormPersonalPart_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            GoToRegisterFormLoginPart();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool isValid = CheckAndAssignValues();
            ClearForm();
            GoToRegisterFormBodyInfoPart(isValid);
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            gender = Gender.Male;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            gender = Gender.Female;
        }

        private void rbNonBinary_Click(object sender, EventArgs e)
        {
            gender = Gender.NonBinary;
        }

        #endregion
    }
}
