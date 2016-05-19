using System;
using System.Text.RegularExpressions;

namespace PasswordKata
{
    /// <summary>
    /// Class for Password Verification
    /// </summary>
    public class PasswordVerifier
    {
        private readonly string _password;
        public PasswordVerifier(string password)
        {
            this._password = password;
        }

        private Regex RegUppercaseCharacterMatcher = new Regex("[A-Z]");
        private Regex RegLowercaseCharacterMatcher = new Regex("[a-z]");
        private Regex RegDigitsMatcher = new Regex("[0-9]");

        /// <summary>
        /// Method to verify the password for various conditions
        /// </summary>
        /// <returns></returns>
        public bool Verify()
        {
            bool bFlag = false;
            try
            {
                //Check if password null/empty
                if (System.String.IsNullOrEmpty(_password))
                     Ensure.ArgumentCondition(false, "Password cannot be null or empty", _password);
                //Check if password length greater than 8
                if (_password.Trim().Length <8)
                    Ensure.ArgumentCondition(false, "Password Length less than 8", _password);
                //Checks if password contain atleast one Upper case letter
                if (RegUppercaseCharacterMatcher.Matches(_password).Count < 1)
                    Ensure.ArgumentCondition(false, "Uppercase letter not Present in Password", _password);
                //Checks if password contain atleast one Lower case letter
                if (RegLowercaseCharacterMatcher.Matches(_password).Count < 1)
                    Ensure.ArgumentCondition(false, "Lowercase letter not Present in Password", _password);
                //Checks if password contain atleast one Digit
                if (RegDigitsMatcher.Matches(_password).Count < 1)
                    Ensure.ArgumentCondition(false, "No Digits Present in Password", _password);
                else
                {
                    bFlag = true;
                }
                 
                return bFlag;
            }

            catch
            {
                return bFlag;

            }

        }

    }

}



