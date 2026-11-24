namespace UnityEngine.Animations;

public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable>
{
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationLayerMixerPlayable() { }

	internal AnimationLayerMixerPlayable(PlayableHandle handle) { }

	public bool Equals(AnimationLayerMixerPlayable other) { }

	public PlayableHandle GetHandle() { }

}

