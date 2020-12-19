using Codetreehouse.Twaddle.Containers;
using Codetreehouse.Twaddle.Containers.Lorem;
using System;

namespace Codetreehouse.Twaddle.Generators
{
    public class NameGenerator : INameGenerator
    {
        private static readonly Random _randomSeed = new Random();

        private WordListContainer _firstNameWordListContainer;
        private WordListContainer _lastNameContainer;

        public NameGenerator() : this(null, null)
        {
        }

        public NameGenerator(WordListContainer? firstNameWordListContainer, WordListContainer? lastNameWordContainer)
        {
            _firstNameWordListContainer
                = firstNameWordListContainer
                ?? new FirstNameWordContainer();

            _lastNameContainer
                = lastNameWordContainer
                ?? new LastNameWordContainer();
        }

        public virtual string FirstName()
        {
            return _firstNameWordListContainer.WordList[_randomSeed.Next(_firstNameWordListContainer.Words)];
        }

        public virtual string FullName()
        {
            return FirstName() + " " + SecondName();
        }

        public virtual string SecondName()
        {
            return _lastNameContainer.WordList[_randomSeed.Next(_lastNameContainer.Words)];
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

            _firstNameWordListContainer = firstNameWordListContainer ?? new FirstNameWordContainer();
            _lastNameContainer = lastNameWordContainer ?? new LastNameWordContainer();
        }
    }
}