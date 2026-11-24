namespace SYBO.Components.Json;

public class JsonDict
{

	public static JsonDict EmptyDict
	{
		 get { } //Length: 77
	}

	public JsonDict() { }

	public JsonDict(int capacity) { }

	public static JsonDict Deserialize(string json) { }

	public static JsonDict get_EmptyDict() { }

	public bool GetBool(string name, bool defaultValue = false) { }

	public JsonDict GetDict(string name) { }

	public double GetDouble(string name, double defaultValue = 0) { }

	public float GetFloat(string name, float defaultValue = 0) { }

	public int GetInt(string name, int defaultValue = 0) { }

	public long GetInt64(string name, long defaultValue = 0) { }

	public JsonList GetList(string name) { }

	public JsonDict GetOrCreateDict(string name) { }

	public JsonList GetOrCreateList(string name) { }

	public string GetString(string name, string defaultValue = "") { }

	public string Serialize() { }

}

