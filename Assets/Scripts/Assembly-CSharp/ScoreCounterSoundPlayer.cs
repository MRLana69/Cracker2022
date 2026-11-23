using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class ScoreCounterSoundPlayer : MonoBehaviour
{
	private sealed class _003CScoreSoundTimer_003Ed__8(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public ScoreCounterSoundPlayer _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state < 2)
			{
				ScoreCounterSoundPlayer scoreCounterSoundPlayer = _003C_003E4__this;
				_003C_003E1__state = -1;
				if (scoreCounterSoundPlayer.playScore)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @874");
					float pitch = default;
					scoreCounterSoundPlayer.scoreSource.pitch = pitch;
					scoreCounterSoundPlayer.scoreSource.Play();
					_ = scoreCounterSoundPlayer.stepDelay;
					object obj = default;
					_003C_003E2__current = obj;
					_003C_003E1__state = 1;
					return true;
				}
				scoreCounterSoundPlayer.scoreSource.pitch = 2f;
				scoreCounterSoundPlayer.scoreSource.Play();
			}
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

	public AudioClip scoreSound;

	public float volume = 0.3f;

	public float stepDelay;

	private float count;

	private AudioSource scoreSource;

	private bool playScore;

	private void Awake()
	{
		GameObject gameObject = base.gameObject;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		scoreSource = audioSource;
		scoreSource.volume = volume;
		scoreSource.clip = scoreSound;
		scoreSource.playOnAwake = false;
		scoreSource.spatialBlend = 0f;
	}

	public void PlayCoinSound(float countFactor)
	{
		if (Settings.optionSfx)
		{
			count = countFactor;
			if (!playScore)
			{
				playScore = true;
				IEnumerator routine = ScoreSoundTimer();
				Coroutine coroutine = StartCoroutine(routine);
			}
		}
	}

	private IEnumerator ScoreSoundTimer()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	public void StopScoreSound()
	{
		playScore = false;
	}
}
