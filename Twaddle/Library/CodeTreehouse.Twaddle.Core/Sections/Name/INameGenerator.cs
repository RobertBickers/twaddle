using CodeTreehouse.Twaddle.Core.Word;

namespace CodeTreehouse.Twaddle.Core.Name;

public interface INameGenerator
{
	void Setup(WordListContainer firstNameContainer, WordListContainer lastNameContainer);

	string GenerateFirstName();

	string GenerateSecondName();

	string GenerateFullName();
}