using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
public class Challenger
{
	public enum ChallengerTypes
	{
		topRunPlayer,
		friend,
		debugFriend
	}

	public int Score;

	public Texture2D ProfilePicture;

	public bool IsBothTopRunAndFacebookFriend;

	public ChallengerTypes ChallengerType;

	public Challenger()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
