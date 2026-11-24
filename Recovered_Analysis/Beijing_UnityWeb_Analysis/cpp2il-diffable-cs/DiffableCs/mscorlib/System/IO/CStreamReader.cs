namespace System.IO;

internal class CStreamReader : StreamReader
{
	private TermInfoDriver driver; //Field offset: 0x40

	public CStreamReader(Stream stream, Encoding encoding) { }

	public override int Peek() { }

	public override int Read() { }

	public override int Read(out char[] dest, int index, int count) { }

	public override string ReadLine() { }

	public override string ReadToEnd() { }

}

