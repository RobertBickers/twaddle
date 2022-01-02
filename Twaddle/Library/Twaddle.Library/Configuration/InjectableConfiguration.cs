using Codetreehouse.Generation;

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
}