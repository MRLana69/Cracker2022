namespace System.Text;

public class UnicodeEncoding : Encoding
{
	private class Decoder : DecoderNLS, ISerializable
	{
		internal int lastByte; //Field offset: 0x1C
		internal char lastChar; //Field offset: 0x20

		internal override bool HasState
		{
			 get { } //Length: 103
		}

		public Decoder(UnicodeEncoding encoding) { }

		internal Decoder(SerializationInfo info, StreamingContext context) { }

		internal override bool get_HasState() { }

		public override void Reset() { }

		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private static readonly ulong highLowPatternMask; //Field offset: 0x0
	internal bool isThrowException; //Field offset: 0x1C
	internal bool bigEndian; //Field offset: 0x1D
	internal bool byteOrderMark; //Field offset: 0x1E

	private static UnicodeEncoding() { }

	public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes) { }

	public UnicodeEncoding() { }

	public UnicodeEncoding(bool bigEndian, bool byteOrderMark) { }

	public override bool Equals(object value) { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string s) { }

	public override int GetByteCount(char* chars, int count) { }

	internal override int GetByteCount(char* chars, int count, EncoderNLS encoder) { }

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	public override int GetCharCount(byte* bytes, int count) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

	public override int GetHashCode() { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override byte[] GetPreamble() { }

	public override string GetString(byte[] bytes, int index, int count) { }

	private void OnDeserializing(StreamingContext ctx) { }

	internal override void SetDefaultFallbacks() { }

}

