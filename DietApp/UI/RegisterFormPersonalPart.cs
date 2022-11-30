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
    public partial class RegisterFormPersonalPart : Form
    {
        private readonly ApplicationDbContext _db;
        private readonly string _email;
        private readonly string _password;

        public RegisterFormPersonalPart(ApplicationDbContext db, string email, string password)
        {
            InitializeComponent();
            _db = db;
            _email = email;
            _password = password;
        }
    }
}
