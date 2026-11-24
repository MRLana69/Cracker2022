namespace System.Text.RegularExpressions;

public class Capture
{
	internal string _text; //Field offset: 0x8
	internal int _index; //Field offset: 0xC
	internal int _length; //Field offset: 0x10

	public int Index
	{
		 get { } //Length: 6
	}

	public int Length
	{
		 get { } //Length: 6
	}

	public string Value
	{
		 get { } //Length: 6
	}

	internal Capture(string text, int i, int l) { }

	internal Capture() { }

	public int get_Index() { }

	public int get_Length() { }

	public string get_Value() { }

	internal string GetLeftSubstring() { }

	internal string GetOriginalString() { }

	internal string GetRightSubstring() { }

	public override string ToString() { }

}

