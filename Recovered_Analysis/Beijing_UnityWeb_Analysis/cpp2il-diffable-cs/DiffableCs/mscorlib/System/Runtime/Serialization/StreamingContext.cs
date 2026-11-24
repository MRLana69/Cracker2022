namespace System.Runtime.Serialization;

public struct StreamingContext
{
	internal object m_additionalContext; //Field offset: 0x0
	internal StreamingContextStates m_state; //Field offset: 0x4

	public StreamingContextStates State
	{
		 get { } //Length: 9
	}

	public StreamingContext(StreamingContextStates state) { }

	public StreamingContext(StreamingContextStates state, object additional) { }

	public override bool Equals(object obj) { }

	public StreamingContextStates get_State() { }

	public override int GetHashCode() { }

}

