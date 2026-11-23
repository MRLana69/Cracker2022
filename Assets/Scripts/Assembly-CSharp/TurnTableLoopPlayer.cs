using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

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

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Expected Obj, but got Unknown
			//IL_00b8: Expected Obj, but got I
			TurnTableLoopPlayer turnTableLoopPlayer = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_02ad;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				AudioLoopInfo audioLoopInfo = this.audioLoopInfo;
				AudioClip[] clips = audioLoopInfo.clips;
				int num = UnityEngine.Random.Range(0, clips.Length);
				int num2 = num << 2;
				object obj = clips + num2;
				AudioSource audioSource = turnTableLoopPlayer.audioSource;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v26+10]");
				audioSource.clip = (AudioClip)0;
				turnTableLoopPlayer.audioSource.loop = true;
				turnTableLoopPlayer.audioSource.Play();
				_003Ccounter_003E5__2 = 0f;
				AudioLoopInfo audioLoopInfo2 = this.audioLoopInfo;
				float num3 = UnityEngine.Random.Range(audioLoopInfo2.minStartVolume, audioLoopInfo2.maxStartVolume);
				_003CstartFadeVol_003E5__3 = num3;
				AudioLoopInfo audioLoopInfo3 = this.audioLoopInfo;
				float num4 = UnityEngine.Random.Range(audioLoopInfo3.minStartPitch, audioLoopInfo3.maxStartPitch);
				_003CstartFadePitch_003E5__4 = num4;
				AudioLoopInfo audioLoopInfo4 = this.audioLoopInfo;
				float num5 = UnityEngine.Random.Range(audioLoopInfo4.minStartTime, audioLoopInfo4.maxStartTime);
				float num6 = 1f / num5;
				_003CfadeSpeed_003E5__5 = num6;
				AudioLoopInfo audioLoopInfo5 = this.audioLoopInfo;
				float num7 = UnityEngine.Random.Range(audioLoopInfo5.minTargetVolume, audioLoopInfo5.maxTargatVolume);
				_003CtargetVol_003E5__6 = num7;
				AudioLoopInfo audioLoopInfo6 = this.audioLoopInfo;
				float num8 = UnityEngine.Random.Range(audioLoopInfo6.minTargetPitch, audioLoopInfo6.maxTargetPitch);
				_003CtargetPitch_003E5__7 = num8;
			}
			if (!(_003Ccounter_003E5__2 < 1f))
			{
				turnTableLoopPlayer.audioSource.volume = _003CtargetVol_003E5__6;
				turnTableLoopPlayer.audioSource.pitch = _003CtargetPitch_003E5__7;
				turnTableLoopPlayer.startRoutine = null;
				goto IL_02ad;
			}
			float num9 = _003CtargetVol_003E5__6 - _003CstartFadeVol_003E5__3;
			float num10 = Math.Min(_003Ccounter_003E5__2, 1f);
			bool flag = _003Ccounter_003E5__2 < 0f;
			float num11 = 0f;
			if (!flag)
			{
				num11 = num10;
			}
			float num12 = num9 * num11;
			float volume = _003CstartFadeVol_003E5__3 + num12;
			turnTableLoopPlayer.audioSource.volume = volume;
			float num13 = _003CtargetPitch_003E5__7 - _003CstartFadePitch_003E5__4;
			float num14 = Math.Min(_003Ccounter_003E5__2, 1f);
			bool flag2 = _003Ccounter_003E5__2 < 0f;
			float num15 = 0f;
			if (!flag2)
			{
				num15 = num14;
			}
			float num16 = num13 * num15;
			float pitch = _003CstartFadePitch_003E5__4 + num16;
			turnTableLoopPlayer.audioSource.pitch = pitch;
			float deltaTime = Time.deltaTime;
			float num17 = deltaTime * _003CfadeSpeed_003E5__5;
			float num18 = _003Ccounter_003E5__2 + num17;
			_003C_003E2__current = null;
			_003Ccounter_003E5__2 = num18;
			_003C_003E1__state = 1;
			return true;
			IL_02ad:
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

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_007d: Expected Obj, but got I
			//IL_0099: Expected Obj, but got I
			//IL_00bd: Expected Obj, but got I
			//IL_0293: Expected Obj, but got I
			//IL_0175: Expected Obj, but got I
			//IL_018c: Expected Obj, but got I
			//IL_0317: Expected Obj, but got I
			//IL_01a2: Expected Obj, but got I
			TurnTableLoopPlayer turnTableLoopPlayer = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_01a7;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (TurnTableLoopPlayer)+1C]");
				if ((nint)0 != 0)
				{
					turnTableLoopPlayer.StopCoroutine("StartLooper");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (TurnTableLoopPlayer)+C]");
				((AudioSource)0).Play();
				_003Ccounter_003E5__2 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (TurnTableLoopPlayer)+C]");
				float volume = ((AudioSource)0).volume;
				_003CstartFadeVol_003E5__3 = volume;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (TurnTableLoopPlayer)+C]");
				float pitch = ((AudioSource)0).pitch;
				_003CstartFadePitch_003E5__4 = pitch;
				AudioLoopInfo audioLoopInfo = this.audioLoopInfo;
				float num = UnityEngine.Random.Range(audioLoopInfo.minStopTime, audioLoopInfo.maxStopTime);
				_003CtargetVol_003E5__6 = 0f;
				float num2 = 1f / num;
				_003CfadeSpeed_003E5__5 = num2;
				AudioLoopInfo audioLoopInfo2 = this.audioLoopInfo;
				float num3 = UnityEngine.Random.Range(audioLoopInfo2.minStopPitch, audioLoopInfo2.maxStopPitch);
				_003CtargetPitch_003E5__7 = num3;
			}
			if (!(_003Ccounter_003E5__2 < 1f))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (TurnTableLoopPlayer)+C]");
				((AudioSource)0).volume = _003CtargetVol_003E5__6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (TurnTableLoopPlayer)+C]");
				((AudioSource)0).pitch = _003CtargetPitch_003E5__7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (TurnTableLoopPlayer)+C]");
				((AudioSource)0).Stop();
				goto IL_01a7;
			}
			float num4 = _003CtargetVol_003E5__6 - _003CstartFadeVol_003E5__3;
			float num5 = Math.Min(_003Ccounter_003E5__2, 1f);
			bool flag = _003Ccounter_003E5__2 < 0f;
			float num6 = 0f;
			if (!flag)
			{
				num6 = num5;
			}
			float num7 = num4 * num6;
			float volume2 = _003CstartFadeVol_003E5__3 + num7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (TurnTableLoopPlayer)+C]");
			((AudioSource)0).volume = volume2;
			float num8 = _003CtargetPitch_003E5__7 - _003CstartFadePitch_003E5__4;
			float num9 = Math.Min(_003Ccounter_003E5__2, 1f);
			bool flag2 = _003Ccounter_003E5__2 < 0f;
			float num10 = 0f;
			if (!flag2)
			{
				num10 = num9;
			}
			float num11 = num8 * num10;
			float pitch2 = _003CstartFadePitch_003E5__4 + num11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (TurnTableLoopPlayer)+C]");
			((AudioSource)0).pitch = pitch2;
			float deltaTime = Time.deltaTime;
			float num12 = deltaTime * _003CfadeSpeed_003E5__5;
			float num13 = _003Ccounter_003E5__2 + num12;
			_003C_003E2__current = null;
			_003Ccounter_003E5__2 = num13;
			_003C_003E1__state = 1;
			return true;
			IL_01a7:
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

	private AudioSource audioSource;

	private AudioSource rewardSource;

	public AudioLoopInfo audioLoopInfo;

	public AudioClipInfo audioRewardInfo;

	private Coroutine startRoutine;

	private void Awake()
	{
		GameObject gameObject = base.gameObject;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		this.audioSource = audioSource;
		GameObject gameObject2 = base.gameObject;
		AudioSource audioSource2 = gameObject2.AddComponent<AudioSource>();
		rewardSource = audioSource2;
	}

	public void StartLoop()
	{
		IEnumerator routine = StartLooper(audioLoopInfo);
		Coroutine coroutine = StartCoroutine(routine);
		startRoutine = coroutine;
		AudioClipInfo audioClipInfo = audioRewardInfo;
		rewardSource.clip = audioClipInfo.Clip;
		AudioClipInfo audioClipInfo2 = audioRewardInfo;
		float pitch = UnityEngine.Random.Range(audioClipInfo2.minPitch, audioClipInfo2.maxPitch);
		rewardSource.pitch = pitch;
		AudioClipInfo audioClipInfo3 = audioRewardInfo;
		float volume = UnityEngine.Random.Range(audioClipInfo3.minVolume, audioClipInfo3.maxVolume);
		rewardSource.volume = volume;
		rewardSource.Play();
	}

	public void StopLoop()
	{
		IEnumerator routine = StopLooper(audioLoopInfo);
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator StartLooper(AudioLoopInfo audioLoopInfo)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private IEnumerator StopLooper(AudioLoopInfo audioLoopInfo)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
