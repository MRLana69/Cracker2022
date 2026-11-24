namespace Kiloo.Common.HTTP.Internal;

internal class Response : IResponse
{
	private int <status>k__BackingField; //Field offset: 0x8
	private string <message>k__BackingField; //Field offset: 0xC
	private byte[] <bytes>k__BackingField; //Field offset: 0x10
	private Headers <headers>k__BackingField; //Field offset: 0x14

	public byte[] bytes
	{
		 get { } //Length: 6
		internal set { } //Length: 11
	}

	public ResponseCategory category
	{
		 get { } //Length: 6
	}

	public Headers headers
	{
		 get { } //Length: 6
		internal set { } //Length: 11
	}

	public string message
	{
		 get { } //Length: 6
		internal set { } //Length: 8
	}

	public int status
	{
		 get { } //Length: 289
		internal set { } //Length: 475
	}

	public Response(int status, string message, Headers headers, byte[] bytes) { }

	public Response(Headers headers, byte[] bytes) { }

	public byte[] get_bytes() { }

	public ResponseCategory get_category() { }

	public Headers get_headers() { }

	public string get_message() { }

	public int get_status() { }

	internal void set_bytes(byte[] value) { }

	internal void set_headers(Headers value) { }

	internal void set_message(string value) { }

	internal void set_status(int value) { }

}

