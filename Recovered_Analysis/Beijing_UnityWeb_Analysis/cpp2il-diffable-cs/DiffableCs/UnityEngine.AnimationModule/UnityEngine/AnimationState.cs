namespace UnityEngine;

public sealed class AnimationState : TrackedReference
{

	public AnimationBlendMode blendMode
	{
		 set { } //Length: 13
	}

	public AnimationClip clip
	{
		 get { } //Length: 49
	}

	public bool enabled
	{
		 get { } //Length: 35
		 set { } //Length: 18
	}

	public int layer
	{
		 set { } //Length: 53
	}

	public float length
	{
		 get { } //Length: 49
	}

	public string name
	{
		 get { } //Length: 49
	}

	public float normalizedTime
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public float speed
	{
		 get { } //Length: 49
		 set { } //Length: 52
	}

	public float time
	{
		 get { } //Length: 6
		 set { } //Length: 52
	}

	public float weight
	{
		 set { } //Length: 8
	}

	public WrapMode wrapMode
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public AnimationState() { }

	public void AddMixingTransform(Transform mix) { }

	public void AddMixingTransform(Transform mix, bool recursive) { }

	public AnimationClip get_clip() { }

	public bool get_enabled() { }

	public float get_length() { }

	public string get_name() { }

	public float get_normalizedTime() { }

	public float get_speed() { }

	public float get_time() { }

	public WrapMode get_wrapMode() { }

	public void set_blendMode(AnimationBlendMode value) { }

	public void set_enabled(bool value) { }

	public void set_layer(int value) { }

	public void set_normalizedTime(float value) { }

	public void set_speed(float value) { }

	public void set_time(float value) { }

	public void set_weight(float value) { }

	public void set_wrapMode(WrapMode value) { }

}

