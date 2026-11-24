namespace Kiloo.Common.Utility;

public static class CoroutineUtil
{
	private sealed class <ExecuteActionNextFrame>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Action action; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 119
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ExecuteActionNextFrame>d__8(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <WaitForAllCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public IEnumerable<YieldInstruction> list; //Field offset: 0x10
		private IEnumerator<YieldInstruction> <>7__wrap1; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 404
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <WaitForAllCoroutine>d__6(int <>1__state) { }

		private void <>m__Finally1() { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <WaitForRealSeconds>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float timeToWait; //Field offset: 0x10
		private float <start>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 102
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <WaitForRealSeconds>d__7(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private static MonoBehaviour _coroutineRunner; //Field offset: 0x0

	public static IEnumerator ExecuteActionNextFrame(Action action) { }

	public static Coroutine StartCoroutine(IEnumerator coroutine) { }

	public static void StopCoroutine(IEnumerator coroutine) { }

	public static void StopCoroutine(Coroutine coroutine) { }

	public static Coroutine WaitForAll(IEnumerable<YieldInstruction> list, MonoBehaviour proxy = null) { }

	public static Coroutine WaitForAll(YieldInstruction[] list) { }

	private static IEnumerator WaitForAllCoroutine(IEnumerable<YieldInstruction> list) { }

	public static IEnumerator WaitForRealSeconds(float timeToWait) { }

}

