namespace Kiloo.Common.Utility;

public class Wait
{
	public class Config
	{
		private sealed class <WaitCoroutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x8
			private object <>2__current; //Field offset: 0xC
			public Config <>4__this; //Field offset: 0x10
			private float <startTime>5__2; //Field offset: 0x14
			private float <currentTime>5__3; //Field offset: 0x18
			private double <pausedTimeTotal>5__4; //Field offset: 0x20
			private double <pausedTime>5__5; //Field offset: 0x28
			private float <pausedStartTime>5__6; //Field offset: 0x30

			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				 get { } //Length: 565
			}

			private object System.Collections.IEnumerator.Current
			{
				 get { } //Length: 6
			}

			public <WaitCoroutine>d__21(int <>1__state) { }

			private bool MoveNext() { }

			private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

			private object System.Collections.IEnumerator.get_Current() { }

			private void System.Collections.IEnumerator.Reset() { }

			private void System.IDisposable.Dispose() { }

		}

		public struct TimeConfig
		{
			private readonly Config _config; //Field offset: 0x0

			public TimeConfig(Config wait) { }

			public Config ScaledSeconds() { }

			public Config UnscaledSeconds() { }

		}

		private float _time; //Field offset: 0x8
		private TimeOption _timeOption; //Field offset: 0xC
		private Func<bool> _whileCondition; //Field offset: 0x10
		private Func<bool> _pauseWhileCondition; //Field offset: 0x14
		private Action _thenInvokeAction; //Field offset: 0x18
		private Action<Config> _thenInvokeActionWithConfig; //Field offset: 0x1C
		private bool <didTimeout>k__BackingField; //Field offset: 0x20
		private bool <isDone>k__BackingField; //Field offset: 0x21

		public bool didTimeout
		{
			 get { } //Length: 6
			private set { } //Length: 124
		}

		public bool isDone
		{
			 get { } //Length: 9
			private set { } //Length: 11
		}

		public Config() { }

		public TimeConfig For(float time) { }

		public bool get_didTimeout() { }

		public bool get_isDone() { }

		public Config PauseWhile(Func<bool> condition) { }

		private void set_didTimeout(bool value) { }

		private void set_isDone(bool value) { }

		public Coroutine StartCoroutine() { }

		public Coroutine StartCoroutineOn(MonoBehaviour proxy) { }

		public Config ThenInvoke(Action action) { }

		public Config ThenInvoke(Action<Config> action) { }

		private IEnumerator WaitCoroutine() { }

		public Config While(Func<bool> condition) { }

	}


	public Wait() { }

	public static TimeConfig For(float time) { }

	private static void Log(string msg) { }

	public static Config While(Func<bool> condition) { }

}

