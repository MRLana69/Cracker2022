namespace SYBO.Components.Json;

public class JsonCustomSerializerCollection
{
	private Dictionary<Type, JsonCustomSerializer> _customSerializers; //Field offset: 0x8

	public int CustomSerializerCount
	{
		 get { } //Length: 144
	}

	public JsonCustomSerializerCollection() { }

	public void AddSerializer(Type type, JsonCustomSerializer serializer) { }

	public object Deserialize(Type type, JsonDict json, JsonContext context) { }

	public object DeserializeList(Type type, JsonList json, JsonContext context) { }

	public JsonCustomSerializerCollection Duplicate() { }

	public int get_CustomSerializerCount() { }

	public bool HasSerializer(Type type) { }

	public JsonDict Serialize(Type type, object obj, JsonContext context) { }

	public JsonList SerializeList(Type type, object obj, JsonContext context) { }

}

