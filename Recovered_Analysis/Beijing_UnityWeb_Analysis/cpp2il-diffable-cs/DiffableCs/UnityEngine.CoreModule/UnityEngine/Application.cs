namespace UnityEngine;

public class Application
{
	public delegate AdvertisingIdentifierCallback
	{

		public AdvertisingIdentifierCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string advertisingId, bool trackingEnabled, string errorMsg, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string advertisingId, bool trackingEnabled, string errorMsg) { }

	}

	public delegate LogCallback
	{

		public LogCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string condition, string stackTrace, LogType type, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(string condition, string stackTrace, LogType type) { }

	}

	public delegate LowMemoryCallback
	{

		public LowMemoryCallback(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	private static LowMemoryCallback lowMemory; //Field offset: 0x0
	private static LogCallback s_LogCallbackHandler; //Field offset: 0x4
	private static LogCallback s_LogCallbackHandlerThreaded; //Field offset: 0x8
	private static Action<bool> focusChanged; //Field offset: 0xC
	private static Action<string> deepLinkActivated; //Field offset: 0x10
	private static Func<bool> wantsToQuit; //Field offset: 0x14
	private static Action quitting; //Field offset: 0x18

	public static event LogCallback logMessageReceived
	{
		 add { } //Length: 51
		 remove { } //Length: 98
	}

	public static string absoluteURL
	{
		 get { } //Length: 47
	}

	public static string cloudProjectId
	{
		 get { } //Length: 47
	}

	public static string dataPath
	{
		 get { } //Length: 47
	}

	public static bool genuine
	{
		 get { } //Length: 47
	}

	public static bool genuineCheckAvailable
	{
		 get { } //Length: 47
	}

	public static string identifier
	{
		 get { } //Length: 47
	}

	public static string installerName
	{
		 get { } //Length: 47
	}

	public static ApplicationInstallMode installMode
	{
		 get { } //Length: 47
	}

	public static NetworkReachability internetReachability
	{
		 get { } //Length: 47
	}

	public static bool isEditor
	{
		 get { } //Length: 47
	}

	public static bool isPlaying
	{
		 get { } //Length: 152
	}

	public static string persistentDataPath
	{
		 get { } //Length: 47
	}

	public static RuntimePlatform platform
	{
		 get { } //Length: 47
	}

	public static bool runInBackground
	{
		 set { } //Length: 51
	}

	public static SystemLanguage systemLanguage
	{
		 get { } //Length: 47
	}

	public static int targetFrameRate
	{
		 get { } //Length: 47
		 set { } //Length: 51
	}

	public static string temporaryCachePath
	{
		 get { } //Length: 47
	}

	public static void add_logMessageReceived(LogCallback value) { }

	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	private static void CallLowMemory() { }

	public static void ExternalEval(string script) { }

	public static string get_absoluteURL() { }

	public static string get_cloudProjectId() { }

	public static string get_dataPath() { }

	public static bool get_genuine() { }

	public static bool get_genuineCheckAvailable() { }

	public static string get_identifier() { }

	public static string get_installerName() { }

	public static ApplicationInstallMode get_installMode() { }

	public static NetworkReachability get_internetReachability() { }

	public static bool get_isEditor() { }

	public static bool get_isPlaying() { }

	public static string get_persistentDataPath() { }

	public static RuntimePlatform get_platform() { }

	public static SystemLanguage get_systemLanguage() { }

	public static int get_targetFrameRate() { }

	public static string get_temporaryCachePath() { }

	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	private static void Internal_ApplicationQuit() { }

	private static bool Internal_ApplicationWantsToQuit() { }

	private static void Internal_ExternalCall(string script) { }

	internal static void InvokeDeepLinkActivated(string url) { }

	internal static void InvokeFocusChanged(bool focus) { }

	internal static void InvokeOnBeforeRender() { }

	public static void OpenURL(string url) { }

	public static void Quit() { }

	public static void Quit(int exitCode) { }

	public static void remove_logMessageReceived(LogCallback value) { }

	public static bool RequestAdvertisingIdentifierAsync(AdvertisingIdentifierCallback delegateMethod) { }

	public static void set_runInBackground(bool value) { }

	public static void set_targetFrameRate(int value) { }

	private static void SetLogCallbackDefined(bool defined) { }

	public static void SetStackTraceLogType(LogType logType, StackTraceLogType stackTraceType) { }

}

