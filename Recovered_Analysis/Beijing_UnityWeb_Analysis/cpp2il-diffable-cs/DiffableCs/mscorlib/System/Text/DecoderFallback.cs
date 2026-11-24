namespace System.Text;

public abstract class DecoderFallback
{
	private static DecoderFallback replacementFallback; //Field offset: 0x0
	private static DecoderFallback exceptionFallback; //Field offset: 0x4
	private static object s_InternalSyncObject; //Field offset: 0x8
	internal bool bIsMicrosoftBestFitFallback; //Field offset: 0x8

	public static DecoderFallback ExceptionFallback
	{
		 get { } //Length: 520
	}

	private static object InternalSyncObject
	{
		 get { } //Length: 115
	}

	public abstract int MaxCharCount
	{
		 get { } //Length: 0
	}

	public static DecoderFallback ReplacementFallback
	{
		 get { } //Length: 118
	}

	protected DecoderFallback() { }

	public abstract DecoderFallbackBuffer CreateFallbackBuffer() { }

	public static DecoderFallback get_ExceptionFallback() { }

	private static object get_InternalSyncObject() { }

	public abstract int get_MaxCharCount() { }

	public static DecoderFallback get_ReplacementFallback() { }

}

