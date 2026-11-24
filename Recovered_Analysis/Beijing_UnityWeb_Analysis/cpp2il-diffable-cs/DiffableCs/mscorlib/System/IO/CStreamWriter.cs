namespace System.IO;

internal class CStreamWriter : StreamWriter
{
	private TermInfoDriver driver; //Field offset: 0x38

	public CStreamWriter(Stream stream, Encoding encoding, bool leaveOpen) { }

	public void InternalWriteChar(char val) { }

	public void InternalWriteChars(char[] buffer, int n) { }

	public void InternalWriteString(string val) { }

	public override void Write(char[] buffer, int index, int count) { }

	public override void Write(char val) { }

	public override void Write(char[] val) { }

	public override void Write(string val) { }

}

