namespace UnityEngine.Playables;

public struct Playable : IEquatable<Playable>
{
	private static readonly Playable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	public static Playable Null
	{
		 get { } //Length: 7
	}

	private static Playable() { }

	internal Playable(PlayableHandle handle) { }

	public bool Equals(Playable other) { }

	public static Playable get_Null() { }

	public PlayableHandle GetHandle() { }

}

