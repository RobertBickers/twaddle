using CodeTreehouse.Twaddle.Core.Name;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTreehouse.Twaddle.Core.Tests
{
    [TestClass]
    public class NameTests
    {
        private readonly INameGenerator _systemUnderTest;

        public NameTests()
        {
            _systemUnderTest = new NameGenerator();
        }

        [TestMethod]
        public void GenerateFirstName_NoArgs_StringReturned()
        {
            string firstName = _systemUnderTest.GenerateFirstName();

            Assert.IsFalse(string.IsNullOrEmpty(firstName));
        }

        [TestMethod]
        public void GenerateSecondName_NoArgs_StringReturned()
        {
            string secondName = _systemUnderTest.GenerateSecondName();

            Assert.IsFalse(string.IsNullOrEmpty(secondName));
        }

        [TestMethod]
        public void GenerateFullName_NoArgs_StringReturned()
        {
            string fullName = _systemUnderTest.GenerateFullName();

            Assert.IsFalse(string.IsNullOrEmpty(fullName));
        }

        [TestMethod]
        public void GenerateFullName_NoArgs_TwoWordsSeparatedBySpaceAreProvided()
        {
            string fullName = _systemUnderTest.GenerateFullName();

            string[] separateWords = fullName.Split(' ');

            Assert.AreEqual(2, separateWords.Length);
        }
    }
}