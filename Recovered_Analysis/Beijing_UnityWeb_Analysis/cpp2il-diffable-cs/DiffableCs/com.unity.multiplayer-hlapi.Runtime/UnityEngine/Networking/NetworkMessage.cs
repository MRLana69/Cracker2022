namespace UnityEngine.Networking;

public class NetworkMessage
{
	public const int MaxMessageSize = 65535; //Field offset: 0x0
	public short msgType; //Field offset: 0x8
	public NetworkConnection conn; //Field offset: 0xC
	public NetworkReader reader; //Field offset: 0x10
	public int channelId; //Field offset: 0x14

	public NetworkMessage() { }

	public static string Dump(byte[] payload, int sz) { }

	public TMsg ReadMessage() { }

	public void ReadMessage(TMsg msg) { }

}

