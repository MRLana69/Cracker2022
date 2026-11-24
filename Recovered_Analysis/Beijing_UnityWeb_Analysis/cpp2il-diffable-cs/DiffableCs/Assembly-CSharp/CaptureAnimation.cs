//Type is in global namespace

public class CaptureAnimation : AScreenCapture
{
	private sealed class <CaptureAnimationToEnd>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CaptureAnimation <>4__this; //Field offset: 0x10
		private int <frameCount>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 315
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CaptureAnimationToEnd>d__6(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private Animation _animation; //Field offset: 0x20
	private string _animationName; //Field offset: 0x24
	private Action _onDone; //Field offset: 0x28
	private GameObject _coroutineObject; //Field offset: 0x2C

	public CaptureAnimation(Animation animation, string captureFolder, string animationName, int width, int height, int fps, Camera camera, Action onDone) { }

	public CaptureAnimation(Animation animation, string captureFolder, string animationName, int width, int height, int fps, Camera[] camera, Action onDone) { }

	private IEnumerator CaptureAnimationToEnd() { }

	public override void Cleanup() { }

}

