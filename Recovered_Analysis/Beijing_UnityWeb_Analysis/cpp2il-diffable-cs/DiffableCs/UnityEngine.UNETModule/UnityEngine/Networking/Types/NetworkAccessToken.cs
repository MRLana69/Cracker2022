namespace UnityEngine.Networking.Types;

public class NetworkAccessToken
{
	private const int NETWORK_ACCESS_TOKEN_SIZE = 64; //Field offset: 0x0
	public byte[] array; //Field offset: 0x8

	public NetworkAccessToken() { }

	public NetworkAccessToken(string strArray) { }

	public string GetByteString() { }

}

