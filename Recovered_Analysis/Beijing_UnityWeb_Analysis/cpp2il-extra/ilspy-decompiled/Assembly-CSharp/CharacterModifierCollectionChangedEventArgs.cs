using System;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterModifierCollectionChangedEventArgs : EventArgs
{
	private CharacterModifierCollectionChangeType _characterModifierCollectionChangeType;

	private CharacterModifier _characterModifier;

	public CharacterModifierCollectionChangeType CharacterModifierCollectionChangeType
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (CharacterModifierCollectionChangedEventArgs)+1C]");
			return CharacterModifierCollectionChangeType.Added;
		}
	}

	public CharacterModifier CharacterModifier
	{
		get
		{
			//IL_0007: Expected Obj, but got I4
			return (CharacterModifier)_characterModifierCollectionChangeType;
		}
	}

	public CharacterModifierCollectionChangedEventArgs(CharacterModifierCollectionChangeType characterModifierCollectionChangeType, CharacterModifier characterModifier)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		_ = ((UnityEngine.Object)characterModifier).m_CachedPtr;
		object obj = this + 96;
		obj = characterModifier;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj2 = this + 144;
		obj2 = characterModifierCollectionChangeType;
		Vector3 focusPoint = ((AvatarEyeAnimation)8).GetFocusPoint();
	}
}
