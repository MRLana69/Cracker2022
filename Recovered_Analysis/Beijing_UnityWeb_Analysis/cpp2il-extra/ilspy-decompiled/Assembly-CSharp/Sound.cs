using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Experimental.Audio;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Sound
{
	private sealed class _003Cplay_003Ed__19(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public Sound _003C_003E4__this;

		public Vector3 position;

		public AudioRolloffMode rolloff;

		public float minVolume;

		public float maxVolume;

		public float minPitch;

		public float maxPitch;

		public bool willLoop;

		private bool _003ChasGameObject_003E5__2;

		private bool _003ChasAudioSource_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_043c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0441: Expected Obj, but got Unknown
				//IL_0058: Expected I, but got Obj
				//IL_006e: Expected Obj, but got I
				//IL_0152: Expected I, but got Obj
				//IL_0168: Expected Obj, but got I
				//IL_0099: Expected I, but got Obj
				//IL_0345: Expected I, but got Obj
				//IL_035b: Expected Obj, but got I
				//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Expected Obj, but got Unknown
				//IL_0193: Expected I, but got Obj
				//IL_0386: Expected I, but got Obj
				//IL_02d8: Expected Obj, but got I4
				//IL_0306: Unknown result type (might be due to invalid IL or missing references)
				//IL_030b: Expected Obj, but got Unknown
				//IL_0327: Expected Obj, but got I4
				object obj = default;
				object obj7 = default;
				do
				{
					Transform transform = (Transform)(obj + 12);
					Sound sound = _003C_003E4__this;
					if (_003C_003E1__state != 0)
					{
						if (_003C_003E1__state == 1)
						{
							_003C_003E1__state = -1;
							nint num = (nint)typeof(UnityEngine.Object);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v64 (Il2CppClass<UnityEngine.Object>)+BA]");
							object obj2 = (nint)0 & (nint)0x200;
							if (obj2 != null)
							{
								nint num2 = (nint)typeof(UnityEngine.Object);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (((ComputeShader)(object)sound.audioSource).FindKernel((string)null) != 0)
							{
								sound.audioSource.Pause();
							}
							if (~(sound.destroyAfterPlay ? 1u : 0u) == 0)
							{
								sound.Stop();
							}
							sound._isAvailable = true;
							continue;
						}
						return null;
					}
					_003C_003E1__state = -1;
					_003ChasGameObject_003E5__2 = false;
					_003ChasAudioSource_003E5__3 = false;
					nint num3 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num4 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v58 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (((ComputeShader)(object)sound.gameObject).FindKernel((string)null) != 0)
					{
						_003ChasGameObject_003E5__2 = true;
						int layer = sound.gameObject.layer;
						object obj4 = this + 20;
						obj = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S2_v18+8]");
						_ = 0;
						transform = (Transform)obj;
						Transform transform2 = transform;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
						((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
						Vector3 localPosition = transform.localPosition;
					}
					nint num5 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num6 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)sound.audioSource))
					{
						_003ChasAudioSource_003E5__3 = true;
						PlayableHandle handle = ((AudioClipPlayable*)(int)rolloff)->GetHandle();
						float pitch = ScrollRect.RubberDelta(minVolume, maxVolume);
						sound.audioSource.pitch = pitch;
						float time = ScrollRect.RubberDelta(minPitch, maxPitch);
						sound.audioSource.time = time;
						bool playOnAwake = willLoop;
						sound.audioSource.playOnAwake = playOnAwake;
						sound._isAvailable = false;
						AudioSource component = sound.audioSource.GetComponent<AudioSource>();
						component.Stop();
						if (((AudioSampleProvider)(object)sound.audioSource).id == 0)
						{
							bool isPlaying = sound.audioSource.isPlaying;
							float pitch2 = AudioSource.GetPitch((AudioSource)isPlaying);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							float num7 = pitch2 + 0.1f;
							object obj6 = this + 12;
							obj6 = obj7;
							_003C_003E1__state = 1;
							return 1;
						}
					}
				}
				while (~(_003ChasGameObject_003E5__2 ? 1u : 0u) == 0);
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

	private So _manager;

	private GameObject gameObject;

	private bool _isAvailable;

	public AudioSource audioSource;

	public bool destroyAfterPlay;

	private string _name;

	public bool IsAvailable
	{
		get
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
		}
	}

	public string name
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool isAvailable = _isAvailable;
			return (string)isAvailable;
		}
	}

	public bool loop
	{
		set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
		}
	}

	public Sound(So manager)
	{
		//IL_000f: Expected I4, but got Obj
		audioSource.playOnAwake = (byte)(int)manager != 0;
	}

	public void destroySelf()
	{
		//IL_000b: Expected Obj, but got I4
		gameObject = (GameObject)5;
		_isAvailable = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public void Stop()
	{
		//IL_005e: Expected I4, but got Obj
		//IL_006c: Expected I, but got Obj
		//IL_0082: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		((Sound)(object)_manager).loop = (byte)(int)this != 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate(gameObject);
	}

	public void Pause()
	{
		Rewind();
		_003CfadeOutAndStop_003Eb__17_0();
		Stop();
	}

	public void Rewind()
	{
		audioSource.Pause();
	}

	public IEnumerator fadeOutAndStop(float duration)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 24;
		bool flag = obj == null;
		IEnumerator result = null;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4DE8");
		}
		return result;
	}

	public IEnumerator playAudioClip(AudioClip audioClip, AudioRolloffMode rolloff, float minVolume, float maxVolume, float minPitch, float maxPitch, Vector3 position, bool willLoop = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03f5: Expected Obj, but got I4
		//IL_0417: Expected I, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01bd: Expected Obj, but got I4
		//IL_0255: Expected Obj, but got I
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_03a0: Expected Obj, but got F4
		//IL_0367: Expected Obj, but got F4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected Obj, but got Unknown
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected Obj, but got Unknown
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected Obj, but got Unknown
		//IL_04a1: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 8;
		obj3 = 0;
		_ = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(Settings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v17 (Il2CppClass<Info.Settings>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Settings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v143 (Il2CppClass<Info.Settings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 24;
		if (PreferencesSave.musicEnabled)
		{
			UnityEngine.Object obj6 = UnityEngine.Object.Instantiate((UnityEngine.Object)audioClip);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22+8]");
			_ = 0;
			Sound sound = null;
			object obj8 = default;
			object obj9 = default;
			object obj10 = default;
			object obj11 = default;
			Sound sound3 = default;
			object obj24 = default;
			IEnumerator routine = default;
			while (true)
			{
				object obj7 = obj8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Sound sound2;
					if (obj9 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj10 == null)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj11 == null)
						{
							if (obj7 == null)
							{
								break;
							}
							obj7 = 1;
							continue;
						}
						object obj12 = obj2 + 4;
						object obj13 = obj12 + 1;
						obj12 = obj13;
						object obj14 = obj13 << 2;
						object obj15 = obj2 + obj14;
						obj15 = 129;
						sound2 = sound3;
					}
					else
					{
						object obj16 = obj2 + 4;
						object obj17 = obj16 + 1;
						obj16 = obj17;
						object obj18 = obj17 << 2;
						object obj19 = obj2 + obj18;
						obj19 = 129;
						sound2 = sound;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						object obj20 = (nint)0 << 2;
						object obj21 = obj2 + obj20;
						if ((nint)obj21 == 129)
						{
							object obj22 = obj2 + 4;
							if ((nint)obj22 > -1)
							{
								object obj23 = obj22 + -1;
								obj22 = obj23;
							}
							goto IL_051a;
						}
					}
					if (obj24 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					}
					goto IL_051a;
					IL_051a:
					Sound result;
					if (sound2 != null)
					{
						result = sound2;
					}
					else
					{
						Sound sound4 = ((List<Sound>)(object)audioSource).get_Item(0);
						((List<Sound>)(object)audioSource).Add(sound4);
						result = sound4;
					}
					if (true)
					{
						obj5 = position.x;
						_ = position.z;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A363");
						Coroutine coroutine = ((MonoBehaviour)this).StartCoroutine_Auto(routine);
					}
					else
					{
						obj5 = position.x;
						_ = position.z;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A362");
						IEnumerator routine2;
						Coroutine coroutine2 = ((MonoBehaviour)this).StartCoroutine_Auto(routine2);
					}
					return (IEnumerator)result;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				sound = sound3;
			}
		}
		return null;
	}

	public IEnumerator play(AudioRolloffMode rolloff, float minVolume, float maxVolume, float minPitch, float maxPitch, Vector3 position, bool willLoop)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}

	private void _003CfadeOutAndStop_003Eb__17_0()
	{
		audioSource.spatialBlend = 0f;
	}
}
