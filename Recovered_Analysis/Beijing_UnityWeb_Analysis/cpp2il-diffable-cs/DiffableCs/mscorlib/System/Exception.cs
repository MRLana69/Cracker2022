namespace System;

public class Exception : ISerializable, _Exception
{
	internal enum ExceptionMessageKind
	{
		ThreadAbort = 1,
		ThreadInterrupted = 2,
		OutOfMemory = 3,
	}

	private static object s_EDILock; //Field offset: 0x0
	private const int _COMPlusExceptionCode = -532462766; //Field offset: 0x0
	private string _className; //Field offset: 0x8
	internal string _message; //Field offset: 0xC
	private IDictionary _data; //Field offset: 0x10
	private Exception _innerException; //Field offset: 0x14
	private string _helpURL; //Field offset: 0x18
	private object _stackTrace; //Field offset: 0x1C
	private string _stackTraceString; //Field offset: 0x20
	private string _remoteStackTraceString; //Field offset: 0x24
	private int _remoteStackIndex; //Field offset: 0x28
	private object _dynamicMethods; //Field offset: 0x2C
	internal int _HResult; //Field offset: 0x30
	private string _source; //Field offset: 0x34
	private SafeSerializationManager _safeSerializationManager; //Field offset: 0x38
	internal StackTrace[] captured_traces; //Field offset: 0x3C
	private nint[] native_trace_ips; //Field offset: 0x40

	public int HResult
	{
		 get { } //Length: 13
		protected set { } //Length: 80
	}

	public Exception InnerException
	{
		 get { } //Length: 35
	}

	public virtual string Message
	{
		 get { } //Length: 12
	}

	public virtual string Source
	{
		 get { } //Length: 11
	}

	public virtual string StackTrace
	{
		 get { } //Length: 6
	}

	private static Exception() { }

	public Exception() { }

	public Exception(string message) { }

	public Exception(string message, Exception innerException) { }

	protected Exception(SerializationInfo info, StreamingContext context) { }

	internal Exception FixRemotingException() { }

	public int get_HResult() { }

	public Exception get_InnerException() { }

	public virtual string get_Message() { }

	public virtual string get_Source() { }

	public virtual string get_StackTrace() { }

	private string GetClassName() { }

	internal static string GetMessageFromNativeResources(ExceptionMessageKind kind) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private string GetStackTrace(bool needFileInfo) { }

	public Type GetType() { }

	private void Init() { }

	private void OnDeserialized(StreamingContext context) { }

	internal static void ReportUnhandledException(Exception exception) { }

	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	protected void set_HResult(int value) { }

	internal void SetErrorCode(int hr) { }

	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	private string ToString(bool needFileLineInfo, bool needMessage) { }

	public override string ToString() { }

}

