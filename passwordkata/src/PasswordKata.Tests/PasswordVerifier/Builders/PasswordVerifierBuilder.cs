using System;

namespace PasswordKata.Tests
{
    /// <summary>
    /// Builder class for password verification
    /// </summary>
    public sealed class PasswordVerifierBuilder : IBuilder
    {
        private readonly PasswordVerifier _passwordVerifier;
        private string _password;
        public PasswordVerifierBuilder()
        {
        }

        public PasswordVerifier Build() => new PasswordVerifier(_password);

        public PasswordVerifierBuilder WithPassword(string password) => this.With(ref _password, password);

        public static implicit operator PasswordVerifier(PasswordVerifierBuilder builder) => builder.Build();
    }

}

