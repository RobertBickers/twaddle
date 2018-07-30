using Bickers.Twaddle.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace Tests.UnitTesting.WordMaker
{
    [TestClass]
    public class ColourTest
    {
        [TestMethod()]
        public void GenerateColour_WithoutArgs_7CharacterStringReturned()
        {
            int expectedNumberOfCharacters = 6;
            int actualNumberOfCharacters = -1;


            //Act
            string colourString = Twaddle.Colour.GenerateColourString();

            actualNumberOfCharacters = colourString.Length;


            //Assert
            Assert.IsTrue(colourString.Length == expectedNumberOfCharacters, "Colour string does not have the expected number of characters");

        }

        [TestMethod()]
        public void GenerateColour_WithoutArgs_StringStartsWithHash()
        {
            string expectedStartingCharacter = "#";

            string colourString = Twaddle.Colour.GenerateColourString();

            //Assert
            Assert.IsTrue(colourString.StartsWith(expectedStartingCharacter), "Colour string does not start with a hash (#) character");
        }

        [TestMethod()]
        public void Generatecolour_WithoutArgs_ColourCanBeParsedBySystemDrawingColour()
        {
            string colourString = Twaddle.Colour.GenerateColourString();

            System.Drawing.Color convertedColour = System.Drawing.ColorTranslator.FromHtml(colourString);

            Assert.IsFalse(convertedColour.IsEmpty, "Colour string has not been generated");
            Assert.IsTrue(convertedColour.R > 0, "Red channel doesn't have any value");
            Assert.IsTrue(convertedColour.G > 0, "Green channel doesn't have any value");
            Assert.IsTrue(convertedColour.B > 0, "Blue channel doesn't have any value");

        }


    }
}
