using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class DynamicBgMusic : MonoBehaviour
{
	private sealed class _003CLoopFader_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public DynamicBgMusic _003C_003E4__this;

		public int audioSourceID;

		private float _003Ccounter2_003E5__2;

		private float _003CstartFade2_003E5__3;

		private float _003CfadeSpeed2_003E5__4;

		private float _003CtargetVolume2_003E5__5;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected Obj, but got Unknown
			//IL_00d5: Expected Obj, but got I
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected Obj, but got Unknown
			//IL_0123: Expected Obj, but got I
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Expected Obj, but got Unknown
			//IL_015b: Expected Obj, but got I
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Expected Obj, but got Unknown
			//IL_0199: Expected Obj, but got I
			//IL_0458: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Expected Obj, but got Unknown
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Expected Obj, but got Unknown
			//IL_02df: Expected Obj, but got I
			//IL_05ff: Expected Obj, but got I
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Expected Obj, but got Unknown
			//IL_0259: Expected Obj, but got I
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03df: Expected Obj, but got Unknown
			//IL_0580: Expected Obj, but got I
			//IL_0364: Unknown result type (might be due to invalid IL or missing references)
			//IL_0369: Expected Obj, but got Unknown
			//IL_0380: Expected Obj, but got I
			DynamicBgMusic dynamicBgMusic = _003C_003E4__this;
			if (_003C_003E1__state == 0)
			{
				goto IL_0086;
			}
			int num6;
			if (_003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 2)
				{
					if (_003C_003E1__state != 3)
					{
						if (_003C_003E1__state == 4)
						{
							goto IL_0086;
						}
						goto IL_04e2;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003Ccounter2_003E5__2 = 0f;
					_003C_003E1__state = -1;
					int num = audioSourceID << 2;
					object obj = dynamicBgMusic.audioSources + num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S2_v79+10]");
					float volume = ((AudioSource)0).volume;
					_003CstartFade2_003E5__3 = volume;
					float num2 = UnityEngine.Random.Range(dynamicBgMusic.minFadeTime, dynamicBgMusic.maxFadeTime);
					_003CtargetVolume2_003E5__5 = 0f;
					float num3 = 1f / num2;
					_003CfadeSpeed2_003E5__4 = num3;
				}
				if (!(_003Ccounter2_003E5__2 < 1f))
				{
					int num4 = audioSourceID << 2;
					object obj2 = dynamicBgMusic.audioSources + num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v67+10]");
					((AudioSource)0).volume = _003CtargetVolume2_003E5__5;
					float num5 = UnityEngine.Random.Range(dynamicBgMusic.minPauseTime, dynamicBgMusic.maxPauseTime);
					object obj3 = default;
					_003C_003E2__current = obj3;
					num6 = 4;
				}
				else
				{
					int num7 = audioSourceID << 2;
					object obj4 = dynamicBgMusic.audioSources + num7;
					float num8 = _003CtargetVolume2_003E5__5 - _003CstartFade2_003E5__3;
					float num9 = Math.Min(_003Ccounter2_003E5__2, 1f);
					bool flag = _003Ccounter2_003E5__2 < 0f;
					float num10 = 0f;
					if (!flag)
					{
						num10 = num9;
					}
					float num11 = num8 * num10;
					float volume2 = _003CstartFade2_003E5__3 + num11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S1_v57+10]");
					((AudioSource)0).volume = volume2;
					float deltaTime = Time.deltaTime;
					float num12 = deltaTime * _003CfadeSpeed2_003E5__4;
					float num13 = _003Ccounter2_003E5__2 + num12;
					_003C_003E2__current = null;
					_003Ccounter2_003E5__2 = num13;
					num6 = 3;
				}
				goto IL_0507;
			}
			_003C_003E1__state = -1;
			goto IL_04e8;
			IL_04e2:
			return true;
			IL_04e8:
			if (!(_003Ccounter2_003E5__2 < 1f))
			{
				int num14 = audioSourceID << 2;
				object obj5 = dynamicBgMusic.audioSources + num14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v21+10]");
				((AudioSource)0).volume = _003CtargetVolume2_003E5__5;
				float num15 = UnityEngine.Random.Range(dynamicBgMusic.minPlayingTime, dynamicBgMusic.maxPlayingTime);
				object obj6 = default;
				_003C_003E2__current = obj6;
				num6 = 2;
			}
			else
			{
				int num16 = audioSourceID << 2;
				object obj7 = dynamicBgMusic.audioSources + num16;
				float num17 = _003CtargetVolume2_003E5__5 - _003CstartFade2_003E5__3;
				float num18 = Math.Min(_003Ccounter2_003E5__2, 1f);
				bool flag2 = _003Ccounter2_003E5__2 < 0f;
				float num19 = 0f;
				if (!flag2)
				{
					num19 = num18;
				}
				float num20 = num17 * num19;
				float volume3 = _003CstartFade2_003E5__3 + num20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v11+10]");
				((AudioSource)0).volume = volume3;
				float deltaTime2 = Time.deltaTime;
				float num21 = deltaTime2 * _003CfadeSpeed2_003E5__4;
				float num22 = _003Ccounter2_003E5__2 + num21;
				_003C_003E2__current = null;
				_003Ccounter2_003E5__2 = num22;
				num6 = 1;
			}
			goto IL_0507;
			IL_0086:
			_003C_003E1__state = -1;
			int num23 = audioSourceID << 2;
			object obj8 = dynamicBgMusic.audioSources + num23;
			AudioClip clip = dynamicBgMusic.FindNotYetPlayingLoop();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v35+10]");
			((AudioSource)0).clip = clip;
			int num24 = audioSourceID << 2;
			object obj9 = dynamicBgMusic.audioSources + num24;
			float time = dynamicBgMusic.masterSource.time;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v39+10]");
			((AudioSource)0).time = time;
			int num25 = audioSourceID << 2;
			object obj10 = dynamicBgMusic.audioSources + num25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v43+10]");
			((AudioSource)0).Play();
			_003Ccounter2_003E5__2 = 0f;
			int num26 = audioSourceID << 2;
			object obj11 = dynamicBgMusic.audioSources + num26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S2_v44+10]");
			float volume4 = ((AudioSource)0).volume;
			_003CstartFade2_003E5__3 = volume4;
			float num27 = UnityEngine.Random.Range(dynamicBgMusic.minFadeTime, dynamicBgMusic.maxFadeTime);
			float num28 = 1f / num27;
			_003CfadeSpeed2_003E5__4 = num28;
			float num29 = UnityEngine.Random.Range(dynamicBgMusic.minPlayingVolume, dynamicBgMusic.maxPlayingVolume);
			_003CtargetVolume2_003E5__5 = num29;
			goto IL_04e8;
			IL_0507:
			_003C_003E1__state = num6;
			goto IL_04e2;
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
		//IL_0040: Expected Obj, but got I4
		//IL_01ab: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I4
		GameObject gameObject = base.gameObject;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		masterSource = audioSource;
		masterSource.loop = true;
		masterSource.clip = masterClip;
		masterSource.volume = masterSourceVolume;
		masterSource.Play();
		object obj = 0;
		AudioSource[] array = audioSources;
		if (array.Length > (nint)obj)
		{
			GameObject gameObject2 = base.gameObject;
			AudioSource audioSource2 = gameObject2.AddComponent<AudioSource>();
			throw new ArrayTypeMismatchException();
		}
		object obj2 = array.Length;
		int num = 0;
		while (num < (nint)obj2)
		{
			IEnumerator routine = LoopFader(num);
			Coroutine coroutine = StartCoroutine(routine);
			int num2 = num + 1;
			AudioSource[] array2 = audioSources;
			obj2 = array2.Length;
			num = num2;
		}
	}

	private AudioClip FindNotYetPlayingLoop()
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected Obj, but got Unknown
		//IL_00cb: Expected Obj, but got I4
		//IL_0089: Expected Obj, but got I
		//IL_0031: Expected Obj, but got I
		//IL_004f: Expected Obj, but got I
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		while (true)
		{
			AudioClip[] array = audioClips;
			int num = UnityEngine.Random.Range(0, array.Length);
			int num2 = num << 2;
			object obj = array + num2;
			object obj2 = 0;
			while (true)
			{
				AudioSource[] array2 = audioSources;
				if (array2.Length > (nint)obj2)
				{
					object obj3 = obj2 << 2;
					object obj4 = (object)array2 + obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v18+10]");
					AudioClip clip = ((AudioSource)0).clip;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v9+10]");
					if ((UnityEngine.Object)0 == clip)
					{
						break;
					}
					object obj5 = obj2 + 1;
					obj2 = obj5;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v9+10]");
				return (AudioClip)0;
			}
		}
	}

	private IEnumerator LoopFader(int audioSourceID)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public DynamicBgMusic()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		AudioSource[] array = default;
		audioSources = array;
		maxPlayingVolume = 0.6f;
		maxPauseTime = 4f;
		minPlayingTime = 4f;
		minFadeTime = 8f;
		base._002Ector();
	}
}
