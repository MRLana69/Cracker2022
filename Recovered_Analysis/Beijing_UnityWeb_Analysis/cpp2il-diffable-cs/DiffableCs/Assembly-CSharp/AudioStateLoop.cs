//Type is in global namespace

public class AudioStateLoop
{
	private sealed class <MusicFader>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public AudioStateLoop <>4__this; //Field offset: 0x10
		public float timePauseTime; //Field offset: 0x14
		public float timeFadeUp; //Field offset: 0x18
		private float <counter>5__2; //Field offset: 0x1C
		private float <startFade>5__3; //Field offset: 0x20
		private float <fadeSpeed>5__4; //Field offset: 0x24

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 537
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <MusicFader>d__54(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	private sealed class <ResumeSoundAfterFrames>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public int frames; //Field offset: 0x10
		public AudioStateLoop <>4__this; //Field offset: 0x14
		private int <index>5__2; //Field offset: 0x18

		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			 get { } //Length: 119
		}

		private object System.Collections.IEnumerator.Current
		{
			 get { } //Length: 6
		}

		public <ResumeSoundAfterFrames>d__45(int <>1__state) { }

		private bool MoveNext() { }

		private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		private object System.Collections.IEnumerator.get_Current() { }

		private void System.Collections.IEnumerator.Reset() { }

		private void System.IDisposable.Dispose() { }

	}

	public AudioSource musicPlayer; //Field offset: 0x10
	private float musicVolume; //Field offset: 0x14
	private bool isOtherAudioPlaying; //Field offset: 0x18
	public float menuMusicVolume; //Field offset: 0x1C
	public float ingameMusicVolume; //Field offset: 0x20
	public AudioClip jetpackLoop; //Field offset: 0x24
	public float jetpackVolume; //Field offset: 0x28
	public float jetpackMinPitch; //Field offset: 0x2C
	public float jetpackMaxPitch; //Field offset: 0x30
	public AudioClip magnetLoop; //Field offset: 0x34
	public float magnetVolume; //Field offset: 0x38
	public float magnetMinPitch; //Field offset: 0x3C
	public float magnetMaxPitch; //Field offset: 0x40
	public AudioClip mysteryBoxOpenSound; //Field offset: 0x44
	public float mysteryVolume; //Field offset: 0x48
	public AudioClip mysteryRewardShowSound; //Field offset: 0x4C
	public float mysteryRewardVolume; //Field offset: 0x50
	public AudioClip celebrationTapSound; //Field offset: 0x54
	public float celebrationTapVolume; //Field offset: 0x58
	public AudioClip unlockSound; //Field offset: 0x5C
	public float unlockSoundVolume; //Field offset: 0x60
	public AudioClip reviveSound; //Field offset: 0x64
	public float reviveVolume; //Field offset: 0x68
	public float revivePauseTime; //Field offset: 0x6C
	public float reviveFadeUpTime; //Field offset: 0x70
	private AudioSource jetpackSource; //Field offset: 0x74
	private AudioSource magnetSource; //Field offset: 0x78
	private AudioSource mysterySource; //Field offset: 0x7C
	private AudioSource mysteryRewardSource; //Field offset: 0x80
	private AudioSource celebrationTapSource; //Field offset: 0x84
	private AudioSource reviveSource; //Field offset: 0x88
	private AudioSource unlockSource; //Field offset: 0x8C
	private bool hasPlayedIntro; //Field offset: 0x90
	private bool _resumeJetpackOnUnpause; //Field offset: 0x91
	private bool _resumeCoinMagnetOnUnpause; //Field offset: 0x92
	public float fadeDownTime; //Field offset: 0x94
	public float pauseTime; //Field offset: 0x98
	public float fadeUpTime; //Field offset: 0x9C

	public AudioStateLoop() { }

	public void ChangeLoop(AudioState audioState) { }

	public void ForceStopMusic() { }

	private IEnumerator MusicFader(float timeFadeUp, float timePauseTime) { }

	public void OnApplicationPause(bool pause) { }

	private void OnMusicSettingChanged() { }

	private void OnPauseChange(bool isPaused) { }

	private void OnSfxSettingChanged() { }

	private void OnThemeChanged(Theme theme) { }

	public void PlayCelebrationOpenSound() { }

	public void PlayCelebrationTapSound() { }

	public void PlayLoop(AudioSource audioSource, float minPitch, float maxPitch) { }

	public void PlayLoop(AudioSource audioSource) { }

	public void PlayReviveSound() { }

	public void PlayRewardMysterySound() { }

	public void PlayUnlockSound() { }

	private IEnumerator ResumeSoundAfterFrames(int frames) { }

	private void SetGameSoundVolume() { }

	protected void Start() { }

	public void StopLoop(AudioSource audioSource) { }

	protected override void SubclassInitialize() { }

	private void UpdateMusicPlayer() { }

}

