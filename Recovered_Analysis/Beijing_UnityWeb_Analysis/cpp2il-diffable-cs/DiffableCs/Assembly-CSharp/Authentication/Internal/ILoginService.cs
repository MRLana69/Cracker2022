namespace Authentication.Internal;

public interface ILoginService
{

	public string alias
	{
		 get { } //Length: 0
	}

	public string displayName
	{
		 get { } //Length: 0
	}

	public bool isLoggedIn
	{
		 get { } //Length: 0
	}

	public string get_alias() { }

	public string get_displayName() { }

	public bool get_isLoggedIn() { }

	public IEnumerator Login() { }

	public IEnumerator Logout() { }

}

