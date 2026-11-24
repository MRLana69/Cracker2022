//Type is in global namespace

public class CaptureInGame : AScreenCapture
{
	private sealed class <CaptureAllFrames>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CaptureInGame <>4__this; //Field offset: 0x10
		private int <frameCount>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 260
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <CaptureAllFrames>d__2(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private GameObject _coroutineObject; //Field offset: 0x20

	public CaptureInGame(string captureFolder, int width, int height, Camera camera) { }

	private IEnumerator CaptureAllFrames() { }

	public override void Cleanup() { }

}

