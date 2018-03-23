using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeTreehouse.Twaddle.Core.Tests
{
    [TestClass]
    public class WordTests
    {
        [TestMethod()]
        public void MakeSentence_With10Words_SentenceWith10WordMade()
        {
            //Act
            string sentence = Twaddle.Word.GenerateSentence(10);

            string[] sentenceWords = sentence.Split(' ');

            //Assert
            Assert.IsTrue(sentence.Length > 0, "Returned sentence does not contain any characters.");
            Assert.AreEqual(sentenceWords.Length, 10, "Number of words is incorrect");
        }

        [TestMethod()]
        public void MakeWord_WithNoArgs_1WordGenerated()
        {
            string word = Twaddle.Word.GenerateWord();

            Assert.IsNotNull(word);
            Assert.IsTrue(!String.IsNullOrEmpty(word));
        }
    }
}