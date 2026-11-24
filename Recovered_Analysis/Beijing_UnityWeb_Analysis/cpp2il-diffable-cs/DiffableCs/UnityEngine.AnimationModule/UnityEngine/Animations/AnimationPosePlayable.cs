namespace UnityEngine.Animations;

internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable>
{
	private static readonly AnimationPosePlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationPosePlayable() { }

	internal AnimationPosePlayable(PlayableHandle handle) { }

	public bool Equals(AnimationPosePlayable other) { }

	public PlayableHandle GetHandle() { }

}

