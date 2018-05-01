using Bickers.Twaddle.Containers;
using Bickers.Twaddle.Containers.Lorem;
using Bickers.Twaddle.Contracts;
using System;
using System.Collections.Generic;

namespace Bickers.Twaddle.Word
{
    internal class WordGenerator : IWordGenerator
    {
        private static Random _wmRandomSeed = new Random();

        private static WordListContainer _container;

        public WordGenerator()
        {
            _container = new LoremWordContainer();
        }

        public void Setup(WordListContainer wordListContainer)
        {
            _container = wordListContainer;
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
                else if (i == (numberOfWords -1)  && !String.IsNullOrWhiteSpace(append))
                {
                    sentenceWords.Add(append);
                }
                else
                {
                    //Get a value from the string
                    if (_container.Words != null)
                    {
                        sentenceWords.Add(_container.WordList[_wmRandomSeed.Next(_container.Words.Value)]);
                    }
                    else
                    {
                        throw new Exception("Twaddle word generator has not been configured with a valid word container");
                    }
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