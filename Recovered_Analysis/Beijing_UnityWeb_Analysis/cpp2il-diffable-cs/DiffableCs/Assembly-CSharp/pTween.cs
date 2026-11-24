//Type is in global namespace

public class pTween
{
	private sealed class <RealtimeTo>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float duration; //Field offset: 0x10
		public Action<float> callback; //Field offset: 0x14
		public float startValue; //Field offset: 0x18
		public float endValue; //Field offset: 0x1C
		private float <end>5__2; //Field offset: 0x20
		private float <durationInv>5__3; //Field offset: 0x24
		private float <startMulDurationInv>5__4; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 293
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <RealtimeTo>d__1(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <To>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float duration; //Field offset: 0x10
		public Action<float> callback; //Field offset: 0x14
		public float startValue; //Field offset: 0x18
		public float endValue; //Field offset: 0x1C
		private float <end>5__2; //Field offset: 0x20
		private float <durationInv>5__3; //Field offset: 0x24
		private float <startMulDurationInv>5__4; //Field offset: 0x28

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 293
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <To>d__0(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}


	public pTween() { }

	public static IEnumerator RealtimeTo(float duration, float startValue, float endValue, Action<float> callback) { }

	public static IEnumerator To(float duration, float startValue, float endValue, Action<float> callback) { }

	public static IEnumerator To(float duration, Action<float> callback) { }

}

