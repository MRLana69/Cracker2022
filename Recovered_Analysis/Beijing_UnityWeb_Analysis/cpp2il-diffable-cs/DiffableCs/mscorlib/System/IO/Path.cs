namespace System.IO;

public static class Path
{
	public static readonly char[] InvalidPathChars; //Field offset: 0x0
	public static readonly char AltDirectorySeparatorChar; //Field offset: 0x4
	public static readonly char DirectorySeparatorChar; //Field offset: 0x6
	public static readonly char PathSeparator; //Field offset: 0x8
	internal static readonly string DirectorySeparatorStr; //Field offset: 0xC
	public static readonly char VolumeSeparatorChar; //Field offset: 0x10
	internal static readonly char[] PathSeparatorChars; //Field offset: 0x14
	private static readonly bool dirEqualsVolume; //Field offset: 0x18
	internal static readonly char[] trimEndCharsWindows; //Field offset: 0x1C
	internal static readonly char[] trimEndCharsUnix; //Field offset: 0x20

	internal static string DirectorySeparatorCharAsString
	{
		 get { } //Length: 211
	}

	internal static char[] TrimEndChars
	{
		 get { } //Length: 89
	}

	private static Path() { }

	private static string CanonicalizePath(string path) { }

	internal static void CheckInvalidPathChars(string path, bool checkAdditional = false) { }

	internal static void CheckSearchPattern(string searchPattern) { }

	internal static string CleanPath(string s) { }

	public static string Combine(string path1, string path2) { }

	public static string Combine(string[] paths) { }

	public static string Combine(string path1, string path2, string path3) { }

	private static int findExtension(string path) { }

	internal static string get_DirectorySeparatorCharAsString() { }

	private static string get_temp_path() { }

	internal static char[] get_TrimEndChars() { }

	public static string GetDirectoryName(string path) { }

	public static string GetExtension(string path) { }

	public static string GetFileName(string path) { }

	public static string GetFullPath(string path) { }

	internal static string GetFullPathInternal(string path) { }

	internal static string GetFullPathName(string path) { }

	private static int GetFullPathName(string path, int numBufferChars, StringBuilder buffer, ref nint lpFilePartOrNull) { }

	public static char[] GetInvalidPathChars() { }

	public static string GetPathRoot(string path) { }

	public static string GetRandomFileName() { }

	private static string GetServerAndShare(string path) { }

	public static string GetTempPath() { }

	internal static string InsecureGetFullPath(string path) { }

	internal static string InternalCombine(string path1, string path2) { }

	internal static bool IsDirectorySeparator(char c) { }

	public static bool IsPathRooted(string path) { }

	private static bool SameRoot(string root, string path) { }

	internal static void Validate(string path, string parameterName) { }

	internal static void Validate(string path) { }

	internal static string WindowsDriveAdjustment(string path) { }

}

