using System.Collections.Generic;
using SYBO.Subway.Info;

public class CharacterNameEventData
{
	public List<Characters.CharacterType> charactersList
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public List<StringID> categoryWordsList
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public SSEventCategory eventCategory
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public Characters.CharacterType currentCharacter
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public int collectedLetterIndex
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public int completedCharacters
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public int skippedCharacters
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public bool wasLastCharacterCompleted
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public long eventID
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public CharacterNameEventData(List<Characters.CharacterType> charactersList, List<StringID> categoryWordsList, SSEventCategory eventCategory, Characters.CharacterType currentCharacter, int collectedLetterIndex, int completedCharacters, int skippedCharacters, bool wasLastCharacterCompleted, long eventID)
	{
		this.charactersList__BackingField = charactersList;
		this.categoryWordsList__BackingField = categoryWordsList;
		this.eventID__BackingField = eventID;
		this.wasLastCharacterCompleted__BackingField = wasLastCharacterCompleted;
		this.skippedCharacters__BackingField = skippedCharacters;
		this.completedCharacters__BackingField = completedCharacters;
		this.collectedLetterIndex__BackingField = collectedLetterIndex;
		this.currentCharacter__BackingField = currentCharacter;
		this.eventCategory__BackingField = eventCategory;
	}
}
