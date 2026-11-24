namespace SYBO.Components.Json;

public class JsonList
{

	public static JsonList EmptyList
	{
		 get { } //Length: 57
	}

	public JsonList() { }

	public JsonList(int capacity) { }

	public static JsonList get_EmptyList() { }

	public bool GetBool(int index, bool defaultValue = false) { }

	public JsonDict GetDict(int index) { }

	public double GetDouble(int index, double defaultValue = 0) { }

	public float GetFloat(int index, float defaultValue = 0) { }

	public int GetInt(int index, int defaultValue = 0) { }

	public long GetInt64(int index, long defaultValue = 0) { }

	public JsonList GetList(int index) { }

	public string GetString(int index, string defaultValue = "") { }

	public static JsonList ParseString(string json) { }

}

