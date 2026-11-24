namespace SYBO.Components.Json.Internal;

public static class JsonReflectionParser
{
	public const string DateTimeFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFF'Z'"; //Field offset: 0x0
	public const string DateTimeFormatString2 = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'"; //Field offset: 0x0

	public static void CollectReferenceUnknownKeys(Type type, object value, JsonContext context, Dictionary<Type, HashSet<string>> output) { }

	private static object ConvertOrDefault(object value) { }

	private static void CreateFileReference(object obj, JsonFieldInfo field, JsonContext context) { }

	public static T Deserialize(object json, JsonContext context = null) { }

	public static object Deserialize(Type type, object json, JsonContext context = null) { }

	public static void DeserializeFieldOnto(JsonFieldInfo jsonField, object obj, JsonDict json, JsonContext context) { }

	private static void DeserializeFieldsOnto(JsonFieldInfo[] fields, object obj, JsonDict json, JsonContext context) { }

	public static void DeserializeOnto(T obj, JsonDict json, JsonContext context = null) { }

	private static object DictionaryResolveKey(string key, Type type, JsonContext context) { }

	private static string GetKey(object obj, Type type) { }

	private static bool NeedsFileReference(JsonFieldInfo field) { }

	public static void PrepareReflectionForSerialization(Type[] serializationObjectTypes) { }

	private static void PrepareReflectionRecursively(Type type, HashSet<Type> preparedClasses) { }

	public static object ReadReference(Type type, object value, JsonContext context) { }

	private static void RecursiveReadField(object obj, FieldInfo field, object jsonValue, JsonContext context) { }

	private static object RecursiveReadObject(Type objType, JsonDict json, JsonContext context) { }

	private static object RecursiveReadValue(Type type, object value, JsonContext context) { }

	private static JsonDict RecursiveWriteObject(object obj, JsonContext context) { }

	private static object RecursiveWriteValue(object value, Type ft, JsonFieldInfo field, JsonContext context) { }

	public static object ReflectionDeserialize(Type objType, JsonDict json, JsonContext context) { }

	public static void ReflectionDeserializeOnto(Type objType, object obj, JsonDict json, JsonContext context) { }

	public static JsonDict ReflectionSerialize(Type type, object obj, JsonContext context) { }

	public static object Serialize(Type type, object obj, JsonContext context = null) { }

	public static object Serialize(T obj, JsonContext context = null) { }

	private static void SerializeFieldsFrom(JsonFieldInfo[] fields, object obj, JsonDict json, JsonContext context) { }

}

