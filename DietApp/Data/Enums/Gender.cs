using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.Data.Enums
{
    public enum Gender
    {
        Male,
        Female,
        [Display(Name = "Non-Binary")]
        NonBinary,
    }
}
