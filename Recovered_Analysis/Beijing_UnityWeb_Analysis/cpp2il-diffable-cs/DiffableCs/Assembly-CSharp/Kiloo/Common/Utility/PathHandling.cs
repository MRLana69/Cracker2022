namespace Kiloo.Common.Utility;

public static class PathHandling
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<string, bool> <>9__2_0; //Field offset: 0x4
		public static Predicate<string> <>9__2_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <RelativeToAbsolutePath>b__2_0(string s) { }

		internal bool <RelativeToAbsolutePath>b__2_1(string s) { }

	}


	public static string AbsoluteToRelativePath(string filePath) { }

	public static string AbsoluteToRelativePath(string filePath, string basePath) { }

	public static void OpenPathInExplorer(string path) { }

	public static string RelativeToAbsolutePath(string filePath) { }

	public static string RelativeToAbsolutePath(string filePath, string basePath) { }

	public static string UnifyDirectorySeparators(string path) { }

}

