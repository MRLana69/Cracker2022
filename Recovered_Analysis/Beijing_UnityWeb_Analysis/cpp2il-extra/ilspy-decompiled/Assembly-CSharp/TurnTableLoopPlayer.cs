using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class TurnTableLoopPlayer : MonoBehaviour
{
	private sealed class _003CStartLooper_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TurnTableLoopPlayer _003C_003E4__this;

		public AudioLoopInfo audioLoopInfo;

		private float _003Ccounter_003E5__2;

		private float _003CstartFadeVol_003E5__3;

		private float _003CstartFadePitch_003E5__4;

		private float _003CfadeSpeed_003E5__5;

		private float _003CtargetVol_003E5__6;

		private float _003CtargetPitch_003E5__7;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected Obj, but got Unknown
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Expected Obj, but got Unknown
				//IL_00a9: Expected I4, but got Obj
				//IL_02c6: Expected I, but got Obj
				//IL_02dc: Expected Obj, but got I
				//IL_0307: Expected I, but got Obj
				//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a5: Expected Obj, but got Unknown
				//IL_02ae: Expected Obj, but got I4
				//IL_0398: Unknown result type (might be due to invalid IL or missing references)
				//IL_039d: Expected Obj, but got Unknown
				//IL_03a6: Expected Obj, but got I4
				//IL_03ba: Expected Obj, but got I4
				TurnTableLoopPlayer turnTableLoopPlayer = _003C_003E4__this;
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
					AudioLoopInfo audioLoopInfo = this.audioLoopInfo;
					object obj = audioLoopInfo.clips + 16;
					AudioLoopInfo audioLoopInfo2 = this.audioLoopInfo;
					AudioClip[] clips = audioLoopInfo2.clips;
					int num = UnityEngine.Random.RandomRangeInt(0, clips.Length);
					int num2 = num << 2;
					object obj2 = obj + num2;
					turnTableLoopPlayer.audioSource.loop = (byte)(int)obj2 != 0;
					turnTableLoopPlayer.audioSource.playOnAwake = true;
					turnTableLoopPlayer.audioSource.Stop();
					_003Ccounter_003E5__2 = 0f;
					AudioLoopInfo audioLoopInfo3 = this.audioLoopInfo;
					AudioLoopInfo audioLoopInfo4 = this.audioLoopInfo;
					float num3 = ScrollRect.RubberDelta(audioLoopInfo3.minStartVolume, audioLoopInfo4.maxStartVolume);
					_003CstartFadeVol_003E5__3 = num3;
					AudioLoopInfo audioLoopInfo5 = this.audioLoopInfo;
					AudioLoopInfo audioLoopInfo6 = this.audioLoopInfo;
					float num4 = ScrollRect.RubberDelta(audioLoopInfo5.minStartPitch, audioLoopInfo6.maxStartPitch);
					_003CstartFadePitch_003E5__4 = num4;
					AudioLoopInfo audioLoopInfo7 = this.audioLoopInfo;
					AudioLoopInfo audioLoopInfo8 = this.audioLoopInfo;
					float num5 = ScrollRect.RubberDelta(audioLoopInfo7.minStartTime, audioLoopInfo8.maxStartTime);
					float num6 = 1f / num5;
					_003CfadeSpeed_003E5__5 = num6;
					AudioLoopInfo audioLoopInfo9 = this.audioLoopInfo;
					AudioLoopInfo audioLoopInfo10 = this.audioLoopInfo;
					float num7 = ScrollRect.RubberDelta(audioLoopInfo9.minTargetVolume, audioLoopInfo10.maxTargatVolume);
					_003CtargetVol_003E5__6 = num7;
					AudioLoopInfo audioLoopInfo11 = this.audioLoopInfo;
					AudioLoopInfo audioLoopInfo12 = this.audioLoopInfo;
					float num8 = ScrollRect.RubberDelta(audioLoopInfo11.minTargetPitch, audioLoopInfo12.maxTargetPitch);
					_003CtargetPitch_003E5__7 = num8;
				}
				if (!(_003Ccounter_003E5__2 < 1f))
				{
					turnTableLoopPlayer.audioSource.pitch = _003CtargetVol_003E5__6;
					turnTableLoopPlayer.audioSource.time = _003CtargetPitch_003E5__7;
					object obj3 = turnTableLoopPlayer + 28;
					obj3 = 0;
					return null;
				}
				nint num9 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S3_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num10 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S3_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float pitch = Mathf.LerpUnclamped(_003CstartFadeVol_003E5__3, _003CtargetVol_003E5__6, _003Ccounter_003E5__2);
				turnTableLoopPlayer.audioSource.pitch = pitch;
				float time = Mathf.LerpUnclamped(_003CstartFadePitch_003E5__4, _003CtargetPitch_003E5__7, _003Ccounter_003E5__2);
				turnTableLoopPlayer.audioSource.time = time;
				float unscaledTime = Time.unscaledTime;
				float num11 = unscaledTime * _003CfadeSpeed_003E5__5;
				float num12 = _003Ccounter_003E5__2 + num11;
				_003Ccounter_003E5__2 = num12;
				object obj5 = this + 12;
				obj5 = 0;
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

	private sealed class _003CStopLooper_003Ed__9(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public TurnTableLoopPlayer _003C_003E4__this;

		public AudioLoopInfo audioLoopInfo;

		private float _003Ccounter_003E5__2;

		private float _003CstartFadeVol_003E5__3;

		private float _003CstartFadePitch_003E5__4;

		private float _003CfadeSpeed_003E5__5;

		private float _003CtargetVol_003E5__6;

		private float _003CtargetPitch_003E5__7;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_007d: Expected Obj, but got I
				//IL_0099: Expected Obj, but got I
				//IL_00bd: Expected Obj, but got I
				//IL_0067: Expected I4, but got Obj
				//IL_0139: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Expected Obj, but got Unknown
				//IL_0150: Expected F4, but got Obj
				//IL_020e: Expected I, but got Obj
				//IL_0224: Expected Obj, but got I
				//IL_0368: Expected Obj, but got I
				//IL_01c9: Expected Obj, but got I
				//IL_01e0: Expected Obj, but got I
				//IL_02a3: Expected Obj, but got I
				//IL_024f: Expected I, but got Obj
				//IL_01f6: Expected Obj, but got I
				//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e8: Expected Obj, but got Unknown
				//IL_02f1: Expected Obj, but got I4
				//IL_0305: Expected Obj, but got I4
				TurnTableLoopPlayer turnTableLoopPlayer = _003C_003E4__this;
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
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (TurnTableLoopPlayer)+1C]");
					if ((nint)0 != 0)
					{
						turnTableLoopPlayer.useGUILayout = (byte)(int)"StartLooper" != 0;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (TurnTableLoopPlayer)+C]");
					((AudioSource)0).Stop();
					_003Ccounter_003E5__2 = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (TurnTableLoopPlayer)+C]");
					float pitch = ((AudioSource)0).pitch;
					_003CstartFadeVol_003E5__3 = pitch;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (TurnTableLoopPlayer)+C]");
					float time = ((AudioSource)0).time;
					_003CstartFadePitch_003E5__4 = time;
					AudioLoopInfo audioLoopInfo = this.audioLoopInfo;
					AudioLoopInfo audioLoopInfo2 = this.audioLoopInfo;
					float num = ScrollRect.RubberDelta(audioLoopInfo.minStopTime, audioLoopInfo2.maxStopTime);
					float num2 = 1f / num;
					_003CfadeSpeed_003E5__5 = num2;
					_003CtargetVol_003E5__6 = 0f;
					AudioLoopInfo audioLoopInfo3 = this.audioLoopInfo;
					object obj = this.audioLoopInfo - -64;
					float num3 = ScrollRect.RubberDelta(audioLoopInfo3.minStopPitch, (float)obj);
					_003CtargetPitch_003E5__7 = num3;
				}
				if (!(_003Ccounter_003E5__2 < 1f))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (TurnTableLoopPlayer)+C]");
					((AudioSource)0).pitch = _003CtargetVol_003E5__6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (TurnTableLoopPlayer)+C]");
					((AudioSource)0).time = _003CtargetPitch_003E5__7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (TurnTableLoopPlayer)+C]");
					((AudioSource)0).Pause();
					return null;
				}
				nint num4 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S3_v4 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S3_v12 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float pitch2 = Mathf.LerpUnclamped(_003CstartFadeVol_003E5__3, _003CtargetVol_003E5__6, _003Ccounter_003E5__2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (TurnTableLoopPlayer)+C]");
				((AudioSource)0).pitch = pitch2;
				float time2 = Mathf.LerpUnclamped(_003CstartFadePitch_003E5__4, _003CtargetPitch_003E5__7, _003Ccounter_003E5__2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (TurnTableLoopPlayer)+C]");
				((AudioSource)0).time = time2;
				float unscaledTime = Time.unscaledTime;
				float num6 = unscaledTime * _003CfadeSpeed_003E5__5;
				float num7 = _003Ccounter_003E5__2 + num6;
				_003Ccounter_003E5__2 = num7;
				object obj3 = this + 12;
				obj3 = 0;
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

	private AudioSource audioSource;

	private AudioSource rewardSource;

	public AudioLoopInfo audioLoopInfo;

	public AudioClipInfo audioRewardInfo;

	private Coroutine startRoutine;

	private void Awake()
	{
		CancelInvoke();
	}

	public void StartLoop()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected Obj, but got Unknown
		object obj = this + 12;
		string text = tag;
		AudioSource audioSource = ((GameObject)(object)text).AddComponent<AudioSource>();
		obj = audioSource;
		object obj2 = this + 16;
		string text2 = tag;
		AudioSource audioSource2 = ((GameObject)(object)text2).AddComponent<AudioSource>();
		obj2 = audioSource2;
	}

	public void StopLoop()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0054: Expected I4, but got Obj
		object obj = this + 28;
		IEnumerator routine = StopLooper(audioLoopInfo);
		Coroutine coroutine = StartCoroutine_Auto(routine);
		obj = coroutine;
		AudioClipInfo audioClipInfo = audioRewardInfo;
		rewardSource.loop = (byte)(int)audioClipInfo.Clip != 0;
		AudioClipInfo audioClipInfo2 = audioRewardInfo;
		AudioClipInfo audioClipInfo3 = audioRewardInfo;
		float time = ScrollRect.RubberDelta(audioClipInfo2.minPitch, audioClipInfo3.maxPitch);
		rewardSource.time = time;
		AudioClipInfo audioClipInfo4 = audioRewardInfo;
		AudioClipInfo audioClipInfo5 = audioRewardInfo;
		float pitch = ScrollRect.RubberDelta(audioClipInfo4.minVolume, audioClipInfo5.maxVolume);
		rewardSource.pitch = pitch;
		rewardSource.Stop();
	}

	private IEnumerator StartLooper(AudioLoopInfo audioLoopInfo)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = audioLoopInfo;
		return enumerator;
	}

	private IEnumerator StopLooper(AudioLoopInfo audioLoopInfo)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = audioLoopInfo;
		return enumerator;
	}

	public TurnTableLoopPlayer()
	{
		//IL_000c: Expected I4, but got Obj
		AnimationClip outfitBreatheOrNull = ((CharacterAssetsBundle)this).GetOutfitBreatheOrNull((int)audioLoopInfo);
		Coroutine coroutine = StartCoroutine_Auto((IEnumerator)(object)outfitBreatheOrNull);
	}
}
