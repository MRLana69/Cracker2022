//Type is in global namespace

public class DynamicBgMusic : MonoBehaviour
{
	private sealed class <LoopFader>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public DynamicBgMusic <>4__this; //Field offset: 0x10
		public int audioSourceID; //Field offset: 0x14
		private float <counter>5__2; //Field offset: 0x18
		private float <startFade>5__3; //Field offset: 0x1C
		private float <fadeSpeed>5__4; //Field offset: 0x20
		private float <targetVolume>5__5; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 861
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <LoopFader>d__15(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public AudioClip[] audioClips; //Field offset: 0xC
	public AudioClip masterClip; //Field offset: 0x10
	private AudioSource masterSource; //Field offset: 0x14
	private AudioSource[] audioSources; //Field offset: 0x18
	public float minFadeTime; //Field offset: 0x1C
	public float maxFadeTime; //Field offset: 0x20
	public float minPlayingTime; //Field offset: 0x24
	public float maxPlayingTime; //Field offset: 0x28
	public float minPauseTime; //Field offset: 0x2C
	public float maxPauseTime; //Field offset: 0x30
	public float minPlayingVolume; //Field offset: 0x34
	public float maxPlayingVolume; //Field offset: 0x38
	public float masterSourceVolume; //Field offset: 0x3C

	public DynamicBgMusic() { }

	private void Awake() { }

	private AudioClip FindNotYetPlayingLoop() { }

	private IEnumerator LoopFader(int audioSourceID) { }

}

