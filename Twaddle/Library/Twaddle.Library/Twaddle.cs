using Bickers.Twaddle.Configuration;
using Bickers.Twaddle.Generators;

namespace Bickers.Twaddle.Core
{
    public static class Twaddle
    {
        static Twaddle()
            => (_configuration) = (new TwaddleConfiguration());

        private static ITwaddleConfiguration _configuration;

        public static void OverrideConfiguration(ITwaddleConfiguration configuration)
            => (_configuration) = (configuration);

        public static ICredentialGenerator Profile => _configuration.CredentialConfig;

        public static IDateGenerator Date => _configuration.DateConfig;

        public static IPhoneGenerator Phone => _configuration.PhoneConfig;

        public static IColourGenerator Colour => _configuration.ColourConfig;

        public static IWordGenerator Word => _configuration.WordConfig;

        public static INameGenerator Name => _configuration.NameGenerator;

    }
}