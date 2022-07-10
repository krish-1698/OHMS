using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OHMS
{
    class validation
    {
        public static string validateName = "^[A-Za-z ]{3,}$";
        //private static string validateUserName = "^[A-Za-z0-9]+$";
        public static string validateNEWNIC ="^[0-9]{4}[01235678]{1}[0-9]{7}$";

        public static string validateMobileNumber = "^[0]{1}[0-9]{9}$";
        public static string validateOLDNIC = "^[0-9]{2}[01235678]{1}[0-9]{6}[vVxX]{1}$";

        // gender vise validate NIC
       // public static string validatemaleNEWNIC = "^[0-9]{4}[0123]{1}[0-9]{7}$";
       // public static string validatemaleOLDCustomerNIC = "^[0-9]{2}[0123]{1}[0-9]{6}[VX]{1}$";
        // public static string validatefemaleNEWCustomerNIC = "^[0-9]{4}[5678]{1}[0-9]{7}$";
        // public static string validatefemaleOLDCustomerNIC = "^[0-9]{2}[5678]{1}[0-9]{6}[VX]{1}$";

        public static string validateEmail = "^[a-zA-Z0-9.-_]{1,30}[@]{1}[a-z.]{1,10}[.]{1}[a-z]{2,3}$";



        public static bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, validateEmail);
        }

        public static bool ValidName(string cusname)
        {
            return Regex.IsMatch(cusname, validateName);
        }

        public static bool ValidMobile(string mobilenumber)
        {
            return Regex.IsMatch(mobilenumber, validateMobileNumber);
        }

        public static bool ValidOldNIC(string nic)
        {
            return Regex.IsMatch(nic, validateOLDNIC);
        }

        public static bool ValidNewNIC(string nic)
        {
            return Regex.IsMatch(nic, validateNEWNIC);
        }

    }
}
