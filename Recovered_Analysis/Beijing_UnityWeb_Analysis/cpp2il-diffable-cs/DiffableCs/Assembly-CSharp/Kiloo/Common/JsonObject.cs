namespace Kiloo.Common;

public class JsonObject
{
	private readonly IDictionary _json; //Field offset: 0x8

	public object Item
	{
		 get { } //Length: 3
		 set { } //Length: 21
	}

	public JsonObject(object json = null) { }

	public bool CanSerialize() { }

	public static bool CanSerialize(object value) { }

	public static T ConvertValue(object json, IFormatProvider provider = null) { }

	public static JsonObject Deserialize(string json) { }

	public T Get(string key, IFormatProvider provider = null) { }

	public T Get(string key, T defaultValue, IFormatProvider provider = null) { }

	public static T Get(object jsonObject, string key, IFormatProvider provider = null) { }

	public static T Get(object jsonObject, string key, T defaultValue, IFormatProvider provider = null) { }

	public object get_Item(string key) { }

	public static bool HasKey(object jsonObject, string key) { }

	public bool HasKey(string key) { }

	public void Remove(string key) { }

	public string Serialize() { }

	public void set_Item(string key, object value) { }

	public static bool TryGet(object jsonObject, string key, out T result, IFormatProvider provider = null) { }

	public bool TryGet(string key, out T result, IFormatProvider provider = null) { }

}

