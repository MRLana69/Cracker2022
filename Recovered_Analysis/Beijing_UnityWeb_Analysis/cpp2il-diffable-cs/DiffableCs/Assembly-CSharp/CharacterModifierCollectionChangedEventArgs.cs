//Type is in global namespace

public class CharacterModifierCollectionChangedEventArgs : EventArgs
{
	private CharacterModifierCollectionChangeType _characterModifierCollectionChangeType; //Field offset: 0x8
	private CharacterModifier _characterModifier; //Field offset: 0xC

	public CharacterModifier CharacterModifier
	{
		 get { } //Length: 6
	}

	public CharacterModifierCollectionChangeType CharacterModifierCollectionChangeType
	{
		 get { } //Length: 6
	}

	public CharacterModifierCollectionChangedEventArgs(CharacterModifierCollectionChangeType characterModifierCollectionChangeType, CharacterModifier characterModifier) { }

	public CharacterModifier get_CharacterModifier() { }

	public CharacterModifierCollectionChangeType get_CharacterModifierCollectionChangeType() { }

}

