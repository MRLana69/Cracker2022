//Type is in global namespace

public class Sound
{
	private sealed class <play>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public Sound <>4__this; //Field offset: 0x10
		public Vector3 position; //Field offset: 0x14
		public AudioRolloffMode rolloff; //Field offset: 0x20
		public float minVolume; //Field offset: 0x24
		public float maxVolume; //Field offset: 0x28
		public float minPitch; //Field offset: 0x2C
		public float maxPitch; //Field offset: 0x30
		public bool willLoop; //Field offset: 0x34
		private bool <hasGameObject>5__2; //Field offset: 0x35
		private bool <hasAudioSource>5__3; //Field offset: 0x36

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 602
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <play>d__19(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private So _manager; //Field offset: 0x8
	private GameObject gameObject; //Field offset: 0xC
	private bool _isAvailable; //Field offset: 0x10
	public AudioSource audioSource; //Field offset: 0x14
	public bool destroyAfterPlay; //Field offset: 0x18
	private string _name; //Field offset: 0x1C

	public bool IsAvailable
	{
		 get { } //Length: 66
	}

	public bool loop
	{
		 set { } //Length: 55
	}

	public string name
	{
		 get { } //Length: 9
	}

	public Sound(So manager) { }

	private void <fadeOutAndStop>b__17_0() { }

	public void destroySelf() { }

	public IEnumerator fadeOutAndStop(float duration) { }

	public bool get_IsAvailable() { }

	public string get_name() { }

	public void Pause() { }

	public IEnumerator play(AudioRolloffMode rolloff, float minVolume, float maxVolume, float minPitch, float maxPitch, Vector3 position, bool willLoop) { }

	public IEnumerator playAudioClip(AudioClip audioClip, AudioRolloffMode rolloff, float minVolume, float maxVolume, float minPitch, float maxPitch, Vector3 position, bool willLoop = false) { }

	public void Rewind() { }

	public void set_loop(bool value) { }

	public void Stop() { }

}

