namespace System.IO;

public sealed class FileInfo : FileSystemInfo
{
	private string _name; //Field offset: 0x48

	public override bool Exists
	{
		 get { } //Length: 6
	}

	public long Length
	{
		 get { } //Length: 129
	}

	public override string Name
	{
		 get { } //Length: 178
	}

	public FileInfo(string fileName) { }

	private FileInfo(SerializationInfo info, StreamingContext context) { }

	public override void Delete() { }

	public override bool get_Exists() { }

	public long get_Length() { }

	public override string get_Name() { }

	private string GetDisplayPath(string originalPath) { }

	private void Init(string fileName, bool checkHost) { }

	public FileStream OpenRead() { }

	public override string ToString() { }

}

