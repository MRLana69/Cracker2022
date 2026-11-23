using UnityEngine;

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
}
