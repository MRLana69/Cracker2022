//Type is in global namespace

public class ASCIIEncoding : Encoding
{
	public static readonly Encoding ASCII; //Field offset: 0x0

	private static ASCIIEncoding() { }

	public ASCIIEncoding() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetCharCount(byte[] bytes) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

}

