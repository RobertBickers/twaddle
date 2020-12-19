using Codetreehouse.Generation;

namespace Codetreehouse.Twaddle.Configuration
{

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