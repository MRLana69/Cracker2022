namespace System.IO;

public static class Directory
{
	internal sealed class SearchData
	{
		public readonly string fullPath; //Field offset: 0x8
		public readonly string userPath; //Field offset: 0xC
		public readonly SearchOption searchOption; //Field offset: 0x10

		public SearchData(string fullPath, string userPath, SearchOption searchOption) { }

	}


	private static DirectoryInfo CreateDirectoriesInternal(string path) { }

	public static DirectoryInfo CreateDirectory(string path) { }

	public static void Delete(string path, bool recursive) { }

	public static void Delete(string path) { }

	public static bool Exists(string path) { }

	public static string GetCurrentDirectory() { }

	internal static string GetDemandDir(string fullPath, bool thisDirOnly) { }

	public static string[] GetDirectories(string path) { }

	public static string[] GetDirectories(string path, string searchPattern) { }

	public static string[] GetFiles(string path) { }

	public static string[] GetFiles(string path, string searchPattern) { }

	public static DirectoryInfo GetParent(string path) { }

	internal static string InsecureGetCurrentDirectory() { }

	private static string[] InternalGetDirectories(string path, string searchPattern, SearchOption searchOption) { }

	internal static string[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

	private static string[] InternalGetFiles(string path, string searchPattern, SearchOption searchOption) { }

	private static bool IsRootDirectory(string path) { }

	public static void Move(string sourceDirName, string destDirName) { }

	private static void RecursiveDelete(string path) { }

	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

}

