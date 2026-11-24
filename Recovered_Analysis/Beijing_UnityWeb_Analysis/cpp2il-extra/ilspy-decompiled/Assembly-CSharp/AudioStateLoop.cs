using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Plugins.DeviceUtility;
using Missions;
using SYBO.Components.Utilities;
using SYBO.Subway;
using SYBO.Subway.StateSystem;
using SYBO.Subway.Themes;
using SYBO.Subway.Utilities;
using UnityEngine;
using UnityEngine.Experimental.Audio;
using UnityEngine.UI;

public class AudioStateLoop : SingletonMonoBehaviour<AudioStateLoop>
{
	private sealed class _003CResumeSoundAfterFrames_003Ed__45(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public int frames;

		public AudioStateLoop _003C_003E4__this;

		private int _003Cindex_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c8: Expected Obj, but got Unknown
				//IL_00d1: Expected Obj, but got I4
				//IL_00e5: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003Cindex_003E5__2 = 0;
				}
				if (_003Cindex_003E5__2 < frames)
				{
					int num = _003Cindex_003E5__2 + 1;
					_003Cindex_003E5__2 = num;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				_003C_003E4__this.PlayCelebrationOpenSound();
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CMusicFader_003Ed__54(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioStateLoop _003C_003E4__this;

		public float timePauseTime;

		public float timeFadeUp;

		private float _003Ccounter_003E5__2;

		private float _003CstartFade_003E5__3;

		private float _003CfadeSpeed_003E5__4;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_01ad: Expected I, but got Obj
				//IL_01c3: Expected Obj, but got I
				//IL_025f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0264: Expected Obj, but got Unknown
				//IL_026d: Expected Obj, but got I4
				//IL_0281: Expected Obj, but got I4
				//IL_01ee: Expected I, but got Obj
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_017e: Expected Obj, but got Unknown
				//IL_019a: Expected Obj, but got I4
				//IL_02ee: Expected I, but got Obj
				//IL_0304: Expected Obj, but got I
				//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a5: Expected Obj, but got Unknown
				//IL_03ae: Expected Obj, but got I4
				//IL_03c2: Expected Obj, but got I4
				//IL_032f: Expected I, but got Obj
				AudioStateLoop audioStateLoop = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state != 3)
							{
								return null;
							}
							_003C_003E1__state = -1;
						}
						else
						{
							_003C_003E1__state = -1;
							_003Ccounter_003E5__2 = 0f;
							float num = 1f / timeFadeUp;
							_003CfadeSpeed_003E5__4 = num;
						}
						if (!(_003Ccounter_003E5__2 < 1f))
						{
							audioStateLoop.musicVolume = audioStateLoop.menuMusicVolume;
							audioStateLoop.SetGameSoundVolume();
							return null;
						}
						nint num2 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v61 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num3 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v72 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float musicVolume = Mathf.LerpUnclamped(0f, audioStateLoop.menuMusicVolume, _003Ccounter_003E5__2);
						audioStateLoop.musicVolume = musicVolume;
						audioStateLoop.SetGameSoundVolume();
						float unscaledTime = Time.unscaledTime;
						float num4 = unscaledTime * _003CfadeSpeed_003E5__4;
						float num5 = _003Ccounter_003E5__2 + num4;
						_003Ccounter_003E5__2 = num5;
						object obj2 = this + 12;
						obj2 = 0;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_003Ccounter_003E5__2 = 0f;
					_003CstartFade_003E5__3 = audioStateLoop.musicVolume;
					float num6 = 1f / audioStateLoop.fadeDownTime;
					_003CfadeSpeed_003E5__4 = num6;
				}
				if (!(_003Ccounter_003E5__2 < 1f))
				{
					audioStateLoop.musicVolume = 0f;
					audioStateLoop.SetGameSoundVolume();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					_ = timePauseTime;
					object obj3 = this + 12;
					object obj4 = default;
					obj3 = obj4;
					_003C_003E1__state = 2;
					return 1;
				}
				nint num7 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v20 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num8 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v31 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float musicVolume2 = Mathf.LerpUnclamped(_003CstartFade_003E5__3, 0f, _003Ccounter_003E5__2);
				audioStateLoop.musicVolume = musicVolume2;
				audioStateLoop.SetGameSoundVolume();
				float unscaledTime2 = Time.unscaledTime;
				float num9 = unscaledTime2 * _003CfadeSpeed_003E5__4;
				float num10 = _003Ccounter_003E5__2 + num9;
				_003Ccounter_003E5__2 = num10;
				object obj6 = this + 12;
				obj6 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public AudioSource musicPlayer;

	private float musicVolume;

	private bool isOtherAudioPlaying;

	public float menuMusicVolume;

	public float ingameMusicVolume;

	public AudioClip jetpackLoop;

	public float jetpackVolume;

	public float jetpackMinPitch;

	public float jetpackMaxPitch;

	public AudioClip magnetLoop;

	public float magnetVolume;

	public float magnetMinPitch;

	public float magnetMaxPitch;

	public AudioClip mysteryBoxOpenSound;

	public float mysteryVolume;

	public AudioClip mysteryRewardShowSound;

	public float mysteryRewardVolume;

	public AudioClip celebrationTapSound;

	public float celebrationTapVolume;

	public AudioClip unlockSound;

	public float unlockSoundVolume;

	public AudioClip reviveSound;

	public float reviveVolume;

	public float revivePauseTime;

	public float reviveFadeUpTime;

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

	public float fadeDownTime;

	public float pauseTime;

	public float fadeUpTime;

	protected override void SubclassInitialize()
	{
		//IL_0011: Expected Obj, but got F4
		//IL_001c: Expected I4, but got F4
		//IL_0027: Expected Obj, but got F4
		//IL_0053: Expected Obj, but got F4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0072: Expected Obj, but got F4
		//IL_007d: Expected Obj, but got I4
		_ = 0.4f;
		musicPlayer = (AudioSource)3f;
		isOtherAudioPlaying = false;
		jetpackLoop = (AudioClip)0.8f;
		jetpackVolume = 1.1f;
		jetpackMinPitch = 0.5f;
		jetpackMaxPitch = 0.7f;
		magnetLoop = (AudioClip)0.4f;
		magnetVolume = 3f;
		object obj = this - -64;
		obj = 0.5f;
		mysteryBoxOpenSound = (AudioClip)1;
	}

	protected unsafe void Start()
	{
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected Obj, but got Unknown
		//IL_0515: Expected I4, but got Obj
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_007b: Expected I4, but got Obj
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected Obj, but got Unknown
		//IL_00f6: Expected I4, but got Obj
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected Obj, but got Unknown
		//IL_0161: Expected I4, but got Obj
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01c7: Expected I4, but got Obj
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected Obj, but got Unknown
		//IL_0232: Expected I4, but got Obj
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected Obj, but got Unknown
		//IL_0298: Expected I4, but got Obj
		//IL_02fe: Expected I, but got Obj
		//IL_0314: Expected Obj, but got I
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected Obj, but got Unknown
		//IL_055b: Expected Obj, but got I4
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03cb: Expected I, but got Obj
		//IL_03e1: Expected Obj, but got I
		//IL_033f: Expected I, but got Obj
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected Obj, but got Unknown
		//IL_0459: Expected I, but got Obj
		//IL_046f: Expected Obj, but got I
		//IL_040c: Expected I, but got Obj
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected Obj, but got Unknown
		//IL_049a: Expected I, but got Obj
		object obj = this + 116;
		string text = tag;
		AudioSource audioSource = ((GameObject)(object)text).AddComponent<AudioSource>();
		obj = audioSource;
		jetpackSource.loop = (byte)(int)jetpackLoop != 0;
		jetpackSource.pitch = jetpackVolume;
		jetpackSource.playOnAwake = true;
		jetpackSource.bypassEffects = false;
		object obj2 = this + 120;
		string text2 = tag;
		AudioSource audioSource2 = ((GameObject)(object)text2).AddComponent<AudioSource>();
		obj2 = audioSource2;
		magnetSource.loop = (byte)(int)magnetLoop != 0;
		magnetSource.pitch = magnetVolume;
		magnetSource.playOnAwake = true;
		magnetSource.bypassEffects = false;
		object obj3 = this + 124;
		string text3 = tag;
		AudioSource audioSource3 = ((GameObject)(object)text3).AddComponent<AudioSource>();
		obj3 = audioSource3;
		mysterySource.loop = (byte)(int)mysteryBoxOpenSound != 0;
		mysterySource.pitch = mysteryVolume;
		mysterySource.bypassEffects = false;
		object obj4 = this + 132;
		string text4 = tag;
		AudioSource audioSource4 = ((GameObject)(object)text4).AddComponent<AudioSource>();
		obj4 = audioSource4;
		celebrationTapSource.loop = (byte)(int)celebrationTapSound != 0;
		celebrationTapSource.pitch = celebrationTapVolume;
		celebrationTapSource.bypassEffects = false;
		object obj5 = this + 128;
		string text5 = tag;
		AudioSource audioSource5 = ((GameObject)(object)text5).AddComponent<AudioSource>();
		obj5 = audioSource5;
		mysteryRewardSource.loop = (byte)(int)mysteryRewardShowSound != 0;
		mysteryRewardSource.pitch = mysteryRewardVolume;
		mysteryRewardSource.bypassEffects = false;
		object obj6 = this + 140;
		string text6 = tag;
		AudioSource audioSource6 = ((GameObject)(object)text6).AddComponent<AudioSource>();
		obj6 = audioSource6;
		unlockSource.loop = (byte)(int)unlockSound != 0;
		unlockSource.pitch = unlockSoundVolume;
		unlockSource.bypassEffects = false;
		object obj7 = this + 136;
		string text7 = tag;
		AudioSource audioSource7 = ((GameObject)(object)text7).AddComponent<AudioSource>();
		obj7 = audioSource7;
		reviveSource.loop = (byte)(int)reviveSound != 0;
		reviveSource.pitch = reviveVolume;
		reviveSource.bypassEffects = false;
		musicVolume = ingameMusicVolume;
		SetGameSoundVolume();
		PlayCelebrationOpenSound();
		musicPlayer.priority = 1;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v73 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v113 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<bool> action = default;
		object obj9 = action + 16;
		obj9 = this;
		((Game)isInstantiated).OnPauseChange -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr;
		((Delegate)action2).method = (nint)__ldftn(AudioStateLoop.OnMusicSettingChanged);
		object obj10 = action2 + 16;
		obj10 = this;
		nint num4 = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v86 (Il2CppClass<Info.Settings>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num5 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v109 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Settings.onMusicSettingsChanged -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr2;
		((Delegate)action3).method = (nint)__ldftn(AudioStateLoop.OnSfxSettingChanged);
		object obj12 = action3 + 16;
		obj12 = this;
		Settings.onSfxSettingChanged -= action3;
		nint num6 = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v99 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num7 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v105 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine instance = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num8 = 0;
		_ = 0;
		Action<Theme> action4 = default;
		object obj14 = action4 + 16;
		obj14 = this;
		((ThemeManager)(object)instance).ThemeChanged -= action4;
	}

	private void OnPauseChange(bool isPaused)
	{
		string msg = string.ConcatArray((string[])(object)"[AssetBundleVersionControl]: ", isPaused ? 1 : 0);
		SDebug.LogFormat(msg, null);
	}

	private void OnThemeChanged(Theme theme)
	{
		if ((object)theme != null)
		{
			if (jetpackSource.loop)
			{
				_resumeJetpackOnUnpause = true;
				jetpackSource.UnPause();
			}
			if (magnetSource.loop)
			{
				_resumeCoinMagnetOnUnpause = true;
				magnetSource.UnPause();
			}
			return;
		}
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v4 (Missions.StayInOneLaneMission)+20]");
		if ((nint)0 != 0)
		{
			if (~(_resumeJetpackOnUnpause ? 1u : 0u) == 0)
			{
				((AudioSampleProvider)(object)jetpackSource).Finalize();
			}
			if (~(_resumeCoinMagnetOnUnpause ? 1u : 0u) == 0)
			{
				((AudioSampleProvider)(object)magnetSource).Finalize();
			}
		}
		_resumeJetpackOnUnpause = false;
		_resumeCoinMagnetOnUnpause = false;
	}

	private void OnMusicSettingChanged()
	{
		ForceStopMusic();
		UpdateMusicPlayer();
	}

	public void ForceStopMusic()
	{
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_014c: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(ThemeManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ThemeManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<SYBO.Subway.Themes.ThemeManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameStateMachine instance = GameStateMachine.Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (SYBO.Subway.StateSystem.GameStateMachine)+20]");
		OnApplicationPause(pause: false);
		nint num3 = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v12 (Il2CppClass<Info.Settings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v21 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PreferencesSave.topRunChallengersEnabled)
		{
			musicPlayer.Stop();
		}
		else
		{
			musicPlayer.UnPause();
		}
	}

	private void OnSfxSettingChanged()
	{
		musicPlayer.UnPause();
	}

	private void UpdateMusicPlayer()
	{
		//IL_00b2: Expected I, but got Obj
		//IL_00c8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PreferencesSave.musicEnabled)
		{
			jetpackSource.pitch = jetpackVolume;
			magnetSource.pitch = magnetVolume;
		}
		else
		{
			jetpackSource.pitch = 0f;
			magnetSource.pitch = 0f;
		}
	}

	private void SetGameSoundVolume()
	{
		musicPlayer.pitch = musicVolume;
	}

	public void OnApplicationPause(bool pause)
	{
		AudioSource audioSource = musicPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pause @ L1 (System.Boolean)+E4]");
		audioSource.loop = false;
	}

	private IEnumerator ResumeSoundAfterFrames(int frames)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_015a: Expected I, but got Obj
		//IL_0170: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I4
		//IL_0267: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I4
		//IL_019b: Expected I, but got Obj
		//IL_0139: Expected I4, but got Obj
		string dataPath = Application.dataPath;
		if (dataPath != null)
		{
			object obj = dataPath - 7;
			if ((nint)dataPath != 7)
			{
				object path;
				if ((nint)obj != 1)
				{
					if ((nint)obj == 2 || (nint)obj == 3)
					{
						goto IL_00fd;
					}
					if ((nint)obj == 4)
					{
						path = "android";
					}
					else
					{
						if ((nint)dataPath != 17)
						{
							goto IL_00fd;
						}
						path = "ios";
					}
				}
				else
				{
					path = "ios";
				}
				nint num = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v32 (Il2CppClass<System.IO.Path>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num2 = (nint)typeof(Path);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S0_v40 (Il2CppClass<System.IO.Path>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = Path.SameRoot("AssetBundleManifests/", (string)path);
				bool flag2 = Path.SameRoot((string)flag, (string)frames);
				return (IEnumerator)flag2;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @80D1");
		object obj3 = default;
		if (obj3 != null)
		{
			bool dontUseIdles = DebugSettings.DontUseIdles;
		}
		return (IEnumerator)(object)string.Empty;
		IL_00fd:
		string dataPath2 = Application.dataPath;
		object obj4 = dataPath2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text = "No manifest folder found for platform: " + text2;
		((AudioStateLoop)null).OnPauseChange((byte)(int)text != 0);
		return (IEnumerator)(object)string.Empty;
	}

	public void PlayCelebrationOpenSound()
	{
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected I4, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v35 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!Settings.optionReminder)
		{
			return;
		}
		nint num3 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v31 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string userLibraryPathiOS = DeviceUtility.GetUserLibraryPathiOS();
		bool flag = (byte)(userLibraryPathiOS & 1) != 0;
		isOtherAudioPlaying = flag;
		if (~(isOtherAudioPlaying ? 1u : 0u) != 0)
		{
			return;
		}
		nint num5 = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v22 (Il2CppClass<Info.Settings>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v27 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Trophies._002Ecctor();
	}

	public void PlayRewardMysterySound()
	{
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PreferencesSave.musicEnabled)
		{
			mysterySource.Stop();
			AudioSource routine = NGUITools.PlaySound((AudioClip)(object)this, fadeUpTime, pauseTime);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)routine);
		}
	}

	public void PlayCelebrationTapSound()
	{
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PreferencesSave.musicEnabled)
		{
			mysteryRewardSource.Stop();
			AudioSource routine = NGUITools.PlaySound((AudioClip)(object)this, fadeUpTime, pauseTime);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)routine);
		}
	}

	public void PlayUnlockSound()
	{
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PreferencesSave.musicEnabled)
		{
			celebrationTapSource.Stop();
			AudioSource routine = NGUITools.PlaySound((AudioClip)(object)this, fadeUpTime, pauseTime);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)routine);
		}
	}

	public void PlayReviveSound()
	{
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PreferencesSave.musicEnabled)
		{
			unlockSource.Stop();
			AudioSource routine = NGUITools.PlaySound((AudioClip)(object)this, fadeUpTime, pauseTime);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)routine);
		}
	}

	private IEnumerator MusicFader(float timeFadeUp, float timePauseTime)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public void ChangeLoop(AudioState audioState)
	{
		if (audioState == AudioState.Menu)
		{
			IEnumerator routine = ((DynamicBgMusic)(object)this).LoopFader(1);
			Coroutine coroutine = StartCoroutine_Auto(routine);
		}
	}

	public void PlayLoop(AudioSource audioSource)
	{
		//IL_015e: Expected I4, but got Obj
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_0183: Expected F4, but got Obj
		//IL_0198: Expected I4, but got Obj
		if ((object)audioSource != null)
		{
			if ((nint)audioSource != 1)
			{
				if ((nint)audioSource != 2)
				{
					if ((nint)audioSource != 3)
					{
						if ((nint)audioSource != 4)
						{
							if ((nint)audioSource == 5)
							{
								((CharacterAudio)null).HandleOnScoreBoostActivated((int)magnetSource);
							}
						}
						else
						{
							object obj = this - -64;
							Quaternion rotationForTime = ((CurveParent)(object)magnetSource).GetRotationForTime(magnetMinPitch, (float)obj);
						}
					}
					else
					{
						((CharacterAudio)null).HandleOnScoreBoostActivated((int)jetpackSource);
					}
				}
				else
				{
					Quaternion rotationForTime2 = ((CurveParent)(object)jetpackSource).GetRotationForTime(jetpackMaxPitch, jetpackMaxPitch);
				}
			}
			else
			{
				if (~(hasPlayedIntro ? 1u : 0u) == 0)
				{
					musicPlayer.clip = null;
				}
				else
				{
					hasPlayedIntro = true;
				}
				musicPlayer.priority = 1;
				musicVolume = ingameMusicVolume;
				SetGameSoundVolume();
			}
		}
		else if (~(hasPlayedIntro ? 1u : 0u) == 0)
		{
			musicPlayer.priority = 0;
			musicVolume = menuMusicVolume;
			SetGameSoundVolume();
		}
	}

	public void PlayLoop(AudioSource audioSource, float minPitch, float maxPitch)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4EF1");
	}

	public void StopLoop(AudioSource audioSource)
	{
		float time = ScrollRect.RubberDelta(0.8f, 1.1f);
		audioSource.time = time;
		audioSource.Stop();
	}

	public AudioStateLoop()
	{
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (PreferencesSave.musicEnabled)
		{
			reviveSource.Stop();
			AudioSource routine = NGUITools.PlaySound((AudioClip)(object)this, reviveFadeUpTime, revivePauseTime);
			Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)routine);
		}
	}
}
