using Bickers.Twaddle.Core;
using NUnit.Framework;
using System.Linq;

namespace Tests.UnitTesting.Name
{
    [TestFixture]
    public class NameTests
    {
        [Test()]
        public void GenerateFirstName_NoArgs_StringReturned()
        {
            string firstName = Twaddle.Name.GenerateFirstName();

            Assert.IsTrue(firstName.Length > 0, "Returned first name does not contain any characters.");
        }

        [Test()]
        public void GenerateSecondName_NoArgs_StringReturned()
        {
            string secondName = Twaddle.Name.GenerateSecondName();

            Assert.IsTrue(secondName.Length > 0, "Returned second name does not contain any characters.");
        }

        [Test()]
        public void GenerateFullName_NoArgs_StringReturned()
        {
            string fullName = Twaddle.Name.GenerateFullName();

            Assert.IsTrue(fullName.Length > 0, "Returned full name does not contain any characters.");
        }

        [Test()]
        public void GenerateFullName_NoArgs_TwoWordsSeperatedBySpaceAreProvided()
        {
            string fullName = Twaddle.Name.GenerateFullName();

            string[] seperateWords = fullName.Split(' ');

            Assert.IsTrue(seperateWords.Count() == 2, "Two seperate words have not been returned");
        }
    }
}
