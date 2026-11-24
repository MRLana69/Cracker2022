namespace System.Runtime.Serialization;

internal sealed class SafeSerializationManager : IObjectReference, ISerializable
{
	private const string RealTypeSerializationName = "CLR_SafeSerializationManager_RealType"; //Field offset: 0x0
	private IList<object> m_serializedStates; //Field offset: 0x8
	private SerializationInfo m_savedSerializationInfo; //Field offset: 0xC
	private object m_realObject; //Field offset: 0x10
	private RuntimeType m_realType; //Field offset: 0x14
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; //Field offset: 0x18

	internal bool IsActive
	{
		 get { } //Length: 6
	}

	internal SafeSerializationManager() { }

	private SafeSerializationManager(SerializationInfo info, StreamingContext context) { }

	internal void CompleteDeserialization(object deserializedObject) { }

	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	internal bool get_IsActive() { }

	private void OnDeserialized(StreamingContext context) { }

	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

