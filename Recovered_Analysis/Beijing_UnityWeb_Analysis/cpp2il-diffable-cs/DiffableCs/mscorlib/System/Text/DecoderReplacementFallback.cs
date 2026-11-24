namespace System.Text;

public sealed class DecoderReplacementFallback : DecoderFallback
{
	private string strDefault; //Field offset: 0xC

	public string DefaultString
	{
		 get { } //Length: 3
	}

	public override int MaxCharCount
	{
		 get { } //Length: 78
	}

	public DecoderReplacementFallback() { }

	public DecoderReplacementFallback(string replacement) { }

	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	public override bool Equals(object value) { }

	public string get_DefaultString() { }

	public override int get_MaxCharCount() { }

	public override int GetHashCode() { }

}

