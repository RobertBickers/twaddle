using System;
using CodeTreehouse.Twaddle.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTreehouse.Twaddle.Core.Tests
{
    [TestClass]
    public class CredentialTest
    {
        [TestMethod()]
        public void GenerateEmail_ProvidingDomain_ReturnValueEndsWithDomain()
        {
            //Arrange
            string endDomain = "@generatedTestMail.com";

            string emailAddress = Twaddle.Credentials.GenerateEmail(endDomain, true);

            Assert.IsNotNull(emailAddress, "Returned email address returned null");
            Assert.IsTrue(emailAddress.EndsWith(endDomain), "Email address does not end with the domain provided as expected");
        }

        [TestMethod()]
        public void GenerateEmail_WithoutDomain_ReturnValueHasValidEmail()
        {
            //Arrange
            string emailAddress = Twaddle.Credentials.GenerateEmail(null, true);

            Assert.IsNotNull(emailAddress, "Returned email address returned null");
            Assert.IsTrue(emailAddress.EndsWith("twaddlemail.com"), "Email address does not end with the domain provided as expected");
        }


     
    
    }
}
