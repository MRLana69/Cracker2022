namespace Kiloo.Common.Backend;

public class Error
{
	public string category; //Field offset: 0x8
	public int code; //Field offset: 0xC
	public string message; //Field offset: 0x10
	public string exception; //Field offset: 0x14
	public Dictionary<string, string> info; //Field offset: 0x18

	public Error() { }

	public ErrorCategory GetErrorCategory() { }

	public static ErrorCategory GetErrorCategory(string category) { }

	public override string ToString() { }

}

