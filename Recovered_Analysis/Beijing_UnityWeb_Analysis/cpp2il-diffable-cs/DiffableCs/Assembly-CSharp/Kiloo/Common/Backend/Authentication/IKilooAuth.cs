namespace Kiloo.Common.Backend.Authentication;

public interface IKilooAuth
{

	public string accessToken
	{
		 get { } //Length: 0
	}

	public string kilooTag
	{
		 get { } //Length: 0
	}

	public KilooAuthState state
	{
		 get { } //Length: 0
	}

	public Coroutine AuthenticateAsync(AuthenticateCompleteHandler completeHandler = null) { }

	public string get_accessToken() { }

	public string get_kilooTag() { }

	public KilooAuthState get_state() { }

	public void Invalidate() { }

}

