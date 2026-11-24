namespace System.IO;

internal sealed class SearchResult
{
	private string fullPath; //Field offset: 0x8
	private string userPath; //Field offset: 0xC
	private WIN32_FIND_DATA findData; //Field offset: 0x10

	internal WIN32_FIND_DATA FindData
	{
		 get { } //Length: 6
	}

	internal string UserPath
	{
		 get { } //Length: 6
	}

	internal SearchResult(string fullPath, string userPath, WIN32_FIND_DATA findData) { }

	internal WIN32_FIND_DATA get_FindData() { }

	internal string get_UserPath() { }

}

