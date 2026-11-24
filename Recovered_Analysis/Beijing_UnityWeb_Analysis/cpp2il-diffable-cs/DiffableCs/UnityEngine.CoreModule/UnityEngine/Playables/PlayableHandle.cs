namespace UnityEngine.Playables;

public struct PlayableHandle : IEquatable<PlayableHandle>
{
	private static readonly PlayableHandle m_Null; //Field offset: 0x0
	internal nint m_Handle; //Field offset: 0x0
	internal uint m_Version; //Field offset: 0x4

	public static PlayableHandle Null
	{
		 get { } //Length: 2
	}

	private static PlayableHandle() { }

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	public override bool Equals(object p) { }

	public bool Equals(PlayableHandle other) { }

	public static PlayableHandle get_Null() { }

	public override int GetHashCode() { }

	internal Type GetPlayableType() { }

	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

	internal bool IsPlayableOfType() { }

	internal bool IsValid() { }

	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

}

