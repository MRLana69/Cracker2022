namespace System.Text.RegularExpressions;

internal class GroupEnumerator : IEnumerator
{
	internal GroupCollection _rgc; //Field offset: 0x8
	internal int _curindex; //Field offset: 0xC

	public Capture Capture
	{
		 get { } //Length: 9
	}

	public object Current
	{
		 get { } //Length: 50
	}

	internal GroupEnumerator(GroupCollection rgc) { }

	public Capture get_Capture() { }

	public object get_Current() { }

	public bool MoveNext() { }

	public void Reset() { }

}

