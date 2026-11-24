namespace System.Text;

internal class InternalEncoderBestFitFallback : EncoderFallback
{
	internal Encoding encoding; //Field offset: 0xC
	internal char[] arrayBestFit; //Field offset: 0x10

	public override int MaxCharCount
	{
		 get { } //Length: 59
	}

	internal InternalEncoderBestFitFallback(Encoding encoding) { }

	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	public override bool Equals(object value) { }

	public override int get_MaxCharCount() { }

	public override int GetHashCode() { }

}

