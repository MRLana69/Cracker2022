namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class NameCache
{
	private static ConcurrentDictionary<string, object> ht; //Field offset: 0x0
	private string name; //Field offset: 0x8

	private static NameCache() { }

	public NameCache() { }

	internal object GetCachedValue(string name) { }

	internal void SetCachedValue(object value) { }

}

