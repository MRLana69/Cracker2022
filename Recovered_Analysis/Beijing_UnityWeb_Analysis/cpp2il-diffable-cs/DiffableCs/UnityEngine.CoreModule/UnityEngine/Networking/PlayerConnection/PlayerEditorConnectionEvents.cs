namespace UnityEngine.Networking.PlayerConnection;

internal class PlayerEditorConnectionEvents
{
	private sealed class <AddAndCreate>c__AnonStorey1
	{
		internal Guid messageId; //Field offset: 0x8

		public <AddAndCreate>c__AnonStorey1() { }

		internal bool <>m__0(MessageTypeSubscribers x) { }

	}

	private sealed class <InvokeMessageIdSubscribers>c__AnonStorey0
	{
		internal Guid messageId; //Field offset: 0x8

		public <InvokeMessageIdSubscribers>c__AnonStorey0() { }

		internal bool <>m__0(MessageTypeSubscribers x) { }

	}

	private sealed class <UnregisterManagedCallback>c__AnonStorey2
	{
		internal Guid messageId; //Field offset: 0x8

		public <UnregisterManagedCallback>c__AnonStorey2() { }

		internal bool <>m__0(MessageTypeSubscribers x) { }

	}

	public class ConnectionChangeEvent
	{

		public ConnectionChangeEvent() { }

	}

	public class MessageEvent
	{

		public MessageEvent() { }

	}

	public class MessageTypeSubscribers
	{
		private string m_messageTypeId; //Field offset: 0x8
		public int subscriberCount; //Field offset: 0xC
		public MessageEvent messageCallback; //Field offset: 0x10

		public Guid MessageTypeId
		{
			 get { } //Length: 8
			 set { } //Length: 106
		}

		public MessageTypeSubscribers() { }

		public Guid get_MessageTypeId() { }

		public void set_MessageTypeId(Guid value) { }

	}

	public List<MessageTypeSubscribers> messageTypeSubscribers; //Field offset: 0x8
	public ConnectionChangeEvent connectionEvent; //Field offset: 0xC
	public ConnectionChangeEvent disconnectionEvent; //Field offset: 0x10

	public PlayerEditorConnectionEvents() { }

	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

}

