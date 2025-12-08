using CodeTreehouse.Twaddle.Core.Word;
using System;

namespace CodeTreehouse.Twaddle.Core.Name;

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

	public virtual string GenerateFirstName()
	{
		return _firstNameWordListContainer.WordList[_randomSeed.Next(_firstNameWordListContainer.Words)];
	}

	public virtual string GenerateFullName()
	{
		return GenerateFirstName() + " " + GenerateSecondName();
	}

	public virtual string GenerateSecondName()
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