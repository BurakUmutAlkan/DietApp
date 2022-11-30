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
    public partial class PasswordResetForm : Form
    {
        private readonly ApplicationDbContext _db;

        public PasswordResetForm(ApplicationDbContext db)
        {
            InitializeComponent();
            _db = db;
        }
    }
}
