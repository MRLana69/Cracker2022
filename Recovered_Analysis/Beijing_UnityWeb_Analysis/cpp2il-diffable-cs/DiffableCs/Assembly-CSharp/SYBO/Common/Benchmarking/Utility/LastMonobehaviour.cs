namespace SYBO.Common.Benchmarking.Utility;

public class LastMonobehaviour : SubscribableMonobehaviour
{
	private sealed class <FixedUpdateCoroutine>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public LastMonobehaviour <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 96
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <FixedUpdateCoroutine>d__3(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public Action OnYieldFixedUpdate; //Field offset: 0x18
	private YieldInstruction _fixedUpdateYield; //Field offset: 0x1C

	public LastMonobehaviour() { }

	private void Awake() { }

	private IEnumerator FixedUpdateCoroutine() { }

}

