namespace System.Text;

internal sealed class InternalDecoderBestFitFallback : DecoderFallback
{
	internal Encoding encoding; //Field offset: 0xC
	internal char[] arrayBestFit; //Field offset: 0x10
	internal char cReplacement; //Field offset: 0x14

	public override int MaxCharCount
	{
		 get { } //Length: 59
	}

	internal InternalDecoderBestFitFallback(Encoding encoding) { }

	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	public override bool Equals(object value) { }

	public override int get_MaxCharCount() { }

	public override int GetHashCode() { }

}

