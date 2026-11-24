namespace System.Text;

public class UTF8Encoding : Encoding
{
	internal class UTF8Decoder : DecoderNLS, ISerializable
	{
		internal int bits; //Field offset: 0x1C

		internal override bool HasState
		{
			 get { } //Length: 70
		}

		public UTF8Decoder(UTF8Encoding encoding) { }

		internal UTF8Decoder(SerializationInfo info, StreamingContext context) { }

		internal override bool get_HasState() { }

		public override void Reset() { }

		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	internal class UTF8Encoder : EncoderNLS, ISerializable
	{
		internal int surrogateChar; //Field offset: 0x20

		public UTF8Encoder(UTF8Encoding encoding) { }

		internal UTF8Encoder(SerializationInfo info, StreamingContext context) { }

		public override void Reset() { }

		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	private bool emitUTF8Identifier; //Field offset: 0x1C
	private bool isThrowException; //Field offset: 0x1D

	public UTF8Encoding() { }

	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier) { }

	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) { }

	public override bool Equals(object value) { }

	private int FallbackInvalidByteSequence(byte* pSrc, int ch, DecoderFallbackBuffer fallback) { }

	private bool FallbackInvalidByteSequence(ref byte* pSrc, int ch, DecoderFallbackBuffer fallback, ref char* pTarget) { }

	internal override int GetByteCount(char* chars, int count, EncoderNLS baseEncoder) { }

	public override int GetByteCount(char[] chars, int index, int count) { }

	public override int GetByteCount(char* chars, int count) { }

	public override int GetByteCount(string chars) { }

	public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS baseEncoder) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount) { }

	private byte[] GetBytesUnknown(ref byte* pSrc, int ch) { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte* bytes, int count) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder) { }

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

	private static bool InRange(int ch, int start, int end) { }

	private static int PtrDiff(byte* a, byte* b) { }

	private static int PtrDiff(char* a, char* b) { }

	internal override void SetDefaultFallbacks() { }

}

