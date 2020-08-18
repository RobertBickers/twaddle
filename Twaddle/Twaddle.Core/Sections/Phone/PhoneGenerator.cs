using Bickers.Twaddle.Contracts;
using System;

namespace Bickers.Twaddle.Phone
{
    internal class PhoneGenerator : IPhoneGenerator
    {
        private static Random _wmRandomSeed = new Random();

        public string GeneratePhoneNumber(string prefix = "")
        {
            string phoneNumber = prefix;

            while (phoneNumber.Length < 11)
                phoneNumber += _wmRandomSeed.Next(0, 10);

            return phoneNumber.ToString();
        }
    }
}