using Bickers.Twaddle.Contracts;
using Bickers.Twaddle.Word;
using System;

namespace Bickers.Twaddle.Credentials
{
    internal class CredentialGenerator : ICredentialGenerator
    {
        private static Random _wmRandomSeed = new Random();

        private IWordGenerator _wordGenerator = new WordGenerator();

        public string GenerateEmail(string domain, bool isUnique = false)
        {
            //Define the domain if it is not provided
            if (String.IsNullOrEmpty(domain))
                domain = "twaddlemail.com";

            string namePart = String.Empty;

            if (isUnique)
                namePart = Guid.NewGuid().ToString();
            else
            {
                namePart = _wordGenerator.GenerateWord();
            }

            return $"{namePart}@{domain}";
        }

        public string GeneratePassword(bool allowSpecialCharacters, int maxLength, int minLength = 6)
        {
            //Guard
            if (minLength < 1)
                throw new ArgumentException("Minimum Character Length cannot be less that 1.", "minLength");
            else if (maxLength < 1)
                throw new ArgumentException("Maximum character list cannot be less that 1.", "maxLength");

            string normalCharacterList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" + (allowSpecialCharacters ? "!\"£$%^&*()" : String.Empty);

            string password = String.Empty;

            int targetLength = _wmRandomSeed.Next(minLength, maxLength);

            for (int i = 0; i <= targetLength; i++)
            {
                password += normalCharacterList[_wmRandomSeed.Next(0, normalCharacterList.Length)];
            }
            return password;
        }
    }
}