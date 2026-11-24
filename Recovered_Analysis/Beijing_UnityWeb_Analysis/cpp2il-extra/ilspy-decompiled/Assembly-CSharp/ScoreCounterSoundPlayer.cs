using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class ScoreCounterSoundPlayer : MonoBehaviour
{
	private sealed class _003CScoreSoundTimer_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScoreCounterSoundPlayer _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00ad: Expected I, but got Obj
				//IL_00c3: Expected Obj, but got I
				//IL_0147: Unknown result type (might be due to invalid IL or missing references)
				//IL_014c: Expected Obj, but got Unknown
				//IL_0168: Expected Obj, but got I4
				//IL_00ee: Expected I, but got Obj
				ScoreCounterSoundPlayer scoreCounterSoundPlayer = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				if (~(scoreCounterSoundPlayer.playScore ? 1u : 0u) != 0)
				{
					scoreCounterSoundPlayer.scoreSource.time = 2f;
					scoreCounterSoundPlayer.scoreSource.Stop();
					return null;
				}
				nint num = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v19 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v35 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AE");
				float time = default;
				scoreCounterSoundPlayer.scoreSource.time = time;
				scoreCounterSoundPlayer.scoreSource.Stop();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = scoreCounterSoundPlayer.stepDelay;
				object obj2 = this + 12;
				object obj3 = default;
				obj2 = obj3;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CScoreSoundTimer_003Ed__8(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

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

	public AudioClip scoreSound;

	public float volume;

	public float stepDelay;

	private float count;

	private AudioSource scoreSource;

	private bool playScore = false;

	private void Awake()
	{
		volume = 500f;
		stepDelay = -100f;
		CancelInvoke();
	}

	public void PlayCoinSound(float countFactor)
	{
		//IL_0008: Expected Obj, but got F4
		//IL_0041: Expected I4, but got Obj
		object obj = countFactor;
		if ((object)scoreSound != null)
		{
			OverflowException indentifier = new OverflowException();
			PokiUnitySDK.JS_PokiSDK_destroyAd((string)(object)indentifier);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			PokiUnitySDK pokiUnitySDK = default;
			pokiUnitySDK.isShowingAd = (byte)(int)"PokiUnitySDK is not yet initialized, make sure you call PokiUnitySDK.Instance.Init() first" != 0;
			pokiUnitySDK.happyTime(0f);
		}
	}

	private unsafe IEnumerator ScoreSoundTimer()
	{
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_018c: Expected I4, but got Obj
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01b4: Expected Obj, but got I4
		//IL_0038: Expected native int or pointer, but got F4
		//IL_0042: Expected Obj, but got F4
		//IL_0054: Expected I, but got Obj
		//IL_006a: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I4
		//IL_0095: Expected I, but got Obj
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected Obj, but got Unknown
		while (true)
		{
			object obj = scoreSound + 16;
			AudioClip audioClip = scoreSound;
			int num = UnityEngine.Random.RandomRangeInt(0, (int)audioClip.m_PCMReaderCallback);
			int num2 = num << 2;
			object obj2 = obj + num2;
			object obj3 = 0;
			while (true)
			{
				float num3 = count;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v8 (System.Single)+C]");
				if ((nint)obj4 < 0)
				{
					float num4 = count + 16f;
					object obj5 = obj3 << 2;
					float num5 = num4 + (float)obj5;
					bool isPlaying = ((AudioSource)((float*)(nint)num5)->m_value).isPlaying;
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v22 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num7 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (!((UnityEngine.Object)obj2 != (UnityEngine.Object)isPlaying))
					{
						object obj7 = obj3 + 1;
						obj3 = obj7;
						continue;
					}
					break;
				}
				return (IEnumerator)obj2;
			}
		}
	}

	public void StopScoreSound()
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0016: Expected I4, but got Obj
		object obj = this + 28;
		string text = tag;
		AudioSource audioSource = ((GameObject)(object)text).AddComponent<AudioSource>();
		obj = audioSource;
		scoreSource.pitch = volume;
		scoreSource.loop = (byte)(int)scoreSound != 0;
		scoreSource.bypassEffects = false;
		scoreSource.minDistance = 0f;
	}
}
