namespace Kiloo.Common.HTTP;

public interface IResponse
{

	public byte[] bytes
	{
		 get { } //Length: 0
	}

	public ResponseCategory category
	{
		 get { } //Length: 0
	}

	public Headers headers
	{
		 get { } //Length: 0
	}

	public string message
	{
		 get { } //Length: 0
	}

	public int status
	{
		 get { } //Length: 0
	}

	public byte[] get_bytes() { }

	public ResponseCategory get_category() { }

	public Headers get_headers() { }

	public string get_message() { }

	public int get_status() { }

}

