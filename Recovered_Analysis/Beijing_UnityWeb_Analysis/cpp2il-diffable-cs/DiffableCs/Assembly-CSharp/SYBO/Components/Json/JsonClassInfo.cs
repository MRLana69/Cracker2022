namespace SYBO.Components.Json;

public class JsonClassInfo
{
	private static Dictionary<Type, JsonClassInfo> _cachedClassInfo; //Field offset: 0x80000000
	public readonly Type type; //Field offset: 0x8
	public readonly JsonFieldInfo[] CachedSerializedFields; //Field offset: 0xC
	public readonly JsonFieldInfo[] CachedSerializedStaticFields; //Field offset: 0x10
	private FieldInfo _keyField; //Field offset: 0x14
	private FieldInfo _jsonContextField; //Field offset: 0x18

	public bool TypeHasKey
	{
		 get { } //Length: 79
	}

	private static JsonClassInfo() { }

	private JsonClassInfo(Type reflectedType) { }

	public object Construct(JsonContext context) { }

	public static void DiscardClassInfoCache() { }

	public bool get_TypeHasKey() { }

	private JsonFieldInfo[] GetJsonFields(BindingFlags fieldFlags) { }

	public static JsonClassInfo GetJsonTypeReflection(Type reflectedType) { }

	public string GetKey(object obj) { }

	public static JsonClassInfo GetNonCachedTypeReflection(Type reflectedType) { }

	public static string GetSerializedName(FieldInfo field) { }

	public static bool IsClassInfoCached(Type reflectedType) { }

	private static Type LookupValueType(FieldInfo field) { }

	private static bool ShouldSerializeField(FieldInfo field, out bool serializeAsKey, out bool isKeyField, out bool enumAsString, out string serializedName, out int sizeLimit, out bool failOnSizeLimit) { }

}

