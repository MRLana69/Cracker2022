namespace UnityEngine.Animations;

public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable>
{
	private static readonly AnimatorControllerPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimatorControllerPlayable() { }

	internal AnimatorControllerPlayable(PlayableHandle handle) { }

	public bool Equals(AnimatorControllerPlayable other) { }

	public PlayableHandle GetHandle() { }

	public void SetHandle(PlayableHandle handle) { }

}

