namespace System.Reflection;

public sealed class DefaultMemberAttribute : Attribute
{
	private string m_memberName; //Field offset: 0x8

	public string MemberName
	{
		 get { } //Length: 122
	}

	public DefaultMemberAttribute(string memberName) { }

	public string get_MemberName() { }

}

