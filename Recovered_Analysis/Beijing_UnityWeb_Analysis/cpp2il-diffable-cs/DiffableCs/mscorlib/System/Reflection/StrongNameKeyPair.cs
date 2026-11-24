namespace System.Reflection;

public class StrongNameKeyPair : ISerializable, IDeserializationCallback
{
	private byte[] _publicKey; //Field offset: 0x8
	private string _keyPairContainer; //Field offset: 0xC
	private bool _keyPairExported; //Field offset: 0x10
	private byte[] _keyPairArray; //Field offset: 0x14

	protected StrongNameKeyPair(SerializationInfo info, StreamingContext context) { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

