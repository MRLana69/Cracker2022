namespace System.Text;

public sealed class UTF32Encoding : Encoding
{
	internal class UTF32Decoder : DecoderNLS
	{
		internal int iChar; //Field offset: 0x1C
		internal int readByteCount; //Field offset: 0x20

		internal override bool HasState
		{
			 get { } //Length: 103
		}

		public UTF32Decoder(UTF32Encoding encoding) { }

		internal override bool get_HasState() { }

		public override void Reset() { }

	}

	private bool emitUTF32ByteOrderMark; //Field offset: 0x1C
	private bool isThrowException; //Field offset: 0x1D
	private bool bigEndian; //Field offset: 0x1E

	public UTF32Encoding() { }

	public UTF32Encoding(bool bigEndian, bool byteOrderMark) { }

	public UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters) { }

	public override bool Equals(object value) { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string s) { }

	public override int GetByteCount(char* chars, int count) { }

	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte* bytes, int count) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

	public override int GetHashCode() { }

	private char GetHighSurrogate(uint iChar) { }

	private char GetLowSurrogate(uint iChar) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override byte[] GetPreamble() { }

	public override string GetString(byte[] bytes, int index, int count) { }

	private uint GetSurrogate(char cHigh, char cLow) { }

	internal override void SetDefaultFallbacks() { }

}

