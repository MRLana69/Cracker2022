//Type is in global namespace

public class So : MonoBehaviour
{
	private sealed class <playSoundAsync>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public So <>4__this; //Field offset: 0x10
		public AudioClipInfo audioClip; //Field offset: 0x14

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 87
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <playSoundAsync>d__13(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public static So Instance; //Field offset: 0x0
	public int initialCapacity; //Field offset: 0xC
	public int maxCapacity; //Field offset: 0x10
	private List<Sound> _soundList; //Field offset: 0x14
	private Sound _bgSound; //Field offset: 0x18
	private bool _audioWasPlaying; //Field offset: 0x1C
	private float _audioTime; //Field offset: 0x20

	private static So() { }

	public So() { }

	private void Awake() { }

	public void beginPlaySound(AudioClipInfo audioClip) { }

	private void MuteAllSfx() { }

	private void OnApplicationPause(bool didPause) { }

	private void OnSfxSettingsChanged() { }

	public void playBGMusic(AudioClip audioClip, float volume, bool loop) { }

	public Sound playSound(AudioClipInfo audioClip, bool willLoop = false) { }

	public Sound playSound(AudioClipInfo audioClipInfo, float hardVolume, float hardPitch) { }

	public Sound playSound(AudioClipInfo audioClipInfo, float hardVolume, float hardPitch, bool willLoop = false) { }

	public Sound playSound(AudioClip audioClip, AudioRolloffMode rolloff, float volume, Vector3 position) { }

	public Sound playSound(AudioClip audioClip, AudioRolloffMode rolloff, float minVolume, float maxVolume, float minPitch, float maxPitch, Vector3 position, bool willLoop = false) { }

	private IEnumerator playSoundAsync(AudioClipInfo audioClip) { }

	public void removeSound(Sound s) { }

}

