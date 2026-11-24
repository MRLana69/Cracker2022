namespace System.Text;

internal class DecoderNLS : Decoder, ISerializable
{
	protected Encoding m_encoding; //Field offset: 0x10
	protected bool m_mustFlush; //Field offset: 0x14
	internal bool m_throwOnOverflow; //Field offset: 0x15
	internal int m_bytesUsed; //Field offset: 0x18

	internal virtual bool HasState
	{
		 get { } //Length: 9
	}

	public bool MustFlush
	{
		 get { } //Length: 3
	}

	internal DecoderNLS(SerializationInfo info, StreamingContext context) { }

	internal DecoderNLS(Encoding encoding) { }

	internal DecoderNLS() { }

	internal void ClearMustFlush() { }

	internal virtual bool get_HasState() { }

	public bool get_MustFlush() { }

	public override int GetCharCount(byte[] bytes, int index, int count) { }

	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	public override void Reset() { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

