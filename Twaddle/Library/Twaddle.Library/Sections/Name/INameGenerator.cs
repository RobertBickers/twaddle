using Bickers.Twaddle.Containers;
using System.Collections.Generic;
using System.Text;

namespace Bickers.Twaddle.Contracts
{
    public interface INameGenerator
    {

        void Setup(WordListContainer firstNameContainer, WordListContainer lastNameContainer);

        string GenerateFirstName();

        string GenerateSecondName();

        string GenerateFullName();
    }
}
