using Codetreehouse.Generation;

namespace Codetreehouse.Twaddle.Core
{
	public interface ITwaddle
	{
		ICredentialGenerator Profile { get; }
		IDateGenerator Date { get; }
		IPhoneGenerator Phone { get; }
		IColourGenerator Colour { get; }
		IWordGenerator Word { get; }
		INameGenerator Name { get; }
	}
}