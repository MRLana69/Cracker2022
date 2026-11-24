namespace System.IO;

internal class UnexceptionalStreamReader : StreamReader
{
	private static bool[] newline; //Field offset: 0x0
	private static char newlineChar; //Field offset: 0x4

	private static UnexceptionalStreamReader() { }

	public UnexceptionalStreamReader(Stream stream, Encoding encoding) { }

	private bool CheckEOL(char current) { }

	public override int Peek() { }

	public override int Read() { }

	public override int Read(out char[] dest_buffer, int index, int count) { }

	public override string ReadLine() { }

	public override string ReadToEnd() { }

}

