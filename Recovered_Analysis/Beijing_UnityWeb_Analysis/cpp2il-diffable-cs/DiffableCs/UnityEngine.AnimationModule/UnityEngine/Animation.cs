namespace UnityEngine;

public sealed class Animation : Behaviour, IEnumerable
{
	private sealed class Enumerator : IEnumerator
	{
		private Animation m_Outer; //Field offset: 0x8
		private int m_CurrentIndex; //Field offset: 0xC

		public object Current
		{
			 get { } //Length: 49
		}

		internal Enumerator(Animation outer) { }

		public object get_Current() { }

		public bool MoveNext() { }

		public void Reset() { }

	}


	public AnimationClip clip
	{
		 get { } //Length: 101
	}

	public bool isPlaying
	{
		 get { } //Length: 49
	}

	public AnimationState Item
	{
		 get { } //Length: 52
	}

	public WrapMode wrapMode
	{
		 set { } //Length: 8
	}

	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	public void AddClip(AnimationClip clip, string newName) { }

	public void CrossFade(string animation) { }

	public void CrossFade(string animation, float fadeLength) { }

	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	public AnimationState CrossFadeQueued(string animation) { }

	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	public AnimationClip get_clip() { }

	public bool get_isPlaying() { }

	public AnimationState get_Item(string name) { }

	public AnimationClip GetClip(string name) { }

	public IEnumerator GetEnumerator() { }

	internal AnimationState GetState(string name) { }

	internal AnimationState GetStateAtIndex(int index) { }

	internal int GetStateCount() { }

	private static void INTERNAL_CALL_Rewind(Animation self) { }

	private static void INTERNAL_CALL_Sample(Animation self) { }

	private static void INTERNAL_CALL_Stop(Animation self) { }

	public bool IsPlaying(string name) { }

	public bool Play(PlayMode mode) { }

	public bool Play(string animation, PlayMode mode) { }

	public bool Play() { }

	public bool Play(string animation) { }

	private bool PlayDefaultAnimation(PlayMode mode) { }

	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	public AnimationState PlayQueued(string animation) { }

	public void RemoveClip(AnimationClip clip) { }

	public void RemoveClip(string clipName) { }

	private void RemoveClip2(string clipName) { }

	public void Rewind() { }

	public void Sample() { }

	public void set_wrapMode(WrapMode value) { }

	public void Stop() { }

}

