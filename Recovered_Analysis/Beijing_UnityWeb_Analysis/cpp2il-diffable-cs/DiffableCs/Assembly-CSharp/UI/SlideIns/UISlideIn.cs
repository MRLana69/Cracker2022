namespace UI.SlideIns;

public class UISlideIn : MonoBehaviour
{
	private sealed class <InvokeDidShowCallback>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float waitTime; //Field offset: 0x10
		public UISlideIn <>4__this; //Field offset: 0x14
		private float <startPoint>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 129
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <InvokeDidShowCallback>d__13(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <PreloadSlideIn>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UISlideIn <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 135
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <PreloadSlideIn>d__17(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private UIWidget _darkBackground; //Field offset: 0xC
	private Vector3 posOff; //Field offset: 0x10
	private Vector3 posOn; //Field offset: 0x1C
	private bool _triggerSlideOut; //Field offset: 0x28
	private float _slideOutTimer; //Field offset: 0x2C
	private bool _triggerReadyForNext; //Field offset: 0x30
	private float _readyForNextTimer; //Field offset: 0x34
	private Action onDidShowCallback; //Field offset: 0x38

	private event Action onDidShowCallback
	{
		 add { } //Length: 194
		 remove { } //Length: 111
	}

	public UISlideIn() { }

	private void add_onDidShowCallback(Action value) { }

	private IEnumerator InvokeDidShowCallback(float waitTime) { }

	public IEnumerator PreloadSlideIn() { }

	protected virtual void ReadyForNewMessage() { }

	private void remove_onDidShowCallback(Action value) { }

	public virtual void SetupSlideIn(SlideIn slideIn) { }

	protected void SlideIn(Action onDidShowCallback = null) { }

	protected virtual void SlideOut() { }

	protected void Start() { }

	private void Update() { }

}

