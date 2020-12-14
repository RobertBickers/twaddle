using Bickers.Twaddle.Generators;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Tests.UnitTesting.Credentials
{
    [TestFixture]
    public class CredentialTest
    {
        private readonly ICredentialGenerator _systemUnderTest;

        public CredentialTest()
        {
            _systemUnderTest = new CredentialGenerator();
        }

        [Test()]
        public void GenerateEmail_ProvidingDomain_ReturnValueEndsWithDomain()
        {
            string providedDomain = "@generatedTestMail.com";

            string emailAddress = _systemUnderTest.GenerateEmail(providedDomain, true);

            emailAddress.Should().NotBeNullOrWhiteSpace();
            emailAddress.Should().EndWith(providedDomain);
        }

        [Test()]
        public void GenerateEmail_WithoutDomain_ReturnValueHasValidEmail()
        {
            var defaultDomain = "twaddlemail.com";

            string emailAddress = _systemUnderTest.GenerateEmail(null, true);

            emailAddress.Should().NotBeNullOrWhiteSpace();
            emailAddress.Should().EndWith(defaultDomain);
        }

        [Test()]
        public void GeneratePassword_WithMaxPasswordLength100AndMin20_PasswordGeneratedWithMoreThan20LessThan100()
        {
            int maxCharacters = 100;
            int minCharacters = 20;

            Debug.WriteLine("Beginning stopwatch...");
            Stopwatch sw = Stopwatch.StartNew();
            Parallel.For(0, 5000, i =>
            {
                string password = _systemUnderTest.GeneratePassword(true, maxCharacters, minCharacters);
                Debug.WriteLine("Parallel - Generated password length: " + password.Length);
                password.Length.Should().BeInRange(20, 100);
            });
            sw.Stop();
            Debug.WriteLine(sw.ElapsedMilliseconds);
        }

        [Test()]
        public void GeneratePassword_WithMaxLength0_ExceptionThrown()
        {
            int maxCharacters = 0;

            Assert.Throws<ArgumentException>(() => _systemUnderTest.GeneratePassword(true, maxCharacters));
        }

        [Test()]
        public void GeneratePassword_MaxCharactersLessThanMinCharacters_ExceptionThrown()
        {
            int minCharacters = 10;
            int maxCharacters = 9;

            Assert.Throws<ArgumentException>(() => _systemUnderTest.GeneratePassword(true, maxCharacters, minCharacters));
        }

        [Test()]
        public void GeneratePassword_WithMinLength0_ExceptionThrown()
        {
            int minCharacters = 0;

            Assert.Throws<ArgumentException>(() => _systemUnderTest.GeneratePassword(true, 100, minCharacters));
        }
    }
}