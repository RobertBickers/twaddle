using Bickers.Twaddle.Core;
using NUnit.Framework;
using System.Drawing;

namespace Tests.UnitTesting.WordMaker
{
    [TestFixture]
    public class ColourTest
    {
        [Test()]
        public void GenerateColour_WithoutArgs_7CharacterStringReturned()
        {
            int expectedNumberOfCharacters = 7;
            int actualNumberOfCharacters = -1;

            string colourString = Twaddle.Colour.GenerateColourString();

            actualNumberOfCharacters = colourString.Length;

            Assert.IsTrue(colourString.Length == expectedNumberOfCharacters, "Colour string does not have the expected number of characters");
        }

        [Test()]
        public void GenerateColour_WithoutArgs_StringStartsWithHash()
        {
            string expectedStartingCharacter = "#";

            string colourString = Twaddle.Colour.GenerateColourString();

            Assert.IsTrue(colourString.StartsWith(expectedStartingCharacter), "Colour string does not start with a hash (#) character");
        }

        [Test()]
        public void Generatecolour_WithoutArgs_ColourCanBeParsedBySystemDrawingColour()
        {
            string colourString = Twaddle.Colour.GenerateColourString();

            Color convertedColour = System.Drawing.ColorTranslator.FromHtml(colourString);

            Assert.IsFalse(convertedColour.IsEmpty, "Colour string has not been generated");
            Assert.IsTrue(convertedColour.R > 0, "Red channel doesn't have any value");
            Assert.IsTrue(convertedColour.G > 0, "Green channel doesn't have any value");
            Assert.IsTrue(convertedColour.B > 0, "Blue channel doesn't have any value");
        }

        [Test()]
        public void GenerateColour_WithoutArgs_ColorReturned()
        {
            Color color = Twaddle.Colour.GenerateColour();

            Assert.IsFalse(color.IsEmpty, "Colour string has not been initialised");
            Assert.IsTrue(color.R != 0);
            Assert.IsTrue(color.G != 0);
            Assert.IsTrue(color.B != 0);
        }
    }
}