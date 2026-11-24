namespace System;

public sealed class CharEnumerator : IEnumerator, ICloneable, IEnumerator<char>, IDisposable
{
	private string str; //Field offset: 0x8
	private int index; //Field offset: 0xC
	private char currentElement; //Field offset: 0x10

	public char Current
	{
		 get { } //Length: 202
	}

	private object System.Collections.IEnumerator.Current
	{
		 get { } //Length: 73
	}

	internal CharEnumerator(string str) { }

	internal CharEnumerator() { }

	public object Clone() { }

	public void Dispose() { }

	public char get_Current() { }

	public bool MoveNext() { }

	public void Reset() { }

	private object System.Collections.IEnumerator.get_Current() { }

}

