namespace Kiloo.Google;

public interface IGoogleProfile
{

	public string displayName
	{
		 get { } //Length: 0
	}

	public string idToken
	{
		 get { } //Length: 0
	}

	public string photoUrl
	{
		 get { } //Length: 0
	}

	public string userId
	{
		 get { } //Length: 0
	}

	public string get_displayName() { }

	public string get_idToken() { }

	public string get_photoUrl() { }

	public string get_userId() { }

}

