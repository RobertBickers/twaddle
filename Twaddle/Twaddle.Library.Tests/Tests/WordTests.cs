using Codetreehouse.Twaddle.Generators;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.UnitTesting.Word
{
    [TestFixture]
    public class WordTests
    {
        private readonly IWordGenerator _systemUnderTest;

        public WordTests()
        {
            _systemUnderTest = new WordGenerator();
        }

        [Test()]
        public void MakeSentence_With10Words_SentenceWith10WordMade()
        {
            string sentence = _systemUnderTest.GenerateSentence(10);

            string[] sentenceWords = sentence.Split(' ');

            sentence.Should().NotBeNullOrWhiteSpace();
            sentenceWords.Should().HaveCount(10);
        }

        [Test()]
        public void MakeWord_WithNoArgs_1WordGenerated()
        {
            string word = _systemUnderTest.GenerateWord();

            word.Should().NotBeNullOrWhiteSpace();
        }

        [Test()]
        public void MakeSentence_WithEndingString_SentenceFinishedWithSentence()
        {
            string endingString = "and they all lived happily ever after";

            string sentence = _systemUnderTest.GenerateSentence(400, null, endingString);

            sentence.Should().EndWith(endingString);
        }

        [Test()]
        public void MakeSentence_WithStartingString_SentenceStartsWithSentence()
        {
            string startingWords = "Once upon a time";

            string sentence = _systemUnderTest.GenerateSentence(400, startingWords);

            sentence.Should().StartWith(startingWords);
        }

        [TestCase("first", "second", 1)]
        [TestCase("first", "second", 2)]
        [TestCase("first", "second", 3)]
        public void MakeSentence_WordLengthLessThanProvidedAfterSentencePrependAndAppend_NumberOfWordsStillGenerated(string firstWord, string secondWord, int expectedNumberOfWords)
        {
            string generatedSentence = _systemUnderTest.GenerateSentence(expectedNumberOfWords, firstWord, secondWord);

            var actualNumberOfWords = generatedSentence.Split(' ');
            actualNumberOfWords.Should().HaveCount(expectedNumberOfWords);
        }
    }
}