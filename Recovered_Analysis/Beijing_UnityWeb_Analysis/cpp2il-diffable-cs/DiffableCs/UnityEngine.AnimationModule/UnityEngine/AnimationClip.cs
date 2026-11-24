namespace UnityEngine;

public sealed class AnimationClip : Motion
{

	public float frameRate
	{
		 get { } //Length: 49
	}

	public float length
	{
		 get { } //Length: 420
	}

	public WrapMode wrapMode
	{
		 get { } //Length: 150
	}

	public AnimationClip() { }

	public void AddEvent(AnimationEvent evt) { }

	internal void AddEventInternal(object evt) { }

	public float get_frameRate() { }

	public float get_length() { }

	public WrapMode get_wrapMode() { }

	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	public void SampleAnimation(GameObject go, float time) { }

	internal static void SampleAnimation(GameObject go, AnimationClip clip, float inTime, WrapMode wrapMode) { }

}

