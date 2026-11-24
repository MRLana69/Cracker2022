namespace System.Text;

internal class Latin1Encoding : EncodingNLS, ISerializable
{
	private static readonly char[] arrayCharBestFit; //Field offset: 0x0

	private static Latin1Encoding() { }

	public Latin1Encoding() { }

	internal Latin1Encoding(SerializationInfo info, StreamingContext context) { }

	internal override char[] GetBestFitUnicodeToBytesData() { }

	internal override int GetByteCount(char* chars, int charCount, EncoderNLS encoder) { }

	internal override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder) { }

	internal override int GetCharCount(byte* bytes, int count, DecoderNLS decoder) { }

	internal override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder) { }

	public override int GetMaxByteCount(int charCount) { }

	public override int GetMaxCharCount(int byteCount) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

