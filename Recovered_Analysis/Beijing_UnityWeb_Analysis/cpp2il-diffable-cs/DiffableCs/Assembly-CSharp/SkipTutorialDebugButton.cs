//Type is in global namespace

public class SkipTutorialDebugButton : MonoBehaviour
{
	private sealed class <ResetTapsOnTimeOut>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SkipTutorialDebugButton <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 134
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ResetTapsOnTimeOut>d__4(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private const int NUMBER_OF_CLICKS_TO_OPEN = 2; //Field offset: 0x0
	private const int TIME_TO_DOUBLE_CLICK = 1; //Field offset: 0x0
	private int _taps; //Field offset: 0xC

	public SkipTutorialDebugButton() { }

	private void OnClick() { }

	private IEnumerator ResetTapsOnTimeOut() { }

}

