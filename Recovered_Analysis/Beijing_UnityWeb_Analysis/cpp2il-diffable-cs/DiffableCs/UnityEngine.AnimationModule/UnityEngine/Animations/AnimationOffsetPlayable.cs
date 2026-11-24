namespace UnityEngine.Animations;

internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable>
{
	private static readonly AnimationOffsetPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationOffsetPlayable() { }

	internal AnimationOffsetPlayable(PlayableHandle handle) { }

	public bool Equals(AnimationOffsetPlayable other) { }

	public PlayableHandle GetHandle() { }

}

