namespace UI.Generic;

public class TimeSpinner : MonoBehaviour
{
	private sealed class <AdvanceToTarget>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TimeSpinner <>4__this; //Field offset: 0x10
		public float target; //Field offset: 0x14
		public float duration; //Field offset: 0x18
		private float <currentDuration>5__2; //Field offset: 0x1C
		private float <startFillAmount>5__3; //Field offset: 0x20

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 345
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <AdvanceToTarget>d__11(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <Animate>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TimeSpinner <>4__this; //Field offset: 0x10
		private float <animationDuration>5__2; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 848
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <Animate>d__10(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private enum SpinState
	{
		Zero = 0,
		Three = 1,
		Six = 2,
		Nine = 3,
		Twelve = 4,
		Fifteen = 5,
		Eighteen = 6,
		TwentyOne = 7,
	}

	private bool _animate; //Field offset: 0xC
	private UISprite _sprite; //Field offset: 0x10
	private Coroutine _cachedCoroutine; //Field offset: 0x14
	private bool _coroutineRunning; //Field offset: 0x18
	private SpinState _currentState; //Field offset: 0x1C

	public TimeSpinner() { }

	private IEnumerator AdvanceToTarget(float target, float duration) { }

	public void Animate(bool animateNow) { }

	private IEnumerator Animate() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnEnable() { }

}

