using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using SYBO.Components.Utilities;
using SYBO.Subway;
using UnityEngine;

public class AudioStateLoop : Singleton<AudioStateLoop>
{
	private sealed class _003CResumeSoundAfterFrames_003Ed__46(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public int frames;

		public AudioStateLoop _003C_003E4__this;

		private int _003Cindex_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0091;
				}
				_003C_003E1__state = -1;
				num = _003Cindex_003E5__2;
			}
			else
			{
				_003Cindex_003E5__2 = 0;
				_003C_003E1__state = -1;
				num = 0;
			}
			if (num >= frames)
			{
				_003C_003E4__this.SetGameSoundVolume();
				goto IL_0091;
			}
			_003C_003E2__current = null;
			int num2 = num + 1;
			_003Cindex_003E5__2 = num2;
			_003C_003E1__state = 1;
			return true;
			IL_0091:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private sealed class _003CMusicFader_003Ed__52(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioStateLoop _003C_003E4__this;

		public float timePauseTime;

		public float timeFadeUp;

		private float _003Ccounter2_003E5__2;

		private float _003CstartFade_003E5__3;

		private float _003CfadeSpeed2_003E5__4;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			AudioStateLoop audioStateLoop = _003C_003E4__this;
			float num = default;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state != 2)
					{
						if (_003C_003E1__state == 3)
						{
							_003C_003E1__state = -1;
							bool flag = _003Ccounter2_003E5__2 < 1f;
							num = _003Ccounter2_003E5__2;
							if (flag)
							{
								goto IL_01b3;
							}
							audioStateLoop.musicVolume = audioStateLoop.menuMusicVolume;
							audioStateLoop.UpdateMusicPlayer();
						}
						return false;
					}
					_003Ccounter2_003E5__2 = 0f;
					_003C_003E1__state = -1;
					float num2 = 1f / timeFadeUp;
					_003CfadeSpeed2_003E5__4 = num2;
					goto IL_01b3;
				}
				_003C_003E1__state = -1;
				bool flag2 = _003Ccounter2_003E5__2 < 1f;
				num = _003Ccounter2_003E5__2;
				if (!flag2)
				{
					audioStateLoop.musicVolume = 0f;
					audioStateLoop.UpdateMusicPlayer();
					_ = timePauseTime;
					object obj = default;
					_003C_003E2__current = obj;
					_003C_003E1__state = 2;
					return true;
				}
			}
			else
			{
				_003Ccounter2_003E5__2 = 0f;
				_003C_003E1__state = -1;
				_003CstartFade_003E5__3 = audioStateLoop.musicVolume;
				float num3 = 1f / audioStateLoop.fadeDownTime;
				_003CfadeSpeed2_003E5__4 = num3;
			}
			float num4 = 0f - _003CstartFade_003E5__3;
			float num5 = Math.Min(num, 1f);
			bool flag3 = num < 0f;
			float num6 = 0f;
			if (!flag3)
			{
				num6 = num5;
			}
			float num7 = num4 * num6;
			float musicVolume = _003CstartFade_003E5__3 + num7;
			audioStateLoop.musicVolume = musicVolume;
			audioStateLoop.UpdateMusicPlayer();
			float deltaTime = Time.deltaTime;
			float num8 = deltaTime * _003CfadeSpeed2_003E5__4;
			float num9 = _003Ccounter2_003E5__2 + num8;
			_003C_003E2__current = null;
			_003Ccounter2_003E5__2 = num9;
			_003C_003E1__state = 1;
			return true;
			IL_01b3:
			float num10 = audioStateLoop.menuMusicVolume - 0f;
			float num11 = Math.Min(num, 1f);
			bool flag4 = num < 0f;
			float num12 = 0f;
			if (!flag4)
			{
				num12 = num11;
			}
			float num13 = num10 * num12;
			float musicVolume2 = num13 + 0f;
			audioStateLoop.musicVolume = musicVolume2;
			audioStateLoop.UpdateMusicPlayer();
			float deltaTime2 = Time.deltaTime;
			float num14 = deltaTime2 * _003CfadeSpeed2_003E5__4;
			float num15 = _003Ccounter2_003E5__2 + num14;
			_003C_003E2__current = null;
			_003Ccounter2_003E5__2 = num15;
			_003C_003E1__state = 3;
			return true;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	public AudioSource musicPlayer;

	private float musicVolume;

	private bool isOtherAudioPlaying;

	public float menuMusicVolume = 0.3f;

	public float ingameMusicVolume;

	public AudioClip jetpackLoop;

	public float jetpackVolume = 0.4f;

	public float jetpackMinPitch;

	public float jetpackMaxPitch = 1.1f;

	public AudioClip magnetLoop;

	public float magnetVolume = 0.4f;

	public float magnetMinPitch;

	public float magnetMaxPitch = 1.1f;

	public AudioClip mysteryBoxOpenSound;

	public float mysteryVolume = 1f;

	public AudioClip mysteryRewardShowSound;

	public float mysteryRewardVolume = 1f;

	public AudioClip celebrationTapSound;

	public float celebrationTapVolume = 1f;

	public AudioClip unlockSound;

	public float unlockSoundVolume = 1f;

	public AudioClip reviveSound;

	public float reviveVolume = 1f;

	public float revivePauseTime;

	public float reviveFadeUpTime = 2f;

	private AudioSource jetpackSource;

	private AudioSource magnetSource;

	private AudioSource mysterySource;

	private AudioSource mysteryRewardSource;

	private AudioSource celebrationTapSource;

	private AudioSource reviveSource;

	private AudioSource unlockSource;

	private bool hasPlayedIntro;

	private bool _resumeJetpackOnUnpause;

	private bool _resumeCoinMagnetOnUnpause;

	public float fadeDownTime = 0.5f;

	public float pauseTime;

	public float fadeUpTime = 4f;

	protected override void Awake()
	{
		base.Awake();
		GameObject gameObject = base.gameObject;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		jetpackSource = audioSource;
		jetpackSource.clip = jetpackLoop;
		jetpackSource.volume = jetpackVolume;
		jetpackSource.loop = true;
		jetpackSource.playOnAwake = false;
		GameObject gameObject2 = base.gameObject;
		AudioSource audioSource2 = gameObject2.AddComponent<AudioSource>();
		magnetSource = audioSource2;
		magnetSource.clip = magnetLoop;
		magnetSource.volume = magnetVolume;
		magnetSource.loop = true;
		magnetSource.playOnAwake = false;
		GameObject gameObject3 = base.gameObject;
		AudioSource audioSource3 = gameObject3.AddComponent<AudioSource>();
		mysterySource = audioSource3;
		mysterySource.clip = mysteryBoxOpenSound;
		mysterySource.volume = mysteryVolume;
		mysterySource.playOnAwake = false;
		GameObject gameObject4 = base.gameObject;
		AudioSource audioSource4 = gameObject4.AddComponent<AudioSource>();
		celebrationTapSource = audioSource4;
		celebrationTapSource.clip = celebrationTapSound;
		celebrationTapSource.volume = celebrationTapVolume;
		celebrationTapSource.playOnAwake = false;
		GameObject gameObject5 = base.gameObject;
		AudioSource audioSource5 = gameObject5.AddComponent<AudioSource>();
		mysteryRewardSource = audioSource5;
		mysteryRewardSource.clip = mysteryRewardShowSound;
		mysteryRewardSource.volume = mysteryRewardVolume;
		mysteryRewardSource.playOnAwake = false;
		GameObject gameObject6 = base.gameObject;
		AudioSource audioSource6 = gameObject6.AddComponent<AudioSource>();
		unlockSource = audioSource6;
		unlockSource.clip = unlockSound;
		unlockSource.volume = unlockSoundVolume;
		unlockSource.playOnAwake = false;
		GameObject gameObject7 = base.gameObject;
		AudioSource audioSource7 = gameObject7.AddComponent<AudioSource>();
		reviveSource = audioSource7;
		reviveSource.clip = reviveSound;
		reviveSource.volume = reviveVolume;
		reviveSource.playOnAwake = false;
		musicVolume = ingameMusicVolume;
		UpdateMusicPlayer();
		SetGameSoundVolume();
		musicPlayer.bypassEffects = true;
		Game instance = Game.Instance;
		throw new ArgumentException();
	}

	protected void Start()
	{
		OnMusicSettingChanged();
		OnSfxSettingChanged();
	}

	private void OnPauseChange(bool isPaused)
	{
		if (isPaused)
		{
			if (jetpackSource.isPlaying)
			{
				_resumeJetpackOnUnpause = true;
				jetpackSource.Pause();
			}
			if (magnetSource.isPlaying)
			{
				_resumeCoinMagnetOnUnpause = true;
				magnetSource.Pause();
			}
			return;
		}
		MissionsManager instance = MissionsManager.Instance;
		if (instance._currentRunProgress != null)
		{
			if (~(_resumeJetpackOnUnpause ? 1u : 0u) == 0)
			{
				jetpackSource.UnPause();
			}
			if (~(_resumeCoinMagnetOnUnpause ? 1u : 0u) == 0)
			{
				magnetSource.UnPause();
			}
		}
		_resumeJetpackOnUnpause = false;
	}

	private void OnMusicSettingChanged()
	{
		if (Settings.optionMusic)
		{
			musicPlayer.Play();
		}
		else
		{
			musicPlayer.Pause();
		}
	}

	private void OnSfxSettingChanged()
	{
		if (Settings.optionSfx)
		{
			jetpackSource.volume = jetpackVolume;
			magnetSource.volume = magnetVolume;
		}
		else
		{
			jetpackSource.volume = 0f;
			magnetSource.volume = 0f;
		}
	}

	private void UpdateMusicPlayer()
	{
		musicPlayer.volume = musicVolume;
	}

	private void SetGameSoundVolume()
	{
		if (!Settings.anySoundEnabled)
		{
			return;
		}
		bool flag2;
		bool anotherSoundIsPlayingOnDevice;
		if (isOtherAudioPlaying = DeviceUtility.GetIOSOtherAudioPlaying())
		{
			Settings.DisableAllSoundOptions();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [5319D9]");
			bool flag = (nint)0 == 0;
			flag2 = true;
			if (flag)
			{
				goto IL_00b7;
			}
			anotherSoundIsPlayingOnDevice = true;
		}
		else
		{
			flag2 = false;
			anotherSoundIsPlayingOnDevice = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [5319D9]");
			if ((nint)0 == 0)
			{
				goto IL_00b7;
			}
		}
		goto IL_00d5;
		IL_00b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_codegen_initialize_runtime_metadata\"");
		_ = 1;
		anotherSoundIsPlayingOnDevice = flag2;
		goto IL_00d5;
		IL_00d5:
		Settings._anotherSoundIsPlayingOnDevice = anotherSoundIsPlayingOnDevice;
	}

	public void OnApplicationPause(bool pause)
	{
		if (!pause)
		{
			IEnumerator routine = ResumeSoundAfterFrames(1);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator ResumeSoundAfterFrames(int frames)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void PlayCelebrationOpenSound()
	{
		if (Settings.optionSfx)
		{
			mysterySource.Play();
			IEnumerator routine = MusicFader(fadeUpTime, pauseTime);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	public void PlayRewardMysterySound()
	{
		if (Settings.optionSfx)
		{
			mysteryRewardSource.Play();
			IEnumerator routine = MusicFader(fadeUpTime, pauseTime);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	public void PlayCelebrationTapSound()
	{
		if (Settings.optionSfx)
		{
			celebrationTapSource.Play();
			IEnumerator routine = MusicFader(fadeUpTime, pauseTime);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	public void PlayUnlockSound()
	{
		if (Settings.optionSfx)
		{
			unlockSource.Play();
			IEnumerator routine = MusicFader(fadeUpTime, pauseTime);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	public void PlayReviveSound()
	{
		if (Settings.optionSfx)
		{
			reviveSource.Play();
			IEnumerator routine = MusicFader(reviveFadeUpTime, revivePauseTime);
			Coroutine coroutine = StartCoroutine(routine);
		}
	}

	private IEnumerator MusicFader(float timeFadeUp, float timePauseTime)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void ChangeLoop(AudioState audioState)
	{
		switch (audioState)
		{
		case AudioState.Menu:
			if (~(hasPlayedIntro ? 1u : 0u) == 0)
			{
				musicPlayer.bypassEffects = false;
				musicVolume = menuMusicVolume;
				UpdateMusicPlayer();
			}
			break;
		case AudioState.Ingame:
			if (~(hasPlayedIntro ? 1u : 0u) == 0)
			{
				musicPlayer.timeSamples = 0;
			}
			else
			{
				hasPlayedIntro = true;
			}
			musicPlayer.bypassEffects = true;
			musicVolume = ingameMusicVolume;
			UpdateMusicPlayer();
			break;
		case AudioState.Jetpack:
			PlayLoop(jetpackSource, jetpackMaxPitch, jetpackMaxPitch);
			break;
		case AudioState.JetpackStop:
			StopLoop(jetpackSource);
			break;
		case AudioState.Magnet:
			PlayLoop(magnetSource, magnetMinPitch, magnetMaxPitch);
			break;
		case AudioState.MagnetStop:
			StopLoop(magnetSource);
			break;
		}
	}

	public void PlayLoop(AudioSource audioSource)
	{
		float pitch = UnityEngine.Random.Range(0.8f, 1.1f);
		audioSource.pitch = pitch;
		audioSource.Play();
	}

	public void PlayLoop(AudioSource audioSource, float minPitch, float maxPitch)
	{
		float pitch = UnityEngine.Random.Range(minPitch, maxPitch);
		audioSource.pitch = pitch;
		audioSource.Play();
	}

	public void StopLoop(AudioSource audioSource)
	{
		audioSource.Stop();
	}
}
