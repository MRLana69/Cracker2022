namespace UnityEngine.Networking;

internal class NetworkMessageHandlers
{
	private Dictionary<short, NetworkMessageDelegate> m_MsgHandlers; //Field offset: 0x8

	public NetworkMessageHandlers() { }

	internal void ClearMessageHandlers() { }

	internal NetworkMessageDelegate GetHandler(short msgType) { }

	internal Dictionary<short, NetworkMessageDelegate> GetHandlers() { }

	public void RegisterHandler(short msgType, NetworkMessageDelegate handler) { }

	internal void RegisterHandlerSafe(short msgType, NetworkMessageDelegate handler) { }

	public void UnregisterHandler(short msgType) { }

}

