namespace Kiloo.Common.Utility;

public static class FileUtil
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<FileInfo> <>9__16_1; //Field offset: 0x4
		public static Predicate<FileInfo> <>9__19_0; //Field offset: 0x8
		public static Comparison<FileInfo> <>9__19_1; //Field offset: 0xC

		private static <>c() { }

		public <>c() { }

		internal int <GetFilesForPath>b__16_1(FileInfo a, FileInfo b) { }

		internal bool <Load>b__19_0(FileInfo file) { }

		internal int <Load>b__19_1(FileInfo a, FileInfo b) { }

	}

	private sealed class <>c__DisplayClass16_0
	{
		public bool slotsOnly; //Field offset: 0x8

		public <>c__DisplayClass16_0() { }

	}

	private sealed class <>c__DisplayClass16_1
	{
		public string name; //Field offset: 0x8
		public <>c__DisplayClass16_0 CS$<>8__locals1; //Field offset: 0xC

		public <>c__DisplayClass16_1() { }

		internal bool <GetFilesForPath>b__0(FileInfo file) { }

	}


	public static bool ArraysAreEqual(T[] a, T[] b) { }

	public static int CopyTo(Stream stream, Stream destination) { }

	public static FileInfo[] GetFilesForPath(string path, bool slotsOnly = false) { }

	public static DateTime GetLastWriteTimeUtc(FileInfo fileInfo) { }

	private static int GetMostRecentSlot(string path, bool fixTimestamps) { }

	private static int GetSlotForPath(string path) { }

	public static byte[] Load(string path, string secret = null, string alternatePath = null, bool useLastModifiedPathIfNoSlots = false) { }

	public static void Log(string msg) { }

	public static void LogError(string msg) { }

	public static void LogWarning(string msg) { }

	public static byte[] ReadAllBytes(Stream stream) { }

	public static byte[] ReadAllBytes(string filename) { }

	public static Dictionary<E, int> ReadEnumIntDictionary(BinaryReader reader) { }

	public static Dictionary<E, string> ReadEnumStringDictionary(BinaryReader reader) { }

	public static void ReadFully(Stream s, byte[] buffer, int offset, int count) { }

	public static void ReadFully(Stream s, byte[] buffer) { }

	public static Dictionary<string, string> ReadStringStringDictionary(BinaryReader reader) { }

	public static void SafeSave(string path, byte[] data, string secret = null, int offset = 0, int length = -1) { }

	public static void Save(string path, byte[] data, string secret = null, int offset = 0, int length = -1, int redundancy = 0, int slots = 0, string alternatePath = null, int alternateRedundancy = 0, int alternateSlots = 0) { }

	public static void SetLastWriteTimeUtc(FileInfo fileInfo, DateTime time) { }

	private static byte[] TryLoadFile(string path, byte[] secretBytes = null) { }

	public static void WriteAllBytes(string filename, byte[] bytes) { }

	public static void WriteEnumIntDictionary(BinaryWriter writer, IDictionary<E, int> dict) { }

	public static void WriteEnumStringDictionary(BinaryWriter writer, IDictionary<E, string> dict) { }

	public static void WriteStringStringDictionary(BinaryWriter writer, IDictionary<string, string> dict) { }

}

