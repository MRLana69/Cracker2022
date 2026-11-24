namespace System.Runtime.Serialization;

public sealed class SafeSerializationEventArgs : EventArgs
{
	private StreamingContext m_streamingContext; //Field offset: 0x8
	private List<object> m_serializedStates; //Field offset: 0x10

	internal IList<object> SerializedStates
	{
		 get { } //Length: 6
	}

	internal SafeSerializationEventArgs(StreamingContext streamingContext) { }

	internal IList<object> get_SerializedStates() { }

}

