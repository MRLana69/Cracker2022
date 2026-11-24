namespace SYBO.Components.Json;

public class JsonContext
{
	private class DeserializeByKeyReferenceData
	{
		public object obj; //Field offset: 0x8
		public JsonFieldInfo field; //Field offset: 0xC
		public object json; //Field offset: 0x10
		public DeserializeByKeyReferenceData next; //Field offset: 0x14

		public DeserializeByKeyReferenceData() { }

	}

	private class SerializationCallback
	{
		public ISerializationCallbackReceiver serializedInterface; //Field offset: 0x8
		public SerializationCallback next; //Field offset: 0xC

		public SerializationCallback() { }

	}

	private class SerializeByKeyReferenceData
	{
		public JsonFieldInfo field; //Field offset: 0x8
		public object json; //Field offset: 0xC
		public SerializeByKeyReferenceData next; //Field offset: 0x10

		public SerializeByKeyReferenceData() { }

	}

	public class SubtreeFileReference
	{
		public string Filename; //Field offset: 0x8
		public object SubObject; //Field offset: 0xC
		public JsonFieldInfo Field; //Field offset: 0x10

		public SubtreeFileReference() { }

	}

	public const int MaximumNestingDepth = 100; //Field offset: 0x0
	public JsonObjectStore ObjectStore; //Field offset: 0x8
	public JsonCustomSerializerCollection CustomSerializers; //Field offset: 0xC
	public bool TolerateBlindReferencesOnSerialize; //Field offset: 0x10
	public bool RemoveWhitespace; //Field offset: 0x11
	public bool IncludeStatics; //Field offset: 0x12
	public Predicate<JsonFieldInfo> ShouldFilterField; //Field offset: 0x14
	public List<SubtreeFileReference> JsonFileReferences; //Field offset: 0x18
	private int nestedDeserializeCounter; //Field offset: 0x1C
	private int nestedSerializeCounter; //Field offset: 0x20
	private DeserializeByKeyReferenceData _referenceDataToBeResolved; //Field offset: 0x24
	private SerializeByKeyReferenceData _referenceDataToBeValidated; //Field offset: 0x28
	private SerializationCallback _lastSerializationCallback; //Field offset: 0x2C
	private SerializationCallback _firstSerializationCallback; //Field offset: 0x30

	public JsonContext() { }

	public void BeginDeserialize() { }

	public void BeginSerialize() { }

	public Dictionary<Type, HashSet<string>> CollectUnknownReferences() { }

	public T Deserialize(object json) { }

	public JsonContext Duplicate() { }

	public void EndDeserialize() { }

	public void EndSerialize() { }

	private void InvokeSerializationEvents() { }

	public void RegisterDeserializeByKeyReference(object obj, JsonFieldInfo field, object json) { }

	public void RegisterSerializationCallBack(ISerializationCallbackReceiver serializedInterface) { }

	public void RegisterSerializeByKeyReference(JsonFieldInfo field, object json) { }

	public void ResolveKnownReferences() { }

	private void ResolveReferences() { }

	public object Serialize(T data) { }

	private void ValidateReferences() { }

}

