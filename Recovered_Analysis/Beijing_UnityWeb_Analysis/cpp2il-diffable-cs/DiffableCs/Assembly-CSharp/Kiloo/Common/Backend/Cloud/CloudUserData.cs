namespace Kiloo.Common.Backend.Cloud;

public class CloudUserData : ICloudUserData, IEnumerable<KeyValuePair<string, string>>, IEnumerable
{
	private readonly IDictionary<string, string> _dict; //Field offset: 0x8

	public string Item
	{
		 get { } //Length: 69
	}

	public CloudUserData() { }

	public CloudUserData(IDictionary<string, string> dict) { }

	public void Add(string key, string value) { }

	public string get_Item(string key) { }

	public IEnumerator<KeyValuePair<string, string>> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

