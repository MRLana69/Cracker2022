namespace System.Text;

public class UTF7Encoding : Encoding
{
	private class Decoder : DecoderNLS, ISerializable
	{
		internal int bits; //Field offset: 0x1C
		internal int bitCount; //Field offset: 0x20
		internal bool firstByte; //Field offset: 0x24

		internal override bool HasState
		{
			 get { } //Length: 59
		}

		public Decoder(UTF7Encoding encoding) { }

		internal Decoder(SerializationInfo info, StreamingContext context) { }

		internal override bool get_HasState() { }

		public override void Reset() { }

		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	internal sealed class DecoderUTF7Fallback : DecoderFallback
	{

		public override int MaxCharCount
		{
			 get { } //Length: 56
		}

		public DecoderUTF7Fallback() { }

		public override DecoderFallbackBuffer CreateFallbackBuffer() { }

		public override bool Equals(object value) { }

		public override int get_MaxCharCount() { }

		public override int GetHashCode() { }

	}

	internal sealed class DecoderUTF7FallbackBuffer : DecoderFallbackBuffer
	{
		private char cFallback; //Field offset: 0x10
		private int iCount; //Field offset: 0x14
		private int iSize; //Field offset: 0x18

		public DecoderUTF7FallbackBuffer(DecoderUTF7Fallback fallback) { }

		public override bool Fallback(byte[] bytesUnknown, int index) { }

		public override char GetNextChar() { }

		internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

		public override void Reset() { }

	}

	private class Encoder : EncoderNLS, ISerializable
	{
		internal int bits; //Field offset: 0x20
		internal int bitCount; //Field offset: 0x24

		public Encoder(UTF7Encoding encoding) { }

		internal Encoder(SerializationInfo info, StreamingContext context) { }

		public override void Reset() { }

		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private byte[] base64Bytes; //Field offset: 0x1C
	private sbyte[] base64Values; //Field offset: 0x20
	private bool[] directEncode; //Field offset: 0x24
	private bool m_allowOptionals; //Field offset: 0x28

	public UTF7Encoding() { }

	public UTF7Encoding(bool allowOptionals) { }

	public override bool Equals(object value) { }

	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	public override int GetByteCount(char* chars, int count) { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(string s) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte* bytes, int count) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder) { }

	public override Decoder GetDecoder() { }

	public override Encoder GetEncoder() { }

	public override int GetHashCode() { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	public override string GetString(byte[] bytes, int index, int count) { }

	private void MakeTables() { }

	private void OnDeserialized(StreamingContext ctx) { }

	private void OnDeserializing(StreamingContext ctx) { }

	internal override void SetDefaultFallbacks() { }

}

