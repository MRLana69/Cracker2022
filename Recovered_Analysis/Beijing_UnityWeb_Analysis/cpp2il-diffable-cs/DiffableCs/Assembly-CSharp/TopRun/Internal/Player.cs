namespace TopRun.Internal;

internal class Player : IPlayer
{
	private string <publicKey>k__BackingField; //Field offset: 0x8
	private int <score>k__BackingField; //Field offset: 0xC
	private bool <isFriend>k__BackingField; //Field offset: 0x10
	private FacebookProfile <facebookProfile>k__BackingField; //Field offset: 0x14

	public FacebookProfile facebookProfile
	{
		 get { } //Length: 9
		internal set { } //Length: 11
	}

	public bool isFriend
	{
		 get { } //Length: 6
		internal set { } //Length: 8
	}

	public string publicKey
	{
		 get { } //Length: 69
		internal set { } //Length: 20
	}

	public int score
	{
		 get { } //Length: 6
		internal set { } //Length: 11
	}

	public Player() { }

	public FacebookProfile get_facebookProfile() { }

	public bool get_isFriend() { }

	public string get_publicKey() { }

	public int get_score() { }

	internal void set_facebookProfile(FacebookProfile value) { }

	internal void set_isFriend(bool value) { }

	internal void set_publicKey(string value) { }

	internal void set_score(int value) { }

}

