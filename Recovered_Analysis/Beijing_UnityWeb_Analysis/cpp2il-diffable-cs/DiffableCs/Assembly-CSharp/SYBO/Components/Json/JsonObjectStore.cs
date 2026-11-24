namespace SYBO.Components.Json;

public class JsonObjectStore
{
	private class JsonObjectStoreTypeEntry
	{
		private Dictionary<string, object> _storedObjects; //Field offset: 0x8
		public Type StoreType; //Field offset: 0xC

		public JsonObjectStoreTypeEntry() { }

		public void Add(string key, object obj) { }

		public bool Contains(string key) { }

		public JsonObjectStoreTypeEntry Duplicate() { }

		public object Get(string key) { }

	}

	private Dictionary<Type, JsonObjectStoreTypeEntry> _types; //Field offset: 0x8

	public JsonObjectStore() { }

	public JsonObjectStore Duplicate() { }

	public T Get(object key) { }

	public object Get(Type type, object key) { }

	public bool HasObject(Type type, object key) { }

	public void Set(object key, T obj) { }

	public void Set(Type type, object key, object obj) { }

}

