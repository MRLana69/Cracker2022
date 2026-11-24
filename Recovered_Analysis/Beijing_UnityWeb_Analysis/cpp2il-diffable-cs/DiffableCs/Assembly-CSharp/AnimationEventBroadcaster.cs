//Type is in global namespace

public class AnimationEventBroadcaster : MonoBehaviour
{
	public delegate SendDoKeyframeAnimationDelegate
	{

		public SendDoKeyframeAnimationDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(int soundIndex, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(int soundIndex) { }

	}

	public delegate SendPlayKeyframeAnimationDelegate
	{

		public SendPlayKeyframeAnimationDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(int soundIndex, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(int soundIndex) { }

	}

	public delegate SendSetAnimationSpeedEventDelegate
	{

		public SendSetAnimationSpeedEventDelegate(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(AnimationEvent animEvent, AsyncCallback callback, object object) { }

		public virtual void EndInvoke(IAsyncResult result) { }

		public virtual void Invoke(AnimationEvent animEvent) { }

	}

	private SendDoKeyframeAnimationDelegate SendDoKeyframeAnimation; //Field offset: 0xC
	private SendPlayKeyframeAnimationDelegate SendPlayKeyframeAnimation; //Field offset: 0x10
	private SendSetAnimationSpeedEventDelegate SendSetAnimationSpeedEvent; //Field offset: 0x14

	public event SendDoKeyframeAnimationDelegate SendDoKeyframeAnimation
	{
		 add { } //Length: 576
		 remove { } //Length: 111
	}

	public event SendPlayKeyframeAnimationDelegate SendPlayKeyframeAnimation
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public event SendSetAnimationSpeedEventDelegate SendSetAnimationSpeedEvent
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public AnimationEventBroadcaster() { }

	public void add_SendDoKeyframeAnimation(SendDoKeyframeAnimationDelegate value) { }

	public void add_SendPlayKeyframeAnimation(SendPlayKeyframeAnimationDelegate value) { }

	public void add_SendSetAnimationSpeedEvent(SendSetAnimationSpeedEventDelegate value) { }

	private void DoKeyframeAnimation(int soundIndex) { }

	private void PlayKeyframeAnimation(int soundIndex) { }

	public void remove_SendDoKeyframeAnimation(SendDoKeyframeAnimationDelegate value) { }

	public void remove_SendPlayKeyframeAnimation(SendPlayKeyframeAnimationDelegate value) { }

	public void remove_SendSetAnimationSpeedEvent(SendSetAnimationSpeedEventDelegate value) { }

	private void SetAnimationSpeedEvent(AnimationEvent animEvent) { }

}

