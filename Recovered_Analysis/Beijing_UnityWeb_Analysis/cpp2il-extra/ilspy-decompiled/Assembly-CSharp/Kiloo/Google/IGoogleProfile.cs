namespace Kiloo.Google;

public interface IGoogleProfile
{
	string displayName { get; }

	string photoUrl { get; }

	string idToken { get; }

	string userId { get; }
}
