using System;
using SYBO.Subway.Characters.States;

namespace SYBO.Subway;

public class CharacterStateChangedEventArgs : EventArgs
{
	private CharacterState _oldCharacterState;

	private CharacterState _newCharacterState;

	public CharacterState OldCharacterState => _oldCharacterState;

	public CharacterState NewCharacterState => _newCharacterState;

	public CharacterStateChangedEventArgs(CharacterState oldCharacterState, CharacterState newCharacterState)
	{
		_oldCharacterState = oldCharacterState;
		_newCharacterState = newCharacterState;
	}

	public override string ToString()
	{
		return $"[CharacterStateChangedEventArgs: old:{_oldCharacterState}, new:{_newCharacterState}]";
	}
}
