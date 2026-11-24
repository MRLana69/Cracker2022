namespace Kiloo.Common.Backend.Authentication;

public interface IKilooAuthPlatform
{

	public string name
	{
		 get { } //Length: 0
	}

	public string signature
	{
		 get { } //Length: 0
	}

	public IDictionary<string, string> value
	{
		 get { } //Length: 0
	}

	public string get_name() { }

	public string get_signature() { }

	public IDictionary<string, string> get_value() { }

	public Coroutine UpdateAsync() { }

}

