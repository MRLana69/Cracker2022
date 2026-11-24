namespace TopRun;

public interface IPlayer
{

	public FacebookProfile facebookProfile
	{
		 get { } //Length: 0
	}

	public bool isFriend
	{
		 get { } //Length: 0
	}

	public string publicKey
	{
		 get { } //Length: 0
	}

	public int score
	{
		 get { } //Length: 0
	}

	public FacebookProfile get_facebookProfile() { }

	public bool get_isFriend() { }

	public string get_publicKey() { }

	public int get_score() { }

}

