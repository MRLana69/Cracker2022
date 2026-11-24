using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Subway.Characters;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Playables;
using UnityEngine.UI;

public class ProximityAudioPlayer : MonoBehaviour
{
	private AudioClipInfo _clipInfo;

	private float _maxZProximity;

	private float _minZProximity;

	private bool _useParentPosition;

	private bool _muted;

	private AudioSource _source;

	private Character _character;

	private void Start()
	{
		//IL_0066: Expected I, but got Obj
		//IL_007c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		_ = 1;
		nint num = (nint)typeof(AnimationSoundPlayer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7 (Il2CppClass<AnimationSoundPlayer>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AnimationSoundPlayer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v12 (Il2CppClass<AnimationSoundPlayer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((KeyFrameAction)(object)this)._002Ector();
	}

	private unsafe void OnSfxSettingChanged()
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_011b: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected Obj, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected Obj, but got Unknown
		//IL_01a5: Expected I, but got Obj
		//IL_01bb: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		object obj = this + 28;
		AudioSource component = GetComponent<AudioSource>();
		obj = component;
		AudioClipInfo clipInfo = _clipInfo;
		_source.loop = (byte)(int)clipInfo.Clip != 0;
		AudioClipInfo clipInfo2 = _clipInfo;
		PlayableHandle handle = ((AudioClipPlayable*)(int)clipInfo2.Rollof)->GetHandle();
		nint num = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v12 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v35 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = this + 32;
		CharacterRendering instance = CharacterRendering.Instance;
		obj3 = instance;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(ProximityAudioPlayer.OnSfxSettingChanged);
		object obj4 = action + 16;
		obj4 = this;
		nint num3 = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v25 (Il2CppClass<Info.Settings>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v31 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Settings.onSfxSettingChanged -= action;
		ProximityBasedPlay();
	}

	public void ProximityBasedPlay()
	{
		//IL_00d4: Expected I, but got Obj
		//IL_00ea: Expected Obj, but got I
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
			_muted = false;
			AudioClipInfo clipInfo = _clipInfo;
			AudioClipInfo clipInfo2 = _clipInfo;
			float pitch = ScrollRect.RubberDelta(clipInfo.minVolume, clipInfo2.maxVolume);
			_source.pitch = pitch;
		}
		else
		{
			_muted = true;
			_source.pitch = 0f;
		}
	}

	public void Stop()
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0164: Expected VT, but got Obj
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I
		//IL_01ad: Invalid comparison between Obj and F4
		//IL_0063: Invalid comparison between Obj and F4
		bool useParentPosition = _useParentPosition;
		GameObject gameObject = base.gameObject;
		bool flag = !useParentPosition;
		Transform transform = (Transform)(object)gameObject;
		if (!flag)
		{
			Transform parentInternal = ((Transform)(object)gameObject).parentInternal;
			transform = parentInternal;
		}
		object obj = default;
		Transform transform2 = (Transform)(obj + 12);
		transform2.position = (Vector3)transform;
		object obj2 = _character + 248;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S2_v5+8]");
		_ = 0;
		IntPtr cachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		object obj3 = (nint)cachedPtr - 0;
		if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_minZProximity) && System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)_maxZProximity))
		{
			AudioClipInfo clipInfo = _clipInfo;
			AudioClipInfo clipInfo2 = _clipInfo;
			float time = ScrollRect.RubberDelta(clipInfo.minPitch, clipInfo2.maxPitch);
			_source.time = time;
			if (~(_muted ? 1u : 0u) == 0)
			{
				_source.pitch = 0f;
			}
			else
			{
				AudioClipInfo clipInfo3 = _clipInfo;
				AudioClipInfo clipInfo4 = _clipInfo;
				float pitch = ScrollRect.RubberDelta(clipInfo3.minVolume, clipInfo4.maxVolume);
				_source.pitch = pitch;
			}
			_source.Stop();
		}
	}

	public ProximityAudioPlayer()
	{
		_source.Pause();
	}
}
