namespace System.Text;

public abstract class Encoder
{
	internal EncoderFallback m_fallback; //Field offset: 0x8
	internal EncoderFallbackBuffer m_fallbackBuffer; //Field offset: 0xC

	public EncoderFallback Fallback
	{
		 get { } //Length: 82
	}

	public EncoderFallbackBuffer FallbackBuffer
	{
		 get { } //Length: 6
	}

	internal bool InternalHasFallbackBuffer
	{
		 get { } //Length: 63
	}

	protected Encoder() { }

	public EncoderFallback get_Fallback() { }

	public EncoderFallbackBuffer get_FallbackBuffer() { }

	internal bool get_InternalHasFallbackBuffer() { }

	public abstract int GetByteCount(char[] chars, int index, int count, bool flush) { }

	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	public virtual void Reset() { }

	internal void SerializeEncoder(SerializationInfo info) { }

}

