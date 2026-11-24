namespace System.IO;

public class StringReader : TextReader
{
	private string _s; //Field offset: 0xC
	private int _pos; //Field offset: 0x10
	private int _length; //Field offset: 0x14

	public StringReader(string s) { }

	public override void Close() { }

	protected override void Dispose(bool disposing) { }

	public override int Peek() { }

	public override int Read() { }

	public override int Read(out char[] buffer, int index, int count) { }

	public override string ReadLine() { }

	public override string ReadToEnd() { }

}

