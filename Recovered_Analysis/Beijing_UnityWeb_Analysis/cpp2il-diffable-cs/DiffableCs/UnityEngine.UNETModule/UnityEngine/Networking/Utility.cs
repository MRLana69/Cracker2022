namespace UnityEngine.Networking;

public class Utility
{
	private static Dictionary<NetworkID, NetworkAccessToken> s_dictTokens; //Field offset: 0x0

	private static Utility() { }

	public static NetworkAccessToken GetAccessTokenForNetwork(NetworkID netId) { }

	public static SourceID GetSourceID() { }

	public static void SetAccessTokenForNetwork(NetworkID netId, NetworkAccessToken accessToken) { }

}

