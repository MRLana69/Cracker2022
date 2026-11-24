using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class CharacterAvatars : ScriptableObject
{
	public List<Challenger> characterAvatars;

	public CharacterAvatars()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
