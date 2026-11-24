namespace System.Text;

public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
{
	private string strDefault; //Field offset: 0x1C
	private int fallbackCount; //Field offset: 0x20
	private int fallbackIndex; //Field offset: 0x24

	public override int Remaining
	{
		 get { } //Length: 57
	}

	public EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback) { }

	public override bool Fallback(char charUnknown, int index) { }

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public override int get_Remaining() { }

	public override char GetNextChar() { }

	public override bool MovePrevious() { }

	public override void Reset() { }

}

