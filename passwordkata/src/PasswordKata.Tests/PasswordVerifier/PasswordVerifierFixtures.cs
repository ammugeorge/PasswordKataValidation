﻿using System;
using Xunit;
using FluentAssertions;

namespace PasswordKata.Tests
{
    /// <summary>
    /// Test methods for Password Verification
    /// </summary>
	public class PasswordVerifierFixtures
    {
        /// <summary>
        /// To validate if password is not empty/null
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Infy12345", true)]
        [InlineData(null, false)]
        [InlineData("", false)]
        public void Password_NotNull(string password, bool expected)
        {
            var sut = new PasswordVerifierBuilder().WithPassword(password).Build();
            sut.Verify().Should().Be(expected);

        }
        /// <summary>
        /// To validate if size of password is greater than 8
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Infy12345", true)]
        [InlineData("test", false)]
        [InlineData("Infosy#567", true)]
        [InlineData("hi", false)]

        public void Password_Should_Be_Larger_Than_8_Chars(string password, bool expected)
        {
            var sut = new PasswordVerifierBuilder().WithPassword(password).Build();
            sut.Verify().Should().Be(expected);
        }
        /// <summary>
        /// To validate if password contains atleast one Upper Case letter
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Infy12345I", true)]
        [InlineData("infy12345", false)]
        [InlineData("Infy12345", true)]
        public void Password_Contain_One_UpperCase(string password, bool expected)
        {
            var sut = new PasswordVerifierBuilder().WithPassword(password).Build();
            sut.Verify().Should().Be(expected);
        }


        /// <summary>
        /// To validate if password contains atleast one Lower Case letter
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Infy12345", true)]
        [InlineData("INFY12345", true)]
        [InlineData("INFy12345", true)]
        public void Password_Contain_One_LowerCase(string password, bool expected)
        {
            var sut = new PasswordVerifierBuilder().WithPassword(password).Build();
            sut.Verify().Should().Be(expected);

        }
        /// <summary>
        /// To validate if password contains atleast one Digit
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Infy12345", true)]
        [InlineData("Infyfosyslimiedt1", true)]
        [InlineData("INFY", false)]
        public void Password_Contain_One_Digit(string password, bool expected)
        {
            var sut = new PasswordVerifierBuilder().WithPassword(password).Build();
            sut.Verify().Should().Be(expected);

        }


        /// <summary>
        /// To validate if password has atleast 3 out following conditions
        /// 1. Length greater than 8
        /// 2. Atleast one UpperCase Letter
        /// 3. Atleast one LowerCase Letter
        /// 4. Atleast one digit
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Infy12345", true)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("infy12345", false)]
        [InlineData("12345678", false)]
        [InlineData("infosyslimited", false)]
        [InlineData("Infosyslimited", true)]
        [InlineData("INFOSYS123", true)]
        public void Password_Check_Feature2(string password, bool expected)
        {
            var sut = new PasswordVerifierBuilder().WithPassword(password).Build();
            sut.Verify().Should().Be(expected);
        }

        /// <summary>
        /// To validate if the password contain Upper case 
        /// </summary>
        /// <param name="password"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("Infy12345", true)]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("infy12345", false)]
        public void Password_Check_Feature3(string password, bool expected)
        {
            var sut = new PasswordVerifierBuilder().WithPassword(password).Build();
            sut.Verify().Should().Be(expected);
        }
    }
}
