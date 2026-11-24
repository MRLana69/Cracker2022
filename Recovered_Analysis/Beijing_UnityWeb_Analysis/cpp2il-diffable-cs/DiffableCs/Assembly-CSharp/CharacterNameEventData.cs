//Type is in global namespace

public class CharacterNameEventData
{
	public CharacterId currentCharacter; //Field offset: 0x8
	public int collectedLetterIndex; //Field offset: 0xC
	public int skippedCharacters; //Field offset: 0x10
	public bool wasLastCharacterCompleted; //Field offset: 0x14
	public int completedCharacters; //Field offset: 0x18
	public List<CharacterId> charactersList; //Field offset: 0x1C
	public List<string> categoryWordsList; //Field offset: 0x20
	public long eventID; //Field offset: 0x28
	public SSEventCategory eventCategory; //Field offset: 0x30

	public CharacterNameEventData(List<CharacterId> charactersList, List<string> categoryWordsList, SSEventCategory eventCategory, CharacterId currentCharacter, int collectedLetterIndex, int completedCharacters, int skippedCharacters, bool wasLastCharacterCompleted, long eventID) { }

	public CharacterNameEventData() { }

}

