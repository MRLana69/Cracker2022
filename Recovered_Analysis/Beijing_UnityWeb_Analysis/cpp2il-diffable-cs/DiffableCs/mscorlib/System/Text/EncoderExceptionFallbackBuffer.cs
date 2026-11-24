namespace System.Text;

public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
{

	public override int Remaining
	{
		 get { } //Length: 3
	}

	public EncoderExceptionFallbackBuffer() { }

	public override bool Fallback(char charUnknown, int index) { }

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	public override int get_Remaining() { }

	public override char GetNextChar() { }

	public override bool MovePrevious() { }

}

