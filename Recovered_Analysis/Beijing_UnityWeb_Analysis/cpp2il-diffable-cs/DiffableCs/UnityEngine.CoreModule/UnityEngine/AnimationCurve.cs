namespace UnityEngine;

public class AnimationCurve : IEquatable<AnimationCurve>
{
	internal nint m_Ptr; //Field offset: 0x8

	public Keyframe Item
	{
		 get { } //Length: 7
	}

	public Keyframe[] keys
	{
		 get { } //Length: 49
		 set { } //Length: 14
	}

	public int length
	{
		 get { } //Length: 9
	}

	public WrapMode postWrapMode
	{
		 set { } //Length: 53
	}

	public WrapMode preWrapMode
	{
		 set { } //Length: 53
	}

	public AnimationCurve(Keyframe[] keys) { }

	public AnimationCurve() { }

	public int AddKey(Keyframe key) { }

	public int AddKey(float time, float value) { }

	private int AddKey_Internal(Keyframe key) { }

	private int AddKey_Internal_Injected(ref Keyframe key) { }

	public bool Equals(AnimationCurve other) { }

	public override bool Equals(object o) { }

	public float Evaluate(float time) { }

	protected override void Finalize() { }

	public Keyframe get_Item(int index) { }

	public Keyframe[] get_keys() { }

	public int get_length() { }

	public override int GetHashCode() { }

	private Keyframe GetKey(int index) { }

	private void GetKey_Injected(int index, out Keyframe ret) { }

	private Keyframe[] GetKeys() { }

	private static nint Internal_Create(Keyframe[] keys) { }

	private static void Internal_Destroy(nint ptr) { }

	private bool Internal_Equals(nint other) { }

	public int MoveKey(int index, Keyframe key) { }

	private int MoveKey_Injected(int index, ref Keyframe key) { }

	public void set_keys(Keyframe[] value) { }

	public void set_postWrapMode(WrapMode value) { }

	public void set_preWrapMode(WrapMode value) { }

	private void SetKeys(Keyframe[] keys) { }

	public void SmoothTangents(int index, float weight) { }

}

