namespace UnityEngine.Experimental.Animations;

public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable>
{
	private static readonly AnimationScriptPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationScriptPlayable() { }

	internal AnimationScriptPlayable(PlayableHandle handle) { }

	public bool Equals(AnimationScriptPlayable other) { }

	public PlayableHandle GetHandle() { }

}

