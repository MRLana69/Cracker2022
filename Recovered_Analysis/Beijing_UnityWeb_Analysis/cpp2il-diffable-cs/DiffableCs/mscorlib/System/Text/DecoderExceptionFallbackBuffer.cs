namespace System.Text;

public sealed class DecoderExceptionFallbackBuffer : DecoderFallbackBuffer
{

	public DecoderExceptionFallbackBuffer() { }

	public override bool Fallback(byte[] bytesUnknown, int index) { }

	public override char GetNextChar() { }

	private void Throw(byte[] bytesUnknown, int index) { }

}

