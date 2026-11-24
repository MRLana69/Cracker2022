//Type is in global namespace

public class ResumeButtonHelper : MonoBehaviour
{
	private sealed class <EnableButtonWhenReady>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public ResumeButtonHelper <>4__this; //Field offset: 0x10
		private float <startTime>5__2; //Field offset: 0x14
		private float <timeWaited>5__3; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 321
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <EnableButtonWhenReady>d__10(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const float MIN_WAIT_TIME = 1; //Field offset: 0x0
	private const float MAX_WAIT_TIME = 5; //Field offset: 0x0
	private UILabel label; //Field offset: 0xC
	private UIButtonOverlayOff _cachedOverlayHelper; //Field offset: 0x10
	private bool _buttonEnabled; //Field offset: 0x14

	public bool isButtonEnabled
	{
		 get { } //Length: 82
	}

	private UIButtonOverlayOff overlayHelper
	{
		 get { } //Length: 6
	}

	public ResumeButtonHelper() { }

	public void DisableButton() { }

	public void EnableButton() { }

	private IEnumerator EnableButtonWhenReady() { }

	public bool get_isButtonEnabled() { }

	private UIButtonOverlayOff get_overlayHelper() { }

	private void OnApplicationPause(bool pause) { }

}

