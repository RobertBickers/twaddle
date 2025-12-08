using CodeTreehouse.Twaddle.Core.Word;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTreehouse.Twaddle.Core.Tests
{
    [TestClass]
    public class WordTests
    {
        private readonly IWordGenerator _systemUnderTest;

        public WordTests()
        {
            _systemUnderTest = new WordGenerator();
        }

        [TestMethod]
        public void MakeSentence_With10Words_SentenceWith10WordMade()
        {
            string sentence = _systemUnderTest.GenerateSentence(10);

            string[] sentenceWords = sentence.Split(' ');

            Assert.IsFalse(string.IsNullOrWhiteSpace(sentence));
            Assert.AreEqual(10, sentenceWords.Length);
        }

        [TestMethod]
        public void MakeWord_WithNoArgs_1WordGenerated()
        {
            string word = _systemUnderTest.GenerateWord();

            Assert.IsFalse(string.IsNullOrWhiteSpace(word));
        }

        [TestMethod]
        public void MakeSentence_WithEndingString_SentenceFinishedWithSentence()
        {
            string endingString = "and they all lived happily ever after";

            string sentence = _systemUnderTest.GenerateSentence(400, null, endingString);

            StringAssert.EndsWith(sentence, endingString);
        }

        [TestMethod]
        public void MakeSentence_WithStartingString_SentenceStartsWithSentence()
        {
            string startingWords = "Once upon a time";

            string sentence = _systemUnderTest.GenerateSentence(400, startingWords);

            Assert.StartsWith(startingWords, sentence);
        }

        [TestMethod]
        public void MakeSentence_WordLength1_AfterPrependAndAppend_NumberOfWordsStillGenerated()
        {
            string generatedSentence = _systemUnderTest.GenerateSentence(1, "first", "second");

            var actualNumberOfWords = generatedSentence.Split(' ');
            Assert.AreEqual(1, actualNumberOfWords.Length);
        }

        [TestMethod]
        public void MakeSentence_WordLength2_AfterPrependAndAppend_NumberOfWordsStillGenerated()
        {
            string generatedSentence = _systemUnderTest.GenerateSentence(2, "first", "second");

            var actualNumberOfWords = generatedSentence.Split(' ');
            Assert.AreEqual(2, actualNumberOfWords.Length);
        }

        [TestMethod]
        public void MakeSentence_WordLength3_AfterPrependAndAppend_NumberOfWordsStillGenerated()
        {
            string generatedSentence = _systemUnderTest.GenerateSentence(3, "first", "second");

            var actualNumberOfWords = generatedSentence.Split(' ');
            Assert.AreEqual(3, actualNumberOfWords.Length);
        }
    }
}