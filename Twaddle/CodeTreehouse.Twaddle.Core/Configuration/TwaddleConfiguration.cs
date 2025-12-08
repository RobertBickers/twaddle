using CodeTreehouse.Twaddle.Core.Colour;
using CodeTreehouse.Twaddle.Core.Credentials;
using CodeTreehouse.Twaddle.Core.Date;
using CodeTreehouse.Twaddle.Core.Name;
using CodeTreehouse.Twaddle.Core.Phone;
using CodeTreehouse.Twaddle.Core.Word;

namespace CodeTreehouse.Twaddle.Core.Configuration;

public class TwaddleConfiguration : InjectableConfiguration
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