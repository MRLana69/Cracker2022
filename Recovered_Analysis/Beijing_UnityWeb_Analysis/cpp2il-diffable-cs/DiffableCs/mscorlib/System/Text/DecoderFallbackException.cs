namespace System.Text;

public sealed class DecoderFallbackException : ArgumentException
{
	private byte[] bytesUnknown; //Field offset: 0x48
	private int index; //Field offset: 0x4C

	public DecoderFallbackException() { }

	internal DecoderFallbackException(SerializationInfo info, StreamingContext context) { }

	public DecoderFallbackException(string message, byte[] bytesUnknown, int index) { }

}

