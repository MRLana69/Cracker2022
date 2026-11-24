namespace SYBO.Components.Json;

public class FileStringStorage : IStringStorage
{
	private string _path; //Field offset: 0x8

	private bool SYBO.Components.Json.IStringStorage.CanRead
	{
		 get { } //Length: 635
	}

	public FileStringStorage(string path) { }

	private Stream CreateStream() { }

	private bool SYBO.Components.Json.IStringStorage.get_CanRead() { }

	private bool SYBO.Components.Json.IStringStorage.Overwrite(string content) { }

	private string SYBO.Components.Json.IStringStorage.Read() { }

}

