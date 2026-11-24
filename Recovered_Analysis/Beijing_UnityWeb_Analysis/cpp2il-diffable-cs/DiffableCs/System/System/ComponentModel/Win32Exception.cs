namespace System.ComponentModel;

public class Win32Exception : ExternalException, ISerializable
{
	private static bool s_ErrorMessagesInitialized; //Field offset: 0x0
	private static Dictionary<int, string> s_ErrorMessage; //Field offset: 0x4
	private readonly int nativeErrorCode; //Field offset: 0x44

	public int NativeErrorCode
	{
		 get { } //Length: 12
	}

	private static Win32Exception() { }

	public Win32Exception() { }

	public Win32Exception(int error) { }

	public Win32Exception(int error, string message) { }

	protected Win32Exception(SerializationInfo info, StreamingContext context) { }

	public int get_NativeErrorCode() { }

	internal static string GetErrorMessage(int error) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private static void InitializeErrorMessages() { }

}

