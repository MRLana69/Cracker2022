namespace UnityEngine.Playables;

public struct PlayableBinding
{
	internal delegate CreateOutputMethod
	{

		public CreateOutputMethod(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(PlayableGraph graph, string name, AsyncCallback callback, object object) { }

		public virtual PlayableOutput EndInvoke(IAsyncResult result) { }

		public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }

	}

	public static readonly PlayableBinding[] None; //Field offset: 0x0
	public static readonly double DefaultDuration; //Field offset: 0x8
	private string m_StreamName; //Field offset: 0x0
	private Object m_SourceObject; //Field offset: 0x4
	private Type m_SourceBindingType; //Field offset: 0x8
	private CreateOutputMethod m_CreateOutputMethod; //Field offset: 0xC

	private static PlayableBinding() { }

}

