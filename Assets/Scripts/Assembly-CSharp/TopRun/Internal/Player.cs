namespace TopRun.Internal;

internal class Player : IPlayer
{
	public string publicKey
	{
		get
		{
			return field;
		}
		internal set
		{
			field = value;
		}
	}

	public int score
	{
		get
		{
			return field;
		}
		internal set
		{
			field = value;
		}
	}

	public bool isFriend
	{
		get
		{
			return field;
		}
		internal set
		{
			field = value;
		}
	}

	public FacebookProfile facebookProfile
	{
		get
		{
			return field;
		}
		internal set
		{
			field = value;
		}
	}
}
