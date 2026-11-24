namespace SYBO.Components.Utilities;

public class SerializableSystemType : ISerializationCallbackReceiver
{
	private string _assemblyQualifiedName; //Field offset: 0x8
	private Type _systemType; //Field offset: 0xC

	public Type SystemType
	{
		 get { } //Length: 145
		 set { } //Length: 11
	}

	public SerializableSystemType(Type systemType) { }

	public override bool Equals(object obj) { }

	public bool Equals(SerializableSystemType otherSystemType) { }

	public Type get_SystemType() { }

	public override int GetHashCode() { }

	public static bool op_Equality(SerializableSystemType a, SerializableSystemType b) { }

	public static bool op_Inequality(SerializableSystemType a, SerializableSystemType b) { }

	public void set_SystemType(Type value) { }

	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

