namespace System.Text;

public abstract class DecoderFallbackBuffer
{
	internal byte* byteStart; //Field offset: 0x8
	internal char* charEnd; //Field offset: 0xC

	protected DecoderFallbackBuffer() { }

	public abstract bool Fallback(byte[] bytesUnknown, int index) { }

	public abstract char GetNextChar() { }

	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	internal void InternalReset() { }

	public virtual void Reset() { }

	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

}

