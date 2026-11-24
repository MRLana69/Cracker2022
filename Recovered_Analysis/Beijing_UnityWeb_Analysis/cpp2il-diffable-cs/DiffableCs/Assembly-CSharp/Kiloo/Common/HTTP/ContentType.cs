namespace Kiloo.Common.HTTP;

public class ContentType
{
	public readonly string type; //Field offset: 0x8
	public readonly string subType; //Field offset: 0xC
	private readonly IDictionary<string, string> _parameters; //Field offset: 0x10

	public IEnumerable<KeyValuePair<string, string>> parameters
	{
		 get { } //Length: 12
	}

	public ContentType(string type, string subType, IDictionary<string, string> parameters) { }

	public IEnumerable<KeyValuePair<string, string>> get_parameters() { }

	public string GetParameter(string name) { }

}

