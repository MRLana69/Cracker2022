namespace System.IO;

internal static class MonoIO
{
	public static readonly nint InvalidHandle; //Field offset: 0x0
	private static bool dump_handles; //Field offset: 0x4

	public static char AltDirectorySeparatorChar
	{
		 get { } //Length: 3
	}

	public static nint ConsoleError
	{
		 get { } //Length: 5
	}

	public static nint ConsoleInput
	{
		 get { } //Length: 5
	}

	public static nint ConsoleOutput
	{
		 get { } //Length: 7
	}

	public static char DirectorySeparatorChar
	{
		 get { } //Length: 3
	}

	public static char PathSeparator
	{
		 get { } //Length: 3
	}

	public static char VolumeSeparatorChar
	{
		 get { } //Length: 5
	}

	private static MonoIO() { }

	public static bool Close(nint handle, out MonoIOError error) { }

	public static bool CopyFile(string path, string dest, bool overwrite, out MonoIOError error) { }

	private static bool CopyFile(char* path, char* dest, bool overwrite, out MonoIOError error) { }

	private static bool CreateDirectory(char* path, out MonoIOError error) { }

	public static bool CreateDirectory(string path, out MonoIOError error) { }

	public static bool CreatePipe(out nint read_handle, out nint write_handle, out MonoIOError error) { }

	private static bool DeleteFile(char* path, out MonoIOError error) { }

	public static bool DeleteFile(string path, out MonoIOError error) { }

	private static void DumpHandles() { }

	public static bool DuplicateHandle(nint source_process_handle, nint source_handle, nint target_process_handle, out nint target_handle, int access, int inherit, int options, out MonoIOError error) { }

	public static bool Exists(string path, out MonoIOError error) { }

	public static bool ExistsDirectory(string path, out MonoIOError error) { }

	public static bool ExistsFile(string path, out MonoIOError error) { }

	public static bool ExistsSymlink(string path, out MonoIOError error) { }

	public static bool FindCloseFile(nint hnd) { }

	private static nint FindFirstFile(char* pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	public static nint FindFirstFile(string pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	public static bool FindNextFile(nint hnd, out string fileName, out int fileAttr, out int error) { }

	public static char get_AltDirectorySeparatorChar() { }

	public static nint get_ConsoleError() { }

	public static nint get_ConsoleInput() { }

	public static nint get_ConsoleOutput() { }

	public static char get_DirectorySeparatorChar() { }

	public static char get_PathSeparator() { }

	public static char get_VolumeSeparatorChar() { }

	public static string GetCurrentDirectory(out MonoIOError error) { }

	public static Exception GetException(MonoIOError error) { }

	public static Exception GetException(string path, MonoIOError error) { }

	private static FileAttributes GetFileAttributes(char* path, out MonoIOError error) { }

	public static FileAttributes GetFileAttributes(string path, out MonoIOError error) { }

	public static bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error) { }

	private static bool GetFileStat(char* path, out MonoIOStat stat, out MonoIOError error) { }

	private static MonoFileType GetFileType(nint handle, out MonoIOError error) { }

	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	private static long GetLength(nint handle, out MonoIOError error) { }

	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	private static bool MoveFile(char* path, char* dest, out MonoIOError error) { }

	public static bool MoveFile(string path, string dest, out MonoIOError error) { }

	public static nint Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	private static nint Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	private static int Read(nint handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	public static bool RemapPath(string path, out string newPath) { }

	public static bool RemoveDirectory(string path, out MonoIOError error) { }

	private static bool RemoveDirectory(char* path, out MonoIOError error) { }

	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	private static long Seek(nint handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	public static bool SetFileTime(string path, int type, long creation_time, long last_access_time, long last_write_time, DateTime dateTime, out MonoIOError error) { }

	private static bool SetFileTime(nint handle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	public static bool SetFileTime(SafeHandle safeHandle, long creation_time, long last_access_time, long last_write_time, out MonoIOError error) { }

	public static bool SetLastWriteTime(string path, DateTime dateTime, out MonoIOError error) { }

	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	private static bool SetLength(nint handle, long length, out MonoIOError error) { }

	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	private static int Write(nint handle, in byte[] src, int src_offset, int count, out MonoIOError error) { }

}

