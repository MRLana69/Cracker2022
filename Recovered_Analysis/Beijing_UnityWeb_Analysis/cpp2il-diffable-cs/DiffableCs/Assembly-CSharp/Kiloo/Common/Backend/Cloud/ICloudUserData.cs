namespace Kiloo.Common.Backend.Cloud;

public interface ICloudUserData : IEnumerable<KeyValuePair<string, string>>, IEnumerable
{

	public string Item
	{
		 get { } //Length: 0
	}

	public string get_Item(string key) { }

}

