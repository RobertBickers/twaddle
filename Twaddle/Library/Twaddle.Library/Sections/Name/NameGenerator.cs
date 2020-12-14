using Codetreehouse.Twaddle.Containers;
using Codetreehouse.Twaddle.Containers.Lorem;
using System;

namespace Codetreehouse.Twaddle.Generators
{
    public class NameGenerator : INameGenerator
    {
        private static Random _randomSeed = new Random();

        private WordListContainer _firstNameWordListContainer = null;
        private WordListContainer _lastNameContainer = null;

        public NameGenerator() : this(null, null)
        {
        }

        public NameGenerator(WordListContainer firstNameWordListContainer, WordListContainer lastNameWordContainer)
        {
            _firstNameWordListContainer = firstNameWordListContainer != null ? firstNameWordListContainer : new FirstNameWordContainer();
            _lastNameContainer = lastNameWordContainer != null ? lastNameWordContainer : new LastNameWordContainer();
        }

        public virtual string GenerateFirstName()
        {
            return _firstNameWordListContainer.WordList[_randomSeed.Next(_firstNameWordListContainer.Words.Value)];
        }

        public virtual string GenerateFullName()
        {
            return GenerateFirstName() + " " + GenerateSecondName();
        }

        public virtual string GenerateSecondName()
        {
            return _lastNameContainer.WordList[_randomSeed.Next(_lastNameContainer.Words.Value)];
        }

        public void Setup(WordListContainer firstNameWordListContainer, WordListContainer lastNameWordContainer)
        {
            if (firstNameWordListContainer == null)
            {
                throw new ArgumentNullException(nameof(firstNameWordListContainer));
            }

            if (lastNameWordContainer == null)
            {
                throw new ArgumentNullException(nameof(lastNameWordContainer));
            }

            _firstNameWordListContainer = firstNameWordListContainer != null ? firstNameWordListContainer : new FirstNameWordContainer();
            _lastNameContainer = lastNameWordContainer != null ? lastNameWordContainer : new LastNameWordContainer();
        }
    }
}