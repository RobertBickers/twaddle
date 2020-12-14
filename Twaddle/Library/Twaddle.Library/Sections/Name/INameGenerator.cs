using Codetreehouse.Twaddle.Containers;

namespace Codetreehouse.Twaddle.Generators
{
    public interface INameGenerator
    {
        void Setup(WordListContainer firstNameContainer, WordListContainer lastNameContainer);

        string GenerateFirstName();

        string GenerateSecondName();

        string GenerateFullName();
    }
}