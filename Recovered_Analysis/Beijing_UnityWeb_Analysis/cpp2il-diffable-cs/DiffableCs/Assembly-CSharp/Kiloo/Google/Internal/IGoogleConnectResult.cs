namespace Kiloo.Google.Internal;

public interface IGoogleConnectResult
{

	public int errorCode
	{
		 get { } //Length: 0
	}

	public string errorMessage
	{
		 get { } //Length: 0
	}

	public int get_errorCode() { }

	public string get_errorMessage() { }

}

