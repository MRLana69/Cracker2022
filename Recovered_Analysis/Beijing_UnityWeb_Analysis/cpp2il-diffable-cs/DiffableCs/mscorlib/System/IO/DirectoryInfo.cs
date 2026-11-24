namespace System.IO;

public sealed class DirectoryInfo : FileSystemInfo
{
	private string current; //Field offset: 0x48
	private string parent; //Field offset: 0x4C

	public override bool Exists
	{
		 get { } //Length: 3
	}

	public override string Name
	{
		 get { } //Length: 51
	}

	public DirectoryInfo Parent
	{
		 get { } //Length: 6
	}

	public DirectoryInfo(string path) { }

	internal DirectoryInfo(string path, bool simpleOriginalPath) { }

	private DirectoryInfo(SerializationInfo info, StreamingContext context) { }

	internal void CheckPath(string path) { }

	public void Create() { }

	public override void Delete() { }

	public void Delete(bool recursive) { }

	public override bool get_Exists() { }

	public override string get_Name() { }

	public DirectoryInfo get_Parent() { }

	public DirectoryInfo[] GetDirectories() { }

	public DirectoryInfo[] GetDirectories(string searchPattern) { }

	public FileInfo[] GetFiles() { }

	public FileInfo[] GetFiles(string searchPattern) { }

	private void Initialize() { }

	public override string ToString() { }

}

