namespace System.Text.RegularExpressions;

public class RegexMatchTimeoutException : TimeoutException, ISerializable
{
	private string regexInput; //Field offset: 0x44
	private string regexPattern; //Field offset: 0x48
	private TimeSpan matchTimeout; //Field offset: 0x50

	public RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	public RegexMatchTimeoutException() { }

	protected RegexMatchTimeoutException(SerializationInfo info, StreamingContext context) { }

	private void Init() { }

	private void Init(string input, string pattern, TimeSpan timeout) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

}

