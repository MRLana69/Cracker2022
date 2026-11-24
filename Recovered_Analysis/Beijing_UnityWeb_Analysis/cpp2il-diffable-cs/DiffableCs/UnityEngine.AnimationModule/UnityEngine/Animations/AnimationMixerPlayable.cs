namespace UnityEngine.Animations;

public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable>
{
	private static readonly AnimationMixerPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationMixerPlayable() { }

	internal AnimationMixerPlayable(PlayableHandle handle) { }

	public bool Equals(AnimationMixerPlayable other) { }

	public PlayableHandle GetHandle() { }

}

