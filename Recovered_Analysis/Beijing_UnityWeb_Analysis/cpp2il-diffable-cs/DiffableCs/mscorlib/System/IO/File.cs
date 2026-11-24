namespace System.IO;

public static class File
{
	private static Nullable<DateTime> defaultLocalFileTime; //Field offset: 0x0

	private static DateTime DefaultLocalFileTime
	{
		 get { } //Length: 112
	}

	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	public static FileStream Create(string path) { }

	public static FileStream Create(string path, int bufferSize) { }

	public static void Delete(string path) { }

	public static bool Exists(string path) { }

	internal static int FillAttributeInfo(string path, ref MonoIOStat data, bool tryagain, bool returnErrorOnNotFound) { }

	private static DateTime get_DefaultLocalFileTime() { }

	public static FileAttributes GetAttributes(string path) { }

	public static DateTime GetCreationTime(string path) { }

	public static DateTime GetLastWriteTime(string path) { }

	public static void Move(string sourceFileName, string destFileName) { }

	public static FileStream Open(string path, FileMode mode) { }

	public static FileStream OpenRead(string path) { }

	public static StreamReader OpenText(string path) { }

	public static byte[] ReadAllBytes(string path) { }

	public static string ReadAllText(string path) { }

	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	public static void WriteAllBytes(string path, byte[] bytes) { }

	public static void WriteAllText(string path, string contents) { }

	public static void WriteAllText(string path, string contents, Encoding encoding) { }

}

