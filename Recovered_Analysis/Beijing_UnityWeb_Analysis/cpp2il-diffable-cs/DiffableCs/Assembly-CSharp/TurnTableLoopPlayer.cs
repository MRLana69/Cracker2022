//Type is in global namespace

public class TurnTableLoopPlayer : MonoBehaviour
{
	private sealed class <StartLooper>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TurnTableLoopPlayer <>4__this; //Field offset: 0x10
		public AudioLoopInfo audioLoopInfo; //Field offset: 0x14
		private float <counter>5__2; //Field offset: 0x18
		private float <startFadeVol>5__3; //Field offset: 0x1C
		private float <startFadePitch>5__4; //Field offset: 0x20
		private float <fadeSpeed>5__5; //Field offset: 0x24
		private float <targetVol>5__6; //Field offset: 0x28
		private float <targetPitch>5__7; //Field offset: 0x2C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 523
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StartLooper>d__8(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <StopLooper>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public TurnTableLoopPlayer <>4__this; //Field offset: 0x10
		public AudioLoopInfo audioLoopInfo; //Field offset: 0x14
		private float <counter>5__2; //Field offset: 0x18
		private float <startFadeVol>5__3; //Field offset: 0x1C
		private float <startFadePitch>5__4; //Field offset: 0x20
		private float <fadeSpeed>5__5; //Field offset: 0x24
		private float <targetVol>5__6; //Field offset: 0x28
		private float <targetPitch>5__7; //Field offset: 0x2C

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 451
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <StopLooper>d__9(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private AudioSource audioSource; //Field offset: 0xC
	private AudioSource rewardSource; //Field offset: 0x10
	public AudioLoopInfo audioLoopInfo; //Field offset: 0x14
	public AudioClipInfo audioRewardInfo; //Field offset: 0x18
	private Coroutine startRoutine; //Field offset: 0x1C

	public TurnTableLoopPlayer() { }

	private void Awake() { }

	public void StartLoop() { }

	private IEnumerator StartLooper(AudioLoopInfo audioLoopInfo) { }

	public void StopLoop() { }

	private IEnumerator StopLooper(AudioLoopInfo audioLoopInfo) { }

}

