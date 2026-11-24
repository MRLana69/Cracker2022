namespace Kiloo.Google.Internal;

public interface IGoogleSignInResult
{

	public int errorCode
	{
		 get { } //Length: 0
	}

	public string errorMessage
	{
		 get { } //Length: 0
	}

	public IGoogleProfile profile
	{
		 get { } //Length: 0
	}

	public int get_errorCode() { }

	public string get_errorMessage() { }

	public IGoogleProfile get_profile() { }

}

