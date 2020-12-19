using Codetreehouse.Twaddle.Generators;

namespace Codetreehouse.Twaddle.Configuration
{
    public class InjectableConfiguration : ITwaddleConfiguration
    {
        public InjectableConfiguration(
            ICredentialGenerator credentialGenerator,
            IDateGenerator dateGenerator,
            IPhoneGenerator phoneGenerator,
            IColourGenerator colourGenerator,
            IWordGenerator wordGenerator,
            INameGenerator nameGenerator)
        {
            CredentialConfig = credentialGenerator;
            DateConfig = dateGenerator;
            PhoneConfig = phoneGenerator;
            ColourConfig = colourGenerator;
            WordConfig = wordGenerator;
            NameGenerator = nameGenerator;
        }

        public ICredentialGenerator CredentialConfig { get; }

        public IDateGenerator DateConfig { get; }

        public IPhoneGenerator PhoneConfig { get; }

        public IColourGenerator ColourConfig { get; }

        public IWordGenerator WordConfig { get; }

        public INameGenerator NameGenerator { get; }
    }

    /// <summary>
    /// Default Twaddle Configuration
    /// </summary>
    public class TwaddleConfiguration : InjectableConfiguration, ITwaddleConfiguration
    {
        public TwaddleConfiguration(
            ICredentialGenerator? credentialGenerator,
            IDateGenerator? dateGenerator,
            IPhoneGenerator? phoneGenerator,
            IColourGenerator? colourGenerator,
            IWordGenerator? wordGenerator,
            INameGenerator? nameGenerator)
            : base(
                  credentialGenerator ?? new CredentialGenerator(),
                  dateGenerator ?? new DateGenerator(),
                  phoneGenerator ?? new PhoneGenerator(),
                  colourGenerator ?? new ColourGenerator(),
                  wordGenerator ?? new WordGenerator(),
                  nameGenerator ?? new NameGenerator())
        {
        }
    }
}