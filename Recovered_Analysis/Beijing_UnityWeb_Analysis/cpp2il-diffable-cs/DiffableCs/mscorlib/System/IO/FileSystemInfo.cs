namespace System.IO;

public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
{
	private const int ERROR_INVALID_PARAMETER = 87; //Field offset: 0x0
	internal const int ERROR_ACCESS_DENIED = 5; //Field offset: 0x0
	internal MonoIOStat _data; //Field offset: 0x10
	internal int _dataInitialised; //Field offset: 0x38
	protected string FullPath; //Field offset: 0x3C
	protected string OriginalPath; //Field offset: 0x40
	private string _displayPath; //Field offset: 0x44

	internal string DisplayPath
	{
		 get { } //Length: 6
		 set { } //Length: 178
	}

	public abstract bool Exists
	{
		 get { } //Length: 0
	}

	public virtual string FullName
	{
		 get { } //Length: 10
	}

	public DateTime LastWriteTimeUtc
	{
		 get { } //Length: 83
		 set { } //Length: 6
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	protected FileSystemInfo() { }

	protected FileSystemInfo(SerializationInfo info, StreamingContext context) { }

	public abstract void Delete() { }

	internal string get_DisplayPath() { }

	public abstract bool get_Exists() { }

	public virtual string get_FullName() { }

	public DateTime get_LastWriteTimeUtc() { }

	public abstract string get_Name() { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public void Refresh() { }

	internal void set_DisplayPath(string value) { }

	public void set_LastWriteTimeUtc(DateTime value) { }

}

