using Bickers.Twaddle.Core;
using NUnit.Framework;

namespace Tests.UnitTesting.WordMaker
{
    [TestFixture]
    public class PhoneTests
    {
        [Test()]
        public void MakePhoneNumber_WithoutPrepend_PhoneNumberGenerated()
        {
            string phoneNumber = Twaddle.Phone.GeneratePhoneNumber();

            Assert.IsTrue(phoneNumber.Length == 11, "Phone number has invalid number of characters");
        }

        [Test()]
        public void MakePhoneNumber_WithPrepend_PhoneNumberGeneratedWithPrepend()
        {
            //Arrange
            string prepend = "+447";

            //Act
            string phoneNumber = Twaddle.Phone.GeneratePhoneNumber(prepend);

            //Assert
            Assert.IsTrue(phoneNumber.Length == 11, "Phone number has incorrect number of characters");
            Assert.IsTrue(phoneNumber.StartsWith(prepend));
        }
    }
}