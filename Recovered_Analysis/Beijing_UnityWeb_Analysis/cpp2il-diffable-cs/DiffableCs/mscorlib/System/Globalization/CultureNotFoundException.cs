namespace System.Globalization;

public class CultureNotFoundException : ArgumentException, ISerializable
{
	private string m_invalidCultureName; //Field offset: 0x48
	private Nullable<int> m_invalidCultureId; //Field offset: 0x4C

	private static string DefaultMessage
	{
		 get { } //Length: 183
	}

	private string FormatedInvalidCultureId
	{
		 get { } //Length: 6
	}

	public virtual Nullable<int> InvalidCultureId
	{
		 get { } //Length: 9
	}

	public virtual string InvalidCultureName
	{
		 get { } //Length: 800
	}

	public override string Message
	{
		 get { } //Length: 218
	}

	public CultureNotFoundException() { }

	public CultureNotFoundException(string paramName, string message) { }

	public CultureNotFoundException(string paramName, string invalidCultureName, string message) { }

	protected CultureNotFoundException(SerializationInfo info, StreamingContext context) { }

	private static string get_DefaultMessage() { }

	private string get_FormatedInvalidCultureId() { }

	public virtual Nullable<int> get_InvalidCultureId() { }

	public virtual string get_InvalidCultureName() { }

	public override string get_Message() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

