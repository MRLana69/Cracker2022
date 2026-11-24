namespace UnityEngine;

public class WWWForm
{
	private List<byte[]> formData; //Field offset: 0x8
	private List<string> fieldNames; //Field offset: 0xC
	private List<string> fileNames; //Field offset: 0x10
	private List<string> types; //Field offset: 0x14
	private byte[] boundary; //Field offset: 0x18
	private bool containsFiles; //Field offset: 0x1C

	public byte[] data
	{
		 get { } //Length: 263
	}

	internal static Encoding DefaultEncoding
	{
		 get { } //Length: 47
	}

	public Dictionary<string, string> headers
	{
		 get { } //Length: 91
	}

	public WWWForm() { }

	public void AddField(string fieldName, string value) { }

	public void AddField(string fieldName, string value, Encoding e) { }

	public void AddField(string fieldName, int i) { }

	public byte[] get_data() { }

	internal static Encoding get_DefaultEncoding() { }

	public Dictionary<string, string> get_headers() { }

}

