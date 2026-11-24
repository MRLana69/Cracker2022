namespace UnityEngine;

public class WWW : CustomYieldInstruction, IDisposable
{
	private UnityWebRequest _uwr; //Field offset: 0x8
	private Dictionary<string, string> _responseHeaders; //Field offset: 0xC

	public string error
	{
		 get { } //Length: 15
	}

	public bool isDone
	{
		 get { } //Length: 188
	}

	public override bool keepWaiting
	{
		 get { } //Length: 12
	}

	public Dictionary<string, string> responseHeaders
	{
		 get { } //Length: 12
	}

	public string text
	{
		 get { } //Length: 351
	}

	public Texture2D texture
	{
		 get { } //Length: 112
	}

	public string url
	{
		 get { } //Length: 11
	}

	public WWW(string url) { }

	public WWW(string url, WWWForm form) { }

	public WWW(string url, byte[] postData, Dictionary<string, string> headers) { }

	private Texture2D CreateTextureFromDownloadedData(bool markNonReadable) { }

	public void Dispose() { }

	public static string EscapeURL(string s) { }

	public static string EscapeURL(string s, Encoding e) { }

	public string get_error() { }

	public bool get_isDone() { }

	public override bool get_keepWaiting() { }

	public Dictionary<string, string> get_responseHeaders() { }

	public string get_text() { }

	public Texture2D get_texture() { }

	public string get_url() { }

	public void LoadImageIntoTexture(Texture2D texture) { }

	private bool WaitUntilDoneIfPossible() { }

}

