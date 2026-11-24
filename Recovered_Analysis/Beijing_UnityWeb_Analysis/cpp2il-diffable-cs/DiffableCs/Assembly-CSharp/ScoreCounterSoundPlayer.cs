//Type is in global namespace

public class ScoreCounterSoundPlayer : MonoBehaviour
{
	private sealed class <ScoreSoundTimer>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public ScoreCounterSoundPlayer <>4__this; //Field offset: 0x10

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 240
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ScoreSoundTimer>d__8(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public AudioClip scoreSound; //Field offset: 0xC
	public float volume; //Field offset: 0x10
	public float stepDelay; //Field offset: 0x14
	private float count; //Field offset: 0x18
	private AudioSource scoreSource; //Field offset: 0x1C
	private bool playScore; //Field offset: 0x20

	public ScoreCounterSoundPlayer() { }

	private void Awake() { }

	public void PlayCoinSound(float countFactor) { }

	private IEnumerator ScoreSoundTimer() { }

	public void StopScoreSound() { }

}

