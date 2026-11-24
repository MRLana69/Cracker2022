namespace Kiloo.Common.Backend.Authentication;

public enum KilooAuthState
{
	None,
	Authenticating,
	Authorized,
	Error,
	Invalid,
	Expired
}
