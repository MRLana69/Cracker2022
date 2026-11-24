namespace System.Text;

public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
{
	private string strDefault; //Field offset: 0x10
	private int fallbackCount; //Field offset: 0x14
	private int fallbackIndex; //Field offset: 0x18

	public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback) { }

	public override bool Fallback(byte[] bytesUnknown, int index) { }

	public override char GetNextChar() { }

	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	public override void Reset() { }

}

