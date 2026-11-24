namespace System.Text;

internal class EncoderNLS : Encoder, ISerializable
{
	internal char charLeftOver; //Field offset: 0x10
	protected Encoding m_encoding; //Field offset: 0x14
	protected bool m_mustFlush; //Field offset: 0x18
	internal bool m_throwOnOverflow; //Field offset: 0x19
	internal int m_charsUsed; //Field offset: 0x1C

	public Encoding Encoding
	{
		 get { } //Length: 44
	}

	public bool MustFlush
	{
		 get { } //Length: 6
	}

	internal EncoderNLS(SerializationInfo info, StreamingContext context) { }

	internal EncoderNLS(Encoding encoding) { }

	internal EncoderNLS() { }

	internal void ClearMustFlush() { }

	public Encoding get_Encoding() { }

	public bool get_MustFlush() { }

	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	public override int GetByteCount(char* chars, int count, bool flush) { }

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	public override void Reset() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

