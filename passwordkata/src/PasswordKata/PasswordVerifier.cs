﻿using System;
using System.Text.RegularExpressions;

namespace PasswordKata
{
    /// <summary>
    /// Class for verifying the password 
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
            string strMsg = string.Empty;
            int iCount = 0;
            try
            {
                // Check if password not null or empty 
                if (!(System.String.IsNullOrEmpty(_password)))
                    ++iCount;
                else
                    strMsg += "Password cannot be empty ";

                //Check if password length greater than eight
                if (_password.Trim().Length > 8)
                    ++iCount;
                else
                    strMsg += " And length less than eight ";

                //Check if password has atleast one upper case letter
                if (RegUppercaseCharacterMatcher.Matches(_password).Count >= 1)
                    ++iCount;
                else
                    strMsg += " Or should containt atleast one Upper Case letter ";

                // Check if password has atleast one lower case letter
                if (RegLowercaseCharacterMatcher.Matches(_password).Count >= 1)
                    ++iCount;
                else
                    strMsg += " Or should containt atleast one Lower Case letter ";

                // Check if password has atleast one digit
                if (RegDigitsMatcher.Matches(_password).Count >= 1)
                    ++iCount;
                else
                    strMsg += " Or should containt atleast one Digit ";
                //Check if atleast 3 of criteria are matching in the provided password
                if (iCount > 3)
                    return true;
                else
                    Ensure.ArgumentCondition(false, strMsg, _password);
                return false;
            }

            catch
            {
                return false;

            }
        }

    }

}






