namespace SYBO.Components.Utilities;

public class SerializableDictionary`2 : ISerializationCallbackReceiver
{
	private readonly string ErrorMsgFormat; //Field offset: 0x0
	private List<TKey> _keys; //Field offset: 0x0
	private List<TValue> _values; //Field offset: 0x0

	public SerializableDictionary`2() { }

	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

