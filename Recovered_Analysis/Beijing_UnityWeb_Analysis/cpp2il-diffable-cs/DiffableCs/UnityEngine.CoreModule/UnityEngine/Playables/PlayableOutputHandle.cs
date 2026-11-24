namespace UnityEngine.Playables;

public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle>
{
	private static readonly PlayableOutputHandle m_Null; //Field offset: 0x0
	internal nint m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x4

	public static PlayableOutputHandle Null
	{
		 get { } //Length: 119
	}

	private static PlayableOutputHandle() { }

	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	public override bool Equals(object p) { }

	public bool Equals(PlayableOutputHandle other) { }

	public static PlayableOutputHandle get_Null() { }

	public override int GetHashCode() { }

	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

}

