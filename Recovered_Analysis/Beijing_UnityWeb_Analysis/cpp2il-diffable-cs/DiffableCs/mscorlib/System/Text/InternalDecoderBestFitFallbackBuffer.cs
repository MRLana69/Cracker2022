namespace System.Text;

internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
{
	private static object s_InternalSyncObject; //Field offset: 0x0
	internal char cBestFit; //Field offset: 0x10
	internal int iCount; //Field offset: 0x14
	internal int iSize; //Field offset: 0x18
	private InternalDecoderBestFitFallback oFallback; //Field offset: 0x1C

	private static object InternalSyncObject
	{
		 get { } //Length: 3
	}

	public InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback) { }

	public override bool Fallback(byte[] bytesUnknown, int index) { }

	private static object get_InternalSyncObject() { }

	public override char GetNextChar() { }

	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	public override void Reset() { }

	private char TryBestFit(byte[] bytesCheck) { }

}

