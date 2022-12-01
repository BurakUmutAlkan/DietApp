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

namespace DietApp.UI
{
    public partial class RegisterFormBodyInfoPart : Form
    {
        private readonly ApplicationDbContext _db;
        private readonly string _email;
        private readonly string _password;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly Gender _gender;

        public RegisterFormBodyInfoPart(ApplicationDbContext db, string email, string password, string firstName, string lastName, Gender gender)
        {
            InitializeComponent();
            _db = db;
            _email = email;
            _password = password;
            _firstName = firstName;
            _lastName = lastName;
            _gender = gender;
        }
    }
}
