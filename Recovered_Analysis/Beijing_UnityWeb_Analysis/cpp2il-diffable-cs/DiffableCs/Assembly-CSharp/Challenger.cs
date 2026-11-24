//Type is in global namespace

public class Challenger
{
	public enum ChallengerTypes
	{
		topRunPlayer = 0,
		friend = 1,
		debugFriend = 2,
	}

	public int Score; //Field offset: 0x8
	public Texture2D ProfilePicture; //Field offset: 0xC
	public bool IsBothTopRunAndFacebookFriend; //Field offset: 0x10
	public ChallengerTypes ChallengerType; //Field offset: 0x14

	public Challenger() { }

}

