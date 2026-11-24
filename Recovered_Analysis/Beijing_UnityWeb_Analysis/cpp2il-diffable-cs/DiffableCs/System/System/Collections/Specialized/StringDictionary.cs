namespace System.Collections.Specialized;

public class StringDictionary : IEnumerable
{
	internal Hashtable contents; //Field offset: 0x8

	public StringDictionary() { }

	public virtual void Add(string key, string value) { }

	public virtual IEnumerator GetEnumerator() { }

}

