//Type is in global namespace

public class AndroidIncomingCallBridge : MonoBehaviour
{
	public delegate IncomingCallEvent
	{

		public IncomingCallEvent(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string state, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string state) { }

	}

	private const string CALLBACK_RECEIVER_NAME = "IncomingCallReceiverBridge"; //Field offset: 0x0
	private IncomingCallEvent onPhoneStateChanged; //Field offset: 0xC

	public event IncomingCallEvent onPhoneStateChanged
	{
		 add { } //Length: 247
		 remove { } //Length: 111
	}

	private void _callback_onAudioStateChanged(string isModeNormal) { }

	public AndroidIncomingCallBridge() { }

	public void add_onPhoneStateChanged(IncomingCallEvent value) { }

	public static AndroidIncomingCallBridge CreatePlugin() { }

	public void Init() { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	public void remove_onPhoneStateChanged(IncomingCallEvent value) { }

}

