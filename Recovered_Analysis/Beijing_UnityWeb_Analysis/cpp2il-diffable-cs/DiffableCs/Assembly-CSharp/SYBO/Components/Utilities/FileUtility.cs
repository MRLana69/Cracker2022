namespace SYBO.Components.Utilities;

public static class FileUtility
{
	private sealed class <GetFiles>d__8 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private string <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private string directoryPath; //Field offset: 0x14
		public string <>3__directoryPath; //Field offset: 0x18
		private string fileSearchPattern; //Field offset: 0x1C
		public string <>3__fileSearchPattern; //Field offset: 0x20
		private Queue<string> <queue>5__2; //Field offset: 0x24
		private string[] <files>5__3; //Field offset: 0x28
		private int <i>5__4; //Field offset: 0x2C

		private string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			 get { } //Length: 1106
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <GetFiles>d__8(int <>1__state) { }

		private bool MoveNext() { }

		private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public const string LocalPathPrefix = "file://"; //Field offset: 0x0

	public static string CombinePaths(string pathA, string pathB, bool fixSlashesToMatchSystem = true) { }

	public static string ConvertAbsolutePathToAssetFolderRelativePath(string absolutePath, bool fixSlashesToMatchSystem = true) { }

	public static string ConvertAssetFolderRelativePathToAbsolutePath(string assetFolderRelativePath, bool fixSlashesToMatchSystem = true) { }

	public static string ConvertSlashesToSystemSeperatorChar(string path) { }

	public static string ConvertToPathWithBackSlashes(string path) { }

	public static string ConvertToPathWithForwardSlashes(string path) { }

	public static IEnumerable<string> GetFiles(string directoryPath, string fileSearchPattern) { }

	public static bool IsLocalPath(string path) { }

	public static void MoveDirectory(string path, string newPath) { }

}

