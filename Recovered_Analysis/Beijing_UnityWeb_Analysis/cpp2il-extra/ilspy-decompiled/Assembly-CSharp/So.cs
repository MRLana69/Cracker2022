using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Subway.Characters;
using UnityEngine;

public class So : MonoBehaviour
{
	private sealed class _003CplaySoundAsync_003Ed__13(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public So _003C_003E4__this;

		public AudioClipInfo audioClip;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Expected Obj, but got Unknown
				//IL_0062: Expected Obj, but got I4
				//IL_0076: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						HoverboardBundle hoverboardBundle = ((CharacterModel)(object)_003C_003E4__this).AddHoverboard((string)(object)audioClip, false);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				object obj = this + 12;
				obj = 0;
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

	public static So Instance;

	public int initialCapacity;

	public int maxCapacity;

	private List<Sound> _soundList;

	private Sound _bgSound;

	private bool _audioWasPlaying;

	private float _audioTime;

	private void Awake()
	{
		//IL_000b: Expected I4, but got F4
		//IL_0016: Expected Obj, but got F4
		maxCapacity = 0;
		_soundList = (List<Sound>)0.0625f;
		CancelInvoke();
	}

	private void OnApplicationPause(bool didPause)
	{
		//IL_00e0: Expected I, but got Obj
		//IL_00f6: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_0196: Expected Obj, but got I
		//IL_0092: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_002c: Expected I, but got Obj
		nint num = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<So>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj != null;
		bool audioWasPlaying = _audioWasPlaying;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (System.Boolean)+8C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v12+10]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v13+20]");
		if ((nint)0 != 0)
		{
			if (flag)
			{
				nint num2 = (nint)typeof(So);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v34 (Il2CppClass<So>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			So instance = Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (So)+6C]");
			HoverboardBundle hoverboardBundle = ((CharacterModel)(object)instance).AddHoverboard((string)0, false);
			return;
		}
		if (flag)
		{
			nint num3 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v22 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		So instance2 = Instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [didPause @ L1 (System.Boolean)+18]");
		HoverboardBundle hoverboardBundle2 = ((CharacterModel)(object)instance2).AddHoverboard((string)0, false);
	}

	private unsafe void OnSfxSettingsChanged()
	{
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_03e8: Expected I, but got Obj
		//IL_03fe: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_0445: Expected Obj, but got I4
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_0461: Expected Obj, but got I4
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_024b: Expected I, but got Obj
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_031a: Expected I, but got Obj
		//IL_0330: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_035b: Expected I, but got Obj
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		Character instance = Character.Instance;
		if ((object)instance != null)
		{
			nint num = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v79 (Il2CppClass<Info.Settings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Settings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v85 (Il2CppClass<Info.Settings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Settings.optionMusic = true;
			Settings.optionTopRunChallengers = false;
		}
		nint num3 = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v9 (Il2CppClass<So>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v72 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)Instance).FindKernel((string)null) != 0)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v63 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		nint num9 = (nint)typeof(So);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (Il2CppClass<So>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(So);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v56 (Il2CppClass<So>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Instance = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list)._002Ector((IEnumerable<T>)initialCapacity);
		object obj6 = this + 20;
		obj6 = list;
		object obj7 = 0;
		SprayDetectionAwaker sprayDetectionAwaker = default;
		while ((nint)obj7 < initialCapacity)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			sprayDetectionAwaker.CheckScreen((string)(object)this);
			_soundList.Add((Sound)(object)sprayDetectionAwaker);
			object obj8 = obj7 + 1;
			obj7 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(So.OnSfxSettingsChanged);
		object obj9 = action + 16;
		obj9 = this;
		nint num11 = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v43 (Il2CppClass<Info.Settings>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num12 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v48 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Settings.onSfxSettingChanged -= action;
	}

	public void playBGMusic(AudioClip audioClip, float volume, bool loop)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private void MuteAllSfx()
	{
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Settings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!PreferencesSave.musicEnabled)
		{
			this._002Ector();
		}
	}

	public unsafe void beginPlaySound(AudioClipInfo audioClip)
	{
		if (audioClip != null)
		{
			if (_bgSound != null)
			{
				_audioWasPlaying = true;
				Sound bgSound = _bgSound;
				float duration = ((ParticleSystem.MainModule*)bgSound.audioSource)->duration;
				_audioTime = duration;
			}
		}
		else if (~(_audioWasPlaying ? 1u : 0u) == 0)
		{
			_audioWasPlaying = false;
			Sound bgSound2 = _bgSound;
			bgSound2.audioSource.spatialBlend = _audioTime;
			Sound bgSound3 = _bgSound;
			bgSound3.audioSource.Stop();
		}
	}

	private unsafe IEnumerator playSoundAsync(AudioClipInfo audioClip)
	{
		//IL_0014: Expected I4, but got Obj
		//IL_0014: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_0058: Expected Obj, but got I4
		//IL_008d: Expected I4, but got Obj
		//IL_008d: Expected Obj, but got I4
		//IL_009a: Expected Obj, but got I4
		//IL_00c4: Expected I4, but got Obj
		//IL_00c4: Expected Obj, but got I4
		//IL_00d6: Expected Obj, but got I4
		//IL_011c: Expected F4, but got I4
		//IL_01c2: Expected Obj, but got I4
		//IL_0155: Expected F4, but got I4
		//IL_018e: Expected F4, but got I4
		bool flag = ((Animation)maxCapacity).Play((PlayMode)audioClip.Clip);
		if (((TrackedReference)flag).Equals(null))
		{
			AnimationState animationState = ((Animation)maxCapacity).get_Item((string)(object)audioClip.Clip);
			if ((object)animationState != null)
			{
				bool flag2 = ((Animation)maxCapacity).Play((PlayMode)audioClip.Clip);
				string text = ((AnimationState)flag2).name;
				float normalizedTime = ((AnimatorStateInfo*)text)->normalizedTime;
				bool flag3 = ((Animation)maxCapacity).Play((PlayMode)audioClip.Clip);
				float normalizedTime2 = ((AnimationState)flag3).normalizedTime;
				float num = normalizedTime * normalizedTime2;
				if (num != num)
				{
					num = -2.1474836E+09f;
				}
				else if (!(num < 2.1474836E+09f))
				{
					num = -2.1474836E+09f;
				}
				else if (!(num > -2.1474836E+09f))
				{
					num = -2.1474836E+09f;
				}
				bool flag4 = audioClip.minPitch == num;
				return (IEnumerator)flag4;
			}
			return null;
		}
		return null;
	}

	public Sound playSound(AudioClipInfo audioClip, bool willLoop = false)
	{
		//IL_0053: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_0073: Expected Obj, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected Obj, but got Unknown
		//IL_002e: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			int num2 = ((Dictionary<string, int>)(object)_soundList).get_Item((string)(object)audioClip);
			bool flag = num2 == (willLoop ? 1 : 0);
			return (Sound)flag;
		}
		return null;
	}

	public Sound playSound(AudioClipInfo audioClipInfo, float hardVolume, float hardPitch)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public Sound playSound(AudioClipInfo audioClipInfo, float hardVolume, float hardPitch, bool willLoop = false)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public Sound playSound(AudioClip audioClip, AudioRolloffMode rolloff, float volume, Vector3 position)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5A10");
		Sound result = default;
		return result;
	}

	public Sound playSound(AudioClip audioClip, AudioRolloffMode rolloff, float minVolume, float maxVolume, float minPitch, float maxPitch, Vector3 position, bool willLoop = false)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	public void removeSound(Sound s)
	{
		IEnumerator routine = ((TurnTableLoopPlayer)this).StartLooper((AudioLoopInfo)(object)s);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	public So()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e4: Expected Obj, but got I4
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_009b: Expected Obj, but got I4
		//IL_0123: Expected Obj, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj6 = obj4 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj4 + obj8;
		obj9 = 51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj10 = (nint)0 << 2;
			object obj11 = obj4 + obj10;
			if ((nint)obj11 == 51)
			{
				object obj12 = obj4 + 4;
				if ((nint)obj12 > -1)
				{
					object obj13 = obj12 + -1;
					obj12 = obj13;
				}
				return;
			}
		}
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	static So()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector();
		AnimationSoundPlayer.nodesInitialized = list;
	}
}
