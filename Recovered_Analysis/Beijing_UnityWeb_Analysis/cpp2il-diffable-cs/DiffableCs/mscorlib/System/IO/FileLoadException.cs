namespace System.IO;

public class FileLoadException : IOException
{
	private string _fileName; //Field offset: 0x48
	private string _fusionLog; //Field offset: 0x4C

	public string FusionLog
	{
		 get { } //Length: 721
	}

	public override string Message
	{
		 get { } //Length: 6
	}

	public FileLoadException() { }

	public FileLoadException(string message) { }

	protected FileLoadException(SerializationInfo info, StreamingContext context) { }

	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }

	public string get_FusionLog() { }

	public override string get_Message() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private void SetMessageField() { }

	public override string ToString() { }

}

