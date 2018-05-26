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

        public static Boolean isValidNIC(String input)
        {

            if (System.Text.RegularExpressions.Regex.Match(input, @"^[0-9]{9}[x|X|v|V]$").Success)
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

        public static Boolean isPhoneNumber(String input)
        {
            if (System.Text.RegularExpressions.Regex.Match(input, @"^\d+(\d{1,2})?$").Success && input.Length == 10)
            {
                return true;
            }
            return false;
        }

        public static Boolean isValidUser(String username, String password) {
            Database db = new Database();
            String pwd = "";
            pwd = db.getValue("SELECT password FROM UserDetails where username='"+username+"'");
            if (pwd != "")
            {
                if (pwd == password)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }

    }
}
