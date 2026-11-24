namespace System.Net;

public sealed class FtpWebRequest : WebRequest
{
	private static readonly string[] supportedCommands; //Field offset: 0x0
	private Uri requestUri; //Field offset: 0x14
	private IWebProxy proxy; //Field offset: 0x18
	private int timeout; //Field offset: 0x1C
	private int rwTimeout; //Field offset: 0x20
	private bool binary; //Field offset: 0x24
	private bool usePassive; //Field offset: 0x25
	private string method; //Field offset: 0x28
	private object locker; //Field offset: 0x2C
	private Encoding dataEncoding; //Field offset: 0x30

	private static FtpWebRequest() { }

	internal FtpWebRequest(Uri uri) { }

}

