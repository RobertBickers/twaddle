using Codetreehouse.Twaddle.Containers;
using Codetreehouse.Twaddle.Containers.Lorem;
using System;
using System.Collections.Generic;

namespace Codetreehouse.Twaddle.Generators
{
    internal class WordGenerator : IWordGenerator
    {
        private static readonly Random _wmRandomSeed = new Random();

        private WordListContainer _container;

        public WordGenerator()
        {
            _container = new LoremWordContainer();
        }

        public void Setup(WordListContainer wordListContainer)
        {
            _container = wordListContainer;
        }

        public static T GenerateRandomEnum<T>() where T : struct, IConvertible
        {
            Array values = Enum.GetValues(typeof(T));
            Random random = new Random();
            var randomEnumValue = (T?)values.GetValue(random.Next(values.Length));

            if (randomEnumValue == null)
                throw new Exception("Enum value could not be generated");

            return (T)randomEnumValue;
        }

        public string GenerateSentence(int numberOfWords, string prepend = "", string append = "")
        {
            List<string> sentenceWords = new List<string>();

            for (int i = 0; i < numberOfWords; i++)
            {
                if (i == 0 && !String.IsNullOrWhiteSpace(prepend))
                {
                    sentenceWords.Add(prepend);
                }
                else if (i == (numberOfWords - 1) && !String.IsNullOrWhiteSpace(append))
                {
                    sentenceWords.Add(append);
                }
                else
                {
                    //Get a value from the string
                    sentenceWords.Add(_container.WordList[_wmRandomSeed.Next(_container.Words)]);
                }
            }
            return string.Join(" ", sentenceWords);
        }

        public string GenerateWord()
        {
            return GenerateSentence(1);
        }
    }
}