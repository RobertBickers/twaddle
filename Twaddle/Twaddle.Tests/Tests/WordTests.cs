using Bickers.Twaddle.Containers.Lorem;
using Bickers.Twaddle.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests.UnitTesting.WordMaker
{


    [TestClass]
    public class WordTests
    {

        [TestMethod()]
        public void MakeSentence_WithOverrideWordListFromTextFile()
        {
            Twaddle.Word.Setup(new FileSystemWordContainer("/"));
        }


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

        [TestMethod()]
        public void MakeSentence_WithEndingString_SentenceFinishedWithSentence()
        {
            string endingWith = "and they all lived happily ever after";

            string generatedWord = Twaddle.Word.GenerateSentence(400, null, endingWith);

            Assert.IsTrue(generatedWord.EndsWith(endingWith), "Sentence does not end with the provided value");
        }

        [TestMethod()]
        public void MakeSentence_WithStartingString_SentenceStartsWithSentence()
        {
            string startsWith = "Once upon a time";

            string generatedWord = Twaddle.Word.GenerateSentence(400, startsWith);

            Assert.IsTrue(generatedWord.StartsWith(startsWith), "Sentence does not start` with the provided value");
        }

        [TestMethod()]
        [DataRow("first", "second", 1)]
        [DataRow("first", "second", 2)]
        [DataRow("first", "second", 3)]
        public void MakeSentence_WordLengthLessThanProvidedAfterSentencePrependAndAppend_NumberOfWordsStillGenerated(string firstWord, string secondWord, int numberOfWords)
        {
            string generatedSentence = Twaddle.Word.GenerateSentence(numberOfWords, firstWord, secondWord);

            int actualNumberOfWords = generatedSentence.Split(' ').Length;
            Assert.IsTrue(actualNumberOfWords == numberOfWords, $"Actual number of words returned: {actualNumberOfWords}. Expected: {numberOfWords}");
        }
    }
}