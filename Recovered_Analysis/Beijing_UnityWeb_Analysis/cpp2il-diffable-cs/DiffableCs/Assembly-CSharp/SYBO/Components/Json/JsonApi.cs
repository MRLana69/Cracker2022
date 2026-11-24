namespace SYBO.Components.Json;

public class JsonApi
{

	public static int BuilderCapacity
	{
		 get { } //Length: 7
		 set { } //Length: 2
	}

	public JsonApi() { }

	public static T Deserialize(string json, JsonContext context = null) { }

	public static object DeserializeDom(string json) { }

	public static int get_BuilderCapacity() { }

	public static int GetLastErrorIndex() { }

	public static string GetLastErrorSnippet() { }

	public static bool LastDecodeSuccessful() { }

	public static void PrepareReflectionForSerialization(Type[] serializationObjectTypes) { }

	public static T ReflectionDeserializeDom(object jsonobj, JsonContext context = null) { }

	public static object ReflectionDeserializeDom(Type type, object jsonobj, JsonContext context = null) { }

	public static object ReflectionDeserializeDomAsType(Type objType, JsonDict json, JsonContext context = null) { }

	public static object ReflectionSerializeDom(Type type, object data, JsonContext context = null) { }

	public static object ReflectionSerializeDom(T data, JsonContext context = null) { }

	public static JsonDict ReflectionSerializeDomAsType(Type objType, object obj, JsonContext context = null) { }

	public static string Serialize(T obj, JsonContext context = null) { }

	public static string SerializeDom(object json, JsonContext context = null) { }

	public static void set_BuilderCapacity(int value) { }

}

