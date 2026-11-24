using System.Collections;

namespace Authentication.Internal;

public interface ILoginService
{
	bool isLoggedIn { get; }

	string displayName { get; }

	string alias { get; }

	IEnumerator Login();

	IEnumerator Logout();
}
