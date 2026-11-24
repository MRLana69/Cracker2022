namespace System.Text.RegularExpressions;

public class Group : Capture
{
	internal static Group _emptygroup; //Field offset: 0x0
	internal int[] _caps; //Field offset: 0x14
	internal int _capcount; //Field offset: 0x18
	internal string _name; //Field offset: 0x1C

	public bool Success
	{
		 get { } //Length: 9
	}

	private static Group() { }

	internal Group(string text, int[] caps, int capcount, string name) { }

	internal Group() { }

	public bool get_Success() { }

}

