using Bickers.Twaddle.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Tests.UnitTesting.WordMaker
{

    [TestClass]
    public class NameTests
    {
        [TestMethod()]
        public void GenerateFirstName_NoArgs_StringReturned()
        {
            //Act
            string firstName = Twaddle.Name.GenerateFirstName();

            //Assert
            Assert.IsTrue(firstName.Length > 0, "Returned first name does not contain any characters.");
        }


        [TestMethod()]
        public void GenerateSecondName_NoArgs_StringReturned()
        {
            //Act
            string secondName = Twaddle.Name.GenerateSecondName();

            //Assert
            Assert.IsTrue(secondName.Length > 0, "Returned second name does not contain any characters.");
        }



        [TestMethod()]
        public void GenerateFullName_NoArgs_StringReturned()
        {
            //Act
            string fullName = Twaddle.Name.GenerateFullName();

            //Assert
            Assert.IsTrue(fullName.Length > 0, "Returned full name does not contain any characters.");
        }


        [TestMethod()]
        public void GenerateFullName_NoArgs_TwoWordsSeperatedBySpaceAreProvided()
        {
            //Act
            string fullName = Twaddle.Name.GenerateFullName();

            string[] seperateWords = fullName.Split(' ');

            //Assert
            Assert.IsTrue(seperateWords.Count() == 2, "Two seperate words have not been returned");
        }
    }
}
