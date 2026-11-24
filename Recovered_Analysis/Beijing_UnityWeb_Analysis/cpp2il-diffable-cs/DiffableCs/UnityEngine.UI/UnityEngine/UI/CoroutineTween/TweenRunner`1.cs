namespace UnityEngine.UI.CoroutineTween;

internal class TweenRunner`1
{
	private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public T tweenInfo; //Field offset: 0x0
		private float <elapsedTime>5__2; //Field offset: 0x0

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 320
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Start>d__2(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	protected MonoBehaviour m_CoroutineContainer; //Field offset: 0x0
	protected IEnumerator m_Tween; //Field offset: 0x0

	public TweenRunner`1() { }

	public void Init(MonoBehaviour coroutineContainer) { }

	private static IEnumerator Start(T tweenInfo) { }

	public void StartTween(T info) { }

	public void StopTween() { }

}

