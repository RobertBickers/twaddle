using Bickers.Twaddle.Core;
using NUnit.Framework;

namespace Tests.UnitTesting.Phone
{
    [TestFixture]
    public class PhoneTests
    {
        [Test()]
        public void MakePhoneNumber_WithoutPrepend_PhoneNumberGenerated()
        {
            string phoneNumber = Twaddle.Phone.GeneratePhoneNumber();
            Assert.AreEqual(11, phoneNumber.Length, "Phone number has invalid number of characters");
        }

        [Test()]
        public void MakePhoneNumber_WithPrepend_PhoneNumberGeneratedWithPrepend()
        {
            string prepend = "+447";

            string phoneNumber = Twaddle.Phone.GeneratePhoneNumber(prepend);

            Assert.AreEqual(11, phoneNumber.Length, "Phone number has incorrect number of characters");
            Assert.IsTrue(phoneNumber.StartsWith(prepend));
        }
    }
}