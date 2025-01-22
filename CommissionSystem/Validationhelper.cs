using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommissionSystem
{
    internal class Validationhelper
    {
        // Regex to match SSN in the format of xxx-xx-xxxx
        public static bool IsValidSSN(string ssn)
        { 
            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            return Regex.IsMatch(ssn, pattern);
        }

        public static bool IsValidCommissionRate(decimal commissionRate)
        { return commissionRate > 0; }

        // method to validate a postive decimal value (for salary, sales, etc.)
        public static bool IsValidPositiveDecimal(decimal value)
            { return value >= 0; }
    }
}
