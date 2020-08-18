using Bickers.Twaddle.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.UnitTesting.WordMaker
{
    [TestClass]
    public class CredentialTest
    {
        [TestMethod()]
        public void GenerateEmail_ProvidingDomain_ReturnValueEndsWithDomain()
        {
            //Arrange
            string endDomain = "@generatedTestMail.com";

            string emailAddress = Twaddle.Profile.GenerateEmail(endDomain, true);

            Assert.IsNotNull(emailAddress, "Returned email address returned null");
            Assert.IsTrue(emailAddress.EndsWith(endDomain), "Email address does not end with the domain provided as expected");
        }

        [TestMethod()]
        public void GenerateEmail_WithoutDomain_ReturnValueHasValidEmail()
        {
            //Arrange
            string emailAddress = Twaddle.Profile.GenerateEmail(null, true);

            Assert.IsNotNull(emailAddress, "Returned email address returned null");
            Assert.IsTrue(emailAddress.EndsWith("twaddlemail.com"), "Email address does not end with the domain provided as expected");
        }

        [TestMethod()]
        public void GeneratePassword_WithMaxPasswordLength100AndMin20_PasswordGeneratedWithMoreThan20LessThan100()
        {
            int maxCharacters = 100;
            int minCharacters = 20;

            Stopwatch sw = new Stopwatch();
            Debug.WriteLine("Beginning stopwatch...");
            sw.Start();
            Parallel.For(0, 5000, i =>
            {
                string password = Twaddle.Profile.GeneratePassword(true, maxCharacters, minCharacters);
                Debug.WriteLine("Parallel - Generated password length: " + password.Length);
                Assert.IsTrue(password.Length >= 20 && password.Length <= 100, "Password was generated with length out of bounds");
                Thread.Sleep(10);
            });
            sw.Stop();
            Debug.WriteLine(sw.ElapsedMilliseconds);

            //Debug.WriteLine("Restarting stopwatch...");
            //sw.Restart();
            //for (int i = 0; i < 10000; i++)
            //{
            //    string password = Twaddle.Profile.GeneratePassword(true, maxCharacters, minCharacters);
            //    Debug.WriteLine("Standard - Generated password length: " + password.Length);
            //    Assert.IsTrue(password.Length >= 20 && password.Length <= 100, "Password was generated with length out of bounds");

            //    Thread.Sleep(10);
            //}
            //sw.Stop();
            //Debug.WriteLine(sw.ElapsedMilliseconds);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Method allowed user to enter 0 as max characters.")]
        public void GeneratePassword_WithMaxLength0_ExceptionThrown()
        {
            int maxCharacters = 0;

            string password = Twaddle.Profile.GeneratePassword(true, maxCharacters);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Max length less than min length args allowed")]
        public void GeneratePassword_MaxCharactersLessThanMinCharacters_ExceptionThrown()
        {
            int minCharacters = 10;
            int maxCharacters = 9;

            string password = Twaddle.Profile.GeneratePassword(true, maxCharacters, minCharacters);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Method allowed user to enter 0 as min characters.")]
        public void GeneratePassword_WithMinLength0_ExceptionThrown()
        {
            int minCharacters = 0;

            string password = Twaddle.Profile.GeneratePassword(true, 100, minCharacters);
        }
    }
}