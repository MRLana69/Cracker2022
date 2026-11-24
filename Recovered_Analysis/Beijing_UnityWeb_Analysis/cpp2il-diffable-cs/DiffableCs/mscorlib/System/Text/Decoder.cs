namespace System.Text;

public abstract class Decoder
{
	internal DecoderFallback m_fallback; //Field offset: 0x8
	internal DecoderFallbackBuffer m_fallbackBuffer; //Field offset: 0xC

	public DecoderFallback Fallback
	{
		 get { } //Length: 59
	}

	public DecoderFallbackBuffer FallbackBuffer
	{
		 get { } //Length: 6
	}

	internal bool InternalHasFallbackBuffer
	{
		 get { } //Length: 63
	}

	protected Decoder() { }

	public DecoderFallback get_Fallback() { }

	public DecoderFallbackBuffer get_FallbackBuffer() { }

	internal bool get_InternalHasFallbackBuffer() { }

	public abstract int GetCharCount(byte[] bytes, int index, int count) { }

	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	public virtual void Reset() { }

	internal void SerializeDecoder(SerializationInfo info) { }

}

