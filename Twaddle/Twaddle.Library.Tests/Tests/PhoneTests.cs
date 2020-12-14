using Bickers.Twaddle.Generators;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.UnitTesting.Phone
{
    [TestFixture]
    public class PhoneTests
    {
        private readonly IPhoneGenerator _systemUnderTest;

        private const string _phoneNumberPrepend = "+44";

        public PhoneTests()
        {
            _systemUnderTest = new PhoneGenerator();
        }

        [Test()]
        public void MakePhoneNumber_WithoutPrepend_PhoneNumberGenerated()
        {
            string phoneNumber = _systemUnderTest.GeneratePhoneNumber();

            phoneNumber.Should().HaveLength(11);
        }

        [Test()]
        public void MakePhoneNumber_WithPrepend_PhoneNumberGeneratedWithPrepend()
        {
            string phoneNumber = _systemUnderTest.GeneratePhoneNumber(_phoneNumberPrepend);

            phoneNumber.Should().HaveLength(11);
            phoneNumber.Should().StartWith(_phoneNumberPrepend);
        }
    }
}