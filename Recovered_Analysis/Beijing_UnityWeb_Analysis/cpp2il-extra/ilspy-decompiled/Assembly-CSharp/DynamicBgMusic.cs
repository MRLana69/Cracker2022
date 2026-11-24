using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class DynamicBgMusic : MonoBehaviour
{
	private sealed class _003CLoopFader_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DynamicBgMusic _003C_003E4__this;

		public int audioSourceID;

		private float _003Ccounter_003E5__2;

		private float _003CstartFade_003E5__3;

		private float _003CfadeSpeed_003E5__4;

		private float _003CtargetVolume_003E5__5;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_01ba: Expected native int or pointer, but got F4
				//IL_01c8: Expected I4, but got Obj
				//IL_01c8: Expected Obj, but got F4
				//IL_020f: Expected Ref, but got F4
				//IL_0217: Expected native int or pointer, but got F4
				//IL_0225: Expected Obj, but got F4
				//IL_0262: Expected native int or pointer, but got F4
				//IL_026c: Expected Obj, but got F4
				//IL_02af: Expected native int or pointer, but got F4
				//IL_02b9: Expected Obj, but got F4
				//IL_02e3: Expected F4, but got I4
				//IL_02e3: Expected F4, but got Obj
				//IL_031e: Expected F4, but got I
				//IL_031e: Expected F4, but got I
				//IL_05e7: Expected I, but got Obj
				//IL_05fd: Expected Obj, but got I
				//IL_00e9: Expected native int or pointer, but got F4
				//IL_00f3: Expected Obj, but got F4
				//IL_0118: Expected F4, but got I4
				//IL_0118: Expected F4, but got Obj
				//IL_07b0: Expected native int or pointer, but got F4
				//IL_07be: Expected Obj, but got F4
				//IL_0568: Expected native int or pointer, but got F4
				//IL_0578: Expected Obj, but got F4
				//IL_0595: Expected F4, but got I
				//IL_0595: Expected F4, but got I
				//IL_0699: Unknown result type (might be due to invalid IL or missing references)
				//IL_069e: Expected Obj, but got Unknown
				//IL_06a7: Expected Obj, but got I4
				//IL_06bb: Expected Obj, but got I4
				//IL_0628: Expected I, but got Obj
				//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_05b8: Expected Obj, but got Unknown
				//IL_05d4: Expected Obj, but got I4
				//IL_0422: Expected I, but got Obj
				//IL_0438: Expected Obj, but got I
				//IL_0741: Expected native int or pointer, but got F4
				//IL_074f: Expected Obj, but got F4
				//IL_03a3: Expected native int or pointer, but got F4
				//IL_03b3: Expected Obj, but got F4
				//IL_03d0: Expected F4, but got I
				//IL_03d0: Expected F4, but got I
				//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_04d9: Expected Obj, but got Unknown
				//IL_04e2: Expected Obj, but got I4
				//IL_04f6: Expected Obj, but got I4
				//IL_0463: Expected I, but got Obj
				//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f3: Expected Obj, but got Unknown
				//IL_040f: Expected Obj, but got I4
				DynamicBgMusic dynamicBgMusic = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state != 3)
							{
								if (_003C_003E1__state == 4)
								{
									goto IL_016a;
								}
								return null;
							}
							_003C_003E1__state = -1;
						}
						else
						{
							_003C_003E1__state = -1;
							_003Ccounter_003E5__2 = 0f;
							float num = ((ScoreCounterSoundPlayer)(object)dynamicBgMusic).count + 16f;
							int num2 = audioSourceID << 2;
							float num3 = num + (float)num2;
							float pitch = ((AudioSource)((float*)(nint)num3)->m_value).pitch;
							_003CstartFade_003E5__3 = pitch;
							float num4 = ScrollRect.RubberDelta((float)((ScoreCounterSoundPlayer)(object)dynamicBgMusic).scoreSource, (float)(((ScoreCounterSoundPlayer)(object)dynamicBgMusic).playScore ? 1 : 0));
							float num5 = 1f / num4;
							_003CfadeSpeed_003E5__4 = num5;
							_003CtargetVolume_003E5__5 = 0f;
						}
						if (!(_003Ccounter_003E5__2 < 1f))
						{
							float num6 = ((ScoreCounterSoundPlayer)(object)dynamicBgMusic).count + 16f;
							int num7 = audioSourceID << 2;
							float num8 = num6 + (float)num7;
							((AudioSource)((float*)(nint)num8)->m_value).pitch = _003CtargetVolume_003E5__5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (DynamicBgMusic)+2C]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (DynamicBgMusic)+30]");
							float num10 = ScrollRect.RubberDelta((float)num9, 0f);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							object obj = this + 12;
							object obj2 = default;
							obj = obj2;
							_003C_003E1__state = 4;
							return 1;
						}
						nint num11 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S3_v21 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num12 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S3_v28 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float pitch2 = Mathf.LerpUnclamped(_003CstartFade_003E5__3, _003CtargetVolume_003E5__5, _003Ccounter_003E5__2);
						float num13 = ((ScoreCounterSoundPlayer)(object)dynamicBgMusic).count + 16f;
						int num14 = audioSourceID << 2;
						float num15 = num13 + (float)num14;
						((AudioSource)((float*)(nint)num15)->m_value).pitch = pitch2;
						float unscaledTime = Time.unscaledTime;
						float num16 = unscaledTime * _003CfadeSpeed_003E5__4;
						float num17 = _003Ccounter_003E5__2 + num16;
						_003Ccounter_003E5__2 = num17;
						object obj4 = this + 12;
						obj4 = 0;
						_003C_003E1__state = 3;
						return 1;
					}
					_003C_003E1__state = -1;
					goto IL_04fb;
				}
				goto IL_016a;
				IL_04fb:
				if (!(_003Ccounter_003E5__2 < 1f))
				{
					float num18 = ((ScoreCounterSoundPlayer)(object)dynamicBgMusic).count + 16f;
					int num19 = audioSourceID << 2;
					float num20 = num18 + (float)num19;
					((AudioSource)((float*)(nint)num20)->m_value).pitch = _003CtargetVolume_003E5__5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (DynamicBgMusic)+24]");
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (DynamicBgMusic)+28]");
					float num22 = ScrollRect.RubberDelta((float)num21, 0f);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj5 = this + 12;
					object obj6 = default;
					obj5 = obj6;
					_003C_003E1__state = 2;
					return 1;
				}
				nint num23 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S3_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num24 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S3_v11 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float pitch3 = Mathf.LerpUnclamped(_003CstartFade_003E5__3, _003CtargetVolume_003E5__5, _003Ccounter_003E5__2);
				float num25 = ((ScoreCounterSoundPlayer)(object)dynamicBgMusic).count + 16f;
				int num26 = audioSourceID << 2;
				float num27 = num25 + (float)num26;
				((AudioSource)((float*)(nint)num27)->m_value).pitch = pitch3;
				float unscaledTime2 = Time.unscaledTime;
				float num28 = unscaledTime2 * _003CfadeSpeed_003E5__4;
				float num29 = _003Ccounter_003E5__2 + num28;
				_003Ccounter_003E5__2 = num29;
				object obj8 = this + 12;
				obj8 = 0;
				_003C_003E1__state = 1;
				return 1;
				IL_016a:
				_003C_003E1__state = -1;
				float num30 = ((ScoreCounterSoundPlayer)(object)dynamicBgMusic).count + 16f;
				int num31 = audioSourceID << 2;
				float num32 = num30 + (float)num31;
				IEnumerator enumerator = ((ScoreCounterSoundPlayer)(object)dynamicBgMusic).ScoreSoundTimer();
				((AudioSource)((float*)(nint)num32)->m_value).loop = (byte)(int)enumerator != 0;
				float num33 = ((ScoreCounterSoundPlayer)(object)dynamicBgMusic).count + 16f;
				int num34 = audioSourceID << 2;
				float num35 = num33 + (float)num34;
				float duration = ((ParticleSystem.MainModule*)((ScoreCounterSoundPlayer)(object)dynamicBgMusic).stepDelay)->duration;
				((AudioSource)((float*)(nint)num35)->m_value).spatialBlend = duration;
				float num36 = ((ScoreCounterSoundPlayer)(object)dynamicBgMusic).count + 16f;
				int num37 = audioSourceID << 2;
				float num38 = num36 + (float)num37;
				((AudioSource)((float*)(nint)num38)->m_value).Stop();
				_003Ccounter_003E5__2 = 0f;
				float num39 = ((ScoreCounterSoundPlayer)(object)dynamicBgMusic).count + 16f;
				int num40 = audioSourceID << 2;
				float num41 = num39 + (float)num40;
				float pitch4 = ((AudioSource)((float*)(nint)num41)->m_value).pitch;
				_003CstartFade_003E5__3 = pitch4;
				float num42 = ScrollRect.RubberDelta((float)((ScoreCounterSoundPlayer)(object)dynamicBgMusic).scoreSource, (float)(((ScoreCounterSoundPlayer)(object)dynamicBgMusic).playScore ? 1 : 0));
				float num43 = 1f / num42;
				_003CfadeSpeed_003E5__4 = num43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (DynamicBgMusic)+34]");
				nint num44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (DynamicBgMusic)+38]");
				float num45 = ScrollRect.RubberDelta((float)num44, 0f);
				_003CtargetVolume_003E5__5 = num45;
				goto IL_04fb;
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

	public AudioClip[] audioClips;

	public AudioClip masterClip;

	private AudioSource masterSource;

	private AudioSource[] audioSources;

	public float minFadeTime;

	public float maxFadeTime;

	public float minPlayingTime;

	public float maxPlayingTime;

	public float minPauseTime;

	public float maxPauseTime;

	public float minPlayingVolume;

	public float maxPlayingVolume;

	public float masterSourceVolume;

	private void Awake()
	{
		CancelInvoke();
	}

	private AudioClip FindNotYetPlayingLoop()
	{
		//IL_0010: Expected Obj, but got I
		UnityEngine.Object args = UnityEngine.Object.Instantiate((UnityEngine.Object)(nint)((UnityEngine.Object)this).m_CachedPtr);
		return (AudioClip)(object)$"[AudioClipInfo (Clip={(object[])(object)args})]";
	}

	private IEnumerator LoopFader(int audioSourceID)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		return enumerator;
	}

	public DynamicBgMusic()
	{
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected Obj, but got Unknown
		//IL_0016: Expected I4, but got Obj
		//IL_0040: Expected Obj, but got I4
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		object obj = this + 20;
		string text = tag;
		AudioSource audioSource = ((GameObject)(object)text).AddComponent<AudioSource>();
		obj = audioSource;
		masterSource.playOnAwake = true;
		masterSource.loop = (byte)(int)masterClip != 0;
		masterSource.pitch = masterSourceVolume;
		masterSource.Stop();
		object obj2 = 0;
		AudioSource[] array = audioSources;
		if ((nint)obj2 < array.Length)
		{
			string text2 = tag;
			AudioSource audioSource2 = ((GameObject)(object)text2).AddComponent<AudioSource>();
			throw new ArrayTypeMismatchException();
		}
		Transform transform = null;
		while (true)
		{
			AudioSource[] array2 = audioSources;
			if ((nint)transform < array2.Length)
			{
				Animation animationInAncestors = ((OutfitKeyframeBehaviour)this).GetAnimationInAncestors(transform);
				Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)animationInAncestors);
				Transform transform2 = (Transform)(transform + 1);
				transform = transform2;
				continue;
			}
			break;
		}
	}
}
