namespace Microsoft.Win32;

internal static class Win32Native
{
	internal class WIN32_FIND_DATA
	{
		internal int dwFileAttributes; //Field offset: 0x8
		internal string cFileName; //Field offset: 0xC

		public WIN32_FIND_DATA() { }

	}


	public static string GetMessage(int hr) { }

	public static int MakeHRFromErrorCode(int errorCode) { }

}

