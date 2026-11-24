//Type is in global namespace

public class UIPanelStaticDelayer : MonoBehaviour
{
	private sealed class <SetStaticDelayed>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public UIPanel panel; //Field offset: 0x10
		public int delayFrames; //Field offset: 0x14
		private int <num>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 126
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <SetStaticDelayed>d__7(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private bool inited; //Field offset: 0xC
	private int framesToWait; //Field offset: 0x10
	private bool refreshOnEnable; //Field offset: 0x14
	private UIPanel _panel; //Field offset: 0x18

	public UIPanelStaticDelayer() { }

	private void Awake() { }

	private void OnEnable() { }

	private void OrderStaticDelay() { }

	public IEnumerator SetStaticDelayed(int delayFrames, UIPanel panel) { }

}

