using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethmi_Holdings
{
    static class Validation
    {
        public static Boolean isStringWithoutNumbers(String input) {
            return !input.Any(c => char.IsDigit(c));
        }

        public static Boolean isNumber(String input)
        {

            if (System.Text.RegularExpressions.Regex.Match(input, @"^\d+(\.\d{1,2})?$").Success)
            {
                return true;
            }
            return false;
        }

        public static Boolean IsValidEmail(String input)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(input);
                return addr.Address == input;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean IsPhoneNumber(String input){
            return System.Text.RegularExpressions.Regex.Match(input, @"^(\+[0-9]{9})$").Success;
        }

    }
}
