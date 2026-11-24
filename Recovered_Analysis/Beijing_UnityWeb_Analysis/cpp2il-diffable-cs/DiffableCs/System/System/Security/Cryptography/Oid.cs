namespace System.Security.Cryptography;

public sealed class Oid
{
	private string m_value; //Field offset: 0x8
	private string m_friendlyName; //Field offset: 0xC
	private OidGroup m_group; //Field offset: 0x10

	public string FriendlyName
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public string Value
	{
		 get { } //Length: 9
		 set { } //Length: 121
	}

	public Oid() { }

	public Oid(string oid) { }

	internal Oid(string oid, OidGroup group, bool lookupFriendlyName) { }

	public Oid(string value, string friendlyName) { }

	public Oid(Oid oid) { }

	private Oid(string value, string friendlyName, OidGroup group) { }

	public static Oid FromFriendlyName(string friendlyName, OidGroup group) { }

	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	public string get_FriendlyName() { }

	public string get_Value() { }

	public void set_FriendlyName(string value) { }

	public void set_Value(string value) { }

}

