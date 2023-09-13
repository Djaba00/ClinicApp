using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.HelperClasses
{
    public static class VaidationHelper
    {
        public static bool IsDateOfBirthIsValid(this DateTime? dateOfBirth)
        {
            if (dateOfBirth >= DateTime.MinValue && dateOfBirth <= DateTime.Today)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
