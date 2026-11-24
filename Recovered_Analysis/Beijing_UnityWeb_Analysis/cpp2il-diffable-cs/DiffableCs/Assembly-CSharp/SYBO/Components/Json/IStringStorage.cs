namespace SYBO.Components.Json;

public interface IStringStorage
{

	public bool CanRead
	{
		 get { } //Length: 0
	}

	public bool get_CanRead() { }

	public bool Overwrite(string content) { }

	public string Read() { }

}

