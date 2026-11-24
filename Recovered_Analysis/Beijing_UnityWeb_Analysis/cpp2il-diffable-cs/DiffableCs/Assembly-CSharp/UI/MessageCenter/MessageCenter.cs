namespace UI.MessageCenter;

public class MessageCenter : MonoBehaviour
{
	private static MessageCenter _instance; //Field offset: 0x0

	public static MessageCenter instance
	{
		 get { } //Length: 89
	}

	public static bool IsInstanced
	{
		 get { } //Length: 316
	}

	public MessageCenter() { }

	private void Awake() { }

	public static MessageCenter get_instance() { }

	public static bool get_IsInstanced() { }

}

