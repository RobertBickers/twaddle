using CodeTreehouse.Twaddle.Core.Phone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTreehouse.Twaddle.Core.Tests
{
    [TestClass]
    public class PhoneTests
    {
        private readonly IPhoneGenerator _systemUnderTest;

        private const string _phoneNumberPrepend = "+44";

        public PhoneTests()
        {
            _systemUnderTest = new PhoneGenerator();
        }

        [TestMethod]
        public void MakePhoneNumber_WithoutPrepend_PhoneNumberGenerated()
        {
            string phoneNumber = _systemUnderTest.GeneratePhoneNumber();

            Assert.AreEqual(11, phoneNumber.Length);
        }

        [TestMethod]
        public void MakePhoneNumber_WithPrepend_PhoneNumberGeneratedWithPrepend()
        {
            string phoneNumber = _systemUnderTest.GeneratePhoneNumber(_phoneNumberPrepend);

            Assert.AreEqual(11, phoneNumber.Length);
            Assert.StartsWith(_phoneNumberPrepend, phoneNumber);
        }
    }
}