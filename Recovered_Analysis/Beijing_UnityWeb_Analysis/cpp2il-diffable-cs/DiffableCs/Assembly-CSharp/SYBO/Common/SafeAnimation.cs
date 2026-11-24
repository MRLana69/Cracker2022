namespace SYBO.Common;

public class SafeAnimation
{
	public class SafeAnimationEventEventArgs : EventArgs
	{
		private string _message; //Field offset: 0x8

		public string Message
		{
			 get { } //Length: 109
		}

		public SafeAnimationEventEventArgs(string message) { }

		public string get_Message() { }

	}

	private bool _loggingEnabled; //Field offset: 0x8
	private EventHandler<SafeAnimationEventEventArgs> OnSafeAnimationEvent; //Field offset: 0xC
	private Animation _animation; //Field offset: 0x10

	public event EventHandler<SafeAnimationEventEventArgs> OnSafeAnimationEvent
	{
		 add { } //Length: 199
		 remove { } //Length: 111
	}

	public Animation Animation
	{
		 get { } //Length: 14
		 set { } //Length: 111
	}

	public SafeAnimation(Animation animation, bool loggingEnabled) { }

	public void add_OnSafeAnimationEvent(EventHandler<SafeAnimationEventEventArgs> value) { }

	public void AddClip(AnimationClip animationClip, string newName) { }

	public void CrossFade(string animationName, float fadeLength) { }

	public void CrossFade(string animationName) { }

	public void CrossFadeQueued(string animationName, float fadeLength) { }

	public void CrossFadeQueued(string animationName) { }

	public void DebugLog(string methodName, object message = null) { }

	public Animation get_Animation() { }

	public AnimationClip GetAnimationClip(string animationClipName) { }

	public AnimationState GetAnimationState(string animationStateName) { }

	public bool HasAnimation() { }

	public bool HasAnimationClip(string animationClipName) { }

	public bool HasAnimationState(string animationStateName) { }

	public bool IsPlaying(string animationName) { }

	public void Play(string animationName) { }

	public void Play() { }

	public void PlayQueued(string animationName) { }

	private void RaiseOnSafeAnimationEvent(string methodName, object message = null) { }

	public void remove_OnSafeAnimationEvent(EventHandler<SafeAnimationEventEventArgs> value) { }

	public void set_Animation(Animation value) { }

	public void SetEnabled(string animationName, bool isEnabled) { }

	public void SetLocalRotation(Quaternion rotation) { }

	public void SetRotation(Quaternion rotation) { }

	public void SetSpeed(AnimationState animationState, float speed) { }

	public void SetSpeed(string animationClipName, float speed) { }

	public void Stop() { }

	public void TryAddAnimationEvent(Animation animationInstance, string animationName, AnimationEvent animationEvent) { }

}

