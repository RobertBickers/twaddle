using Codetreehouse.Twaddle.Containers;

namespace Codetreehouse.Generation
{
	public interface INameGenerator
	{
		void Setup(WordListContainer firstNameContainer, WordListContainer lastNameContainer);

		string GenerateFirstName();

		string GenerateSecondName();

		string GenerateFullName();
	}
}