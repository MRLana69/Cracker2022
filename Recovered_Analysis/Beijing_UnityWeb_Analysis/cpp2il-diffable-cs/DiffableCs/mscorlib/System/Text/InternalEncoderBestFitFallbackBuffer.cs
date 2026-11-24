namespace System.Text;

internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
{
	private static object s_InternalSyncObject; //Field offset: 0x0
	private char cBestFit; //Field offset: 0x1C
	private InternalEncoderBestFitFallback oFallback; //Field offset: 0x20
	private int iCount; //Field offset: 0x24
	private int iSize; //Field offset: 0x28

	private static object InternalSyncObject
	{
		 get { } //Length: 520
	}

	public override int Remaining
	{
		 get { } //Length: 50
	}

	public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback) { }

	public override bool Fallback(char charUnknown, int index) { }

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	private static object get_InternalSyncObject() { }

	public override int get_Remaining() { }

	public override char GetNextChar() { }

	public override bool MovePrevious() { }

	public override void Reset() { }

	private char TryBestFit(char cUnknown) { }

}

