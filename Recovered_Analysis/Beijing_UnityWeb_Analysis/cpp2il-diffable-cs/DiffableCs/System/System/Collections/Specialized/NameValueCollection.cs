namespace System.Collections.Specialized;

public class NameValueCollection : NameObjectCollectionBase
{
	private string[] _all; //Field offset: 0x24
	private string[] _allKeys; //Field offset: 0x28

	public string Item
	{
		 get { } //Length: 63
	}

	public NameValueCollection() { }

	public NameValueCollection(int capacity, IEqualityComparer equalityComparer) { }

	internal NameValueCollection(DBNull dummy) { }

	protected NameValueCollection(SerializationInfo info, StreamingContext context) { }

	public virtual void Add(string name, string value) { }

	public virtual string Get(string name) { }

	public virtual string Get(int index) { }

	public string get_Item(string name) { }

	private static string GetAsOneString(ArrayList list) { }

	public virtual string GetKey(int index) { }

	protected void InvalidateCachedArrays() { }

}

