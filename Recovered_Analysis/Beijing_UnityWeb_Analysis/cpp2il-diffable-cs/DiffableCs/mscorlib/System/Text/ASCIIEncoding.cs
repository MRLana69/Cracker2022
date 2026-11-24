namespace System.Text;

public class ASCIIEncoding : Encoding
{

	public ASCIIEncoding() { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string chars) { }

	public override int GetByteCount(char* chars, int count) { }

	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	public override int GetBytes(string chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte* bytes, int count) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override string GetString(byte[] bytes, int byteIndex, int byteCount) { }

	internal override void SetDefaultFallbacks() { }

}

