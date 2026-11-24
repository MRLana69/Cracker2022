namespace UnityEngine.Networking;

internal sealed class LocalClient : NetworkClient
{
	private struct InternalMsg
	{
		internal byte[] buffer; //Field offset: 0x0
		internal int channelId; //Field offset: 0x4

	}

	private const int k_InitialFreeMessagePoolSize = 64; //Field offset: 0x0
	private List<InternalMsg> m_InternalMsgs; //Field offset: 0x50
	private List<InternalMsg> m_InternalMsgs2; //Field offset: 0x54
	private Stack<InternalMsg> m_FreeMessages; //Field offset: 0x58
	private NetworkServer m_LocalServer; //Field offset: 0x5C
	private bool m_Connected; //Field offset: 0x60
	private NetworkMessage s_InternalMessage; //Field offset: 0x64

	public LocalClient() { }

	internal void AddLocalPlayer(PlayerController localPlayer) { }

	public override void Disconnect() { }

	internal void InternalConnectLocalServer(bool generateConnectMsg) { }

	internal void InvokeBytesOnClient(byte[] buffer, int channelId) { }

	internal void InvokeHandlerOnClient(short msgType, MessageBase msg, int channelId) { }

	private void PostInternalMessage(byte[] buffer, int channelId) { }

	private void PostInternalMessage(short msgType) { }

	private void ProcessInternalMessages() { }

	internal override void Update() { }

}

