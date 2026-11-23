using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Managers;
using UnityEngine;

public class So : MonoBehaviour
{
	private sealed class _003CplaySoundAsync_003Ed__13(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public So _003C_003E4__this;

		public AudioClipInfo audioClip;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0052: Expected I4, but got I8
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					Sound sound = _003C_003E4__this.playSound(audioClip);
				}
				return false;
			}
			_003C_003E1__state = -1;
			_003C_003E1__state = 1;
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

	public static So Instance;

	public int initialCapacity = 5;

	public int maxCapacity;

	private List<Sound> _soundList;

	private Sound _bgSound;

	private bool _audioWasPlaying;

	private float _audioTime;

	private unsafe void Awake()
	{
		//IL_0084: Expected Obj, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		if (DemoVideoModeManager.IsEnabled)
		{
			Settings.optionSfx = true;
			Settings.optionMusic = false;
		}
		if (Instance != null)
		{
			UnityEngine.Object.Destroy(this);
			return;
		}
		Instance = this;
		List<Sound> list = default;
		list._002Ector(initialCapacity);
		_soundList = list;
		object obj = 0;
		Sound sound = default;
		while (initialCapacity > (nint)obj)
		{
			sound._002Ector(this);
			_soundList.Add(sound);
			object obj2 = obj + 1;
			obj = obj2;
		}
		Action action = default;
		action._002Ector(this, (nint)__ldftn(So.OnSfxSettingsChanged));
		Settings.onSfxSettingChanged += action;
	}

	private void OnApplicationPause(bool didPause)
	{
		if (didPause)
		{
			Sound bgSound = _bgSound;
			if (_bgSound != null)
			{
				_audioWasPlaying = true;
				float time = bgSound.audioSource.time;
				_audioTime = time;
			}
		}
		else if (~(_audioWasPlaying ? 1u : 0u) == 0)
		{
			_audioWasPlaying = false;
			Sound bgSound2 = _bgSound;
			bgSound2.audioSource.time = _audioTime;
			Sound bgSound3 = _bgSound;
			bgSound3.audioSource.Play();
		}
	}

	private void OnSfxSettingsChanged()
	{
		if (!Settings.optionSfx)
		{
			MuteAllSfx();
		}
	}

	public void playBGMusic(AudioClip audioClip, float volume, bool loop)
	{
		if (Settings.optionMusic)
		{
			Sound bgSound = _bgSound;
			if (_bgSound == null)
			{
				Sound sound = default;
				sound._002Ector(this);
				_bgSound = sound;
				bgSound = _bgSound;
			}
			bgSound.loop = loop;
		}
	}

	private void MuteAllSfx()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected Obj, but got Unknown
		//IL_02f0: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7;
		object obj8 = default;
		object obj9 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj6 == null;
				obj7 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj8 == obj9;
			bool flag3 = !flag2;
			object obj10 = obj11;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj7 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj10 = obj12;
			}
			_ = 0;
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			obj7 = 0;
			break;
		}
		object obj14 = obj7 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A99");
	}

	public void beginPlaySound(AudioClipInfo audioClip)
	{
		IEnumerator routine = playSoundAsync(audioClip);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator playSoundAsync(AudioClipInfo audioClip)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public unsafe Sound playSound(AudioClipInfo audioClip, bool willLoop = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0051: Expected F4, but got I
		//IL_004c: Expected native int or pointer, but got VT
		//IL_0073: Expected F4, but got I
		//IL_006e: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		if (!(audioClip.Clip == null))
		{
			Transform transform = base.transform;
			Vector3 position = transform.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			((Vector3*)(nint)vector)->x = 0f;
			return playSound(audioClip.Clip, audioClip.Rollof, audioClip.minVolume, audioClip.maxVolume, audioClip.minPitch, audioClip.maxPitch, vector, willLoop);
		}
		Sound result = default;
		return result;
	}

	public unsafe Sound playSound(AudioClipInfo audioClipInfo, float hardVolume, float hardPitch)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004c: Expected F4, but got I
		//IL_0047: Expected native int or pointer, but got VT
		//IL_006e: Expected F4, but got I
		//IL_0069: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		return playSound(audioClipInfo.Clip, audioClipInfo.Rollof, hardVolume, hardVolume, hardPitch, hardPitch, vector);
	}

	public unsafe Sound playSound(AudioClipInfo audioClipInfo, float hardVolume, float hardPitch, bool willLoop = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_004c: Expected F4, but got I
		//IL_0047: Expected native int or pointer, but got VT
		//IL_006e: Expected F4, but got I
		//IL_0069: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		Transform transform = base.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		return playSound(audioClipInfo.Clip, audioClipInfo.Rollof, hardVolume, hardVolume, hardPitch, hardPitch, vector, willLoop);
	}

	public unsafe Sound playSound(AudioClip audioClip, AudioRolloffMode rolloff, float volume, Vector3 position)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001b: Expected native int or pointer, but got VT
		//IL_002d: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		((Vector3*)(nint)vector)->z = position.z;
		((Vector3*)(nint)vector)->x = position.x;
		return playSound(audioClip, rolloff, volume, volume, 1f, 1f, vector);
	}

	public Sound playSound(AudioClip audioClip, AudioRolloffMode rolloff, float minVolume, float maxVolume, float minPitch, float maxPitch, Vector3 position, bool willLoop = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected Obj, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected Obj, but got Unknown
		//IL_00f8: Expected Obj, but got I
		//IL_00cf: Expected Obj, but got I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected VT, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected VT, but got Unknown
		//IL_02ed: Expected Obj, but got I4
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01e1: Expected Obj, but got I4
		//IL_01b6: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		_ = 0;
		Sound sound2 = default;
		if (Settings.optionSfx)
		{
			string text = audioClip.name;
			object obj3 = obj + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+30]");
			_ = 0;
			object obj4 = obj - -64;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
			_ = 0;
			Sound sound = null;
			object obj6 = default;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			object obj13 = default;
			object obj14 = default;
			object obj16 = default;
			object obj17 = default;
			Sound result = default;
			IEnumerator routine;
			while (true)
			{
				_ = 0;
				object obj5 = obj - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				object obj7;
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj6 == null)
					{
						sound2 = sound;
						obj7 = 0;
						goto IL_02fb;
					}
					_ = 0;
					object obj8 = obj - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S1_v85+C]");
					Sound sound3 = (Sound)0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						if (~(sound3._isAvailable ? 1u : 0u) != 0)
						{
							continue;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							if (obj9 != null)
							{
								sound2 = sound3;
								obj7 = 1;
								goto IL_02fb;
							}
							object obj10 = obj11 & 1;
							obj11 = 1;
							if (obj10 != null)
							{
								continue;
							}
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag = (nint)0 != 1;
							obj11 = obj12;
							sound = sound3;
							if (flag)
							{
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj13 != obj14;
				object obj15 = obj16;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag3 = (nint)0 == 1;
					sound2 = sound;
					obj7 = 0;
					if (!flag3)
					{
						goto IL_02fb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj15 = obj17;
				}
				_ = 0;
				object obj18 = obj + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
					sound2 = sound;
					goto IL_051d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return result;
				IL_02fb:
				object obj19 = obj + 48;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3A99");
				if (sound2 == null)
				{
					Sound sound4 = _soundList.get_Item(0);
					_soundList.Add(sound4);
					sound2 = sound4;
				}
				if (obj7 != null)
				{
					_ = position.z;
					_ = position.x;
					Vector3 position2 = (Vector3)(obj + 8);
					routine = sound2.play(rolloff, minVolume, maxVolume, minPitch, maxPitch, position2, willLoop);
					break;
				}
				goto IL_051d;
				IL_051d:
				_ = position.z;
				_ = position.x;
				Vector3 position3 = (Vector3)(obj + 24);
				routine = sound2.playAudioClip(audioClip, rolloff, minVolume, maxVolume, minPitch, maxPitch, position3, willLoop);
				break;
			}
			Coroutine coroutine = StartCoroutine(routine);
		}
		return sound2;
	}

	public void removeSound(Sound s)
	{
		bool flag = _soundList.Remove(s);
	}

	public So()
	{
		//IL_000f: Expected I4, but got I8
	}
}
