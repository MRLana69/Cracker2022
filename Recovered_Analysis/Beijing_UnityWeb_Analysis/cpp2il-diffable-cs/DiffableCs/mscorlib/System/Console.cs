namespace System;

public static class Console
{
	private delegate InternalCancelHandler
	{

		public InternalCancelHandler(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke() { }

	}

	private class WindowsConsole
	{
		private delegate WindowsCancelHandler
		{

			public WindowsCancelHandler(object object, nint method) { }

			public virtual IAsyncResult BeginInvoke(int keyCode, AsyncCallback callback, object object) { }

			public virtual bool EndInvoke(IAsyncResult result) { }

			public virtual bool Invoke(int keyCode) { }

		}

		public static bool ctrlHandlerAdded; //Field offset: 0x0
		private static WindowsCancelHandler cancelHandler; //Field offset: 0x4

		private static WindowsConsole() { }

		private static bool DoWindowsConsoleCancelEvent(int keyCode) { }

		private static int GetConsoleCP() { }

		private static int GetConsoleOutputCP() { }

		public static int GetInputCodePage() { }

		public static int GetOutputCodePage() { }

	}

	internal static TextWriter stdout; //Field offset: 0x0
	private static TextWriter stderr; //Field offset: 0x4
	private static TextReader stdin; //Field offset: 0x8
	private static Encoding inputEncoding; //Field offset: 0xC
	private static Encoding outputEncoding; //Field offset: 0x10
	private static ConsoleCancelEventHandler cancel_event; //Field offset: 0x14
	private static readonly InternalCancelHandler cancel_handler; //Field offset: 0x18

	public static TextWriter Error
	{
		 get { } //Length: 4
	}

	public static Encoding InputEncoding
	{
		 get { } //Length: 89
	}

	public static TextWriter Out
	{
		 get { } //Length: 89
	}

	public static Encoding OutputEncoding
	{
		 get { } //Length: 89
	}

	private static Console() { }

	internal static void DoConsoleCancelEvent() { }

	public static TextWriter get_Error() { }

	public static Encoding get_InputEncoding() { }

	public static TextWriter get_Out() { }

	public static Encoding get_OutputEncoding() { }

	private static Stream Open(nint handle, FileAccess access, int bufferSize) { }

	public static Stream OpenStandardError(int bufferSize) { }

	public static Stream OpenStandardInput(int bufferSize) { }

	public static Stream OpenStandardOutput(int bufferSize) { }

	public static ConsoleKeyInfo ReadKey() { }

	public static ConsoleKeyInfo ReadKey(bool intercept) { }

	private static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding) { }

}

