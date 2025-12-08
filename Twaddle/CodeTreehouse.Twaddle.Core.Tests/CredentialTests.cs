using CodeTreehouse.Twaddle.Core.Credentials;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CodeTreehouse.Twaddle.Core.Tests
{
    [TestClass]
    public class CredentialTest
    {
        private readonly ICredentialGenerator _systemUnderTest;

        public CredentialTest()
        {
            _systemUnderTest = new CredentialGenerator();
        }

        [TestMethod]
        public void GenerateEmail_ProvidingDomain_ReturnValueEndsWithDomain()
        {
            string providedDomain = "@generatedTestMail.com";

            string emailAddress = _systemUnderTest.GenerateEmail(providedDomain, true);

            Assert.IsFalse(string.IsNullOrWhiteSpace(emailAddress));
            StringAssert.EndsWith(emailAddress, providedDomain);
        }

        [TestMethod]
        public void GenerateEmail_WithoutDomain_ReturnValueHasValidEmail()
        {
            var defaultDomain = "twaddlemail.com";

            string emailAddress = _systemUnderTest.GenerateEmail((string?)null, true);

            Assert.IsFalse(string.IsNullOrWhiteSpace(emailAddress));
            StringAssert.EndsWith(emailAddress, defaultDomain);
        }

        [TestMethod]
        public void GeneratePassword_WithMaxPasswordLength100AndMin20_PasswordGeneratedWithMoreThan20LessThan100()
        {
            int maxCharacters = 100;
            int minCharacters = 20;

            Debug.WriteLine("Beginning stopwatch...");
            Stopwatch sw = Stopwatch.StartNew();
            Parallel.For(0, 5000, i => {
                string password = _systemUnderTest.GeneratePassword(true, maxCharacters, minCharacters);
                Debug.WriteLine("Parallel - Generated password length: " + password.Length);
                Assert.IsTrue(password.Length >= 20 && password.Length <= 100);
            });
            sw.Stop();
            Debug.WriteLine(sw.ElapsedMilliseconds);
        }

        [TestMethod]
        public void GeneratePassword_WithMaxLength0_ExceptionThrown()
        {
            int maxCharacters = 0;

            Assert.ThrowsExactly<ArgumentException>(() => _systemUnderTest.GeneratePassword(true, maxCharacters));
        }

        [TestMethod]
        public void GeneratePassword_MaxCharactersLessThanMinCharacters_ExceptionThrown()
        {
            int minCharacters = 10;
            int maxCharacters = 9;

            Assert.ThrowsExactly<ArgumentException>(() => _systemUnderTest.GeneratePassword(true, maxCharacters, minCharacters));
        }

        [TestMethod]
        public void GeneratePassword_WithMinLength0_ExceptionThrown()
        {
            int minCharacters = 0;

            Assert.ThrowsExactly<ArgumentException>(() => _systemUnderTest.GeneratePassword(true, 100, minCharacters));
        }
    }
}