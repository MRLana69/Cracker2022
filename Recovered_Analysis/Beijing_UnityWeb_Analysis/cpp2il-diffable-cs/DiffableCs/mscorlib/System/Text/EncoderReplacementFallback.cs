namespace System.Text;

public sealed class EncoderReplacementFallback : EncoderFallback
{
	private string strDefault; //Field offset: 0xC

	public string DefaultString
	{
		 get { } //Length: 9
	}

	public override int MaxCharCount
	{
		 get { } //Length: 59
	}

	public EncoderReplacementFallback() { }

	public EncoderReplacementFallback(string replacement) { }

	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	public override bool Equals(object value) { }

	public string get_DefaultString() { }

	public override int get_MaxCharCount() { }

	public override int GetHashCode() { }

}

