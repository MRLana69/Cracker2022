namespace System.Text;

internal abstract class EncodingNLS : Encoding
{

	protected EncodingNLS(int codePage) { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string s) { }

	public override int GetByteCount(char* chars, int count) { }

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

	public override string GetString(byte[] bytes, int index, int count) { }

}

