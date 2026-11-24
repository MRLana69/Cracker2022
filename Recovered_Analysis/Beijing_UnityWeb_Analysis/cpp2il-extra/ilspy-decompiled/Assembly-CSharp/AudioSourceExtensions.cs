using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public static class AudioSourceExtensions
{
	private sealed class _003CfadeOut_003Ed__0(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AudioSource audioSource;

		public float duration;

		public Action onComplete;

		private float _003CstartingVolume_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0125: Expected Obj, but got Unknown
				//IL_012e: Expected Obj, but got I4
				//IL_0142: Expected Obj, but got I4
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
					float pitch = audioSource.pitch;
					_003CstartingVolume_003E5__2 = pitch;
				}
				float pitch2 = audioSource.pitch;
				if (pitch2 > 0f)
				{
					float pitch3 = audioSource.pitch;
					float unscaledTime = Time.unscaledTime;
					float num = unscaledTime * _003CstartingVolume_003E5__2;
					float num2 = num / duration;
					float pitch4 = pitch3 - num2;
					audioSource.pitch = pitch4;
					object obj = this + 12;
					obj = 0;
					_003C_003E1__state = 1;
					return 1;
				}
				if (onComplete != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
				}
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

	public static IEnumerator fadeOut(AudioSource audioSource, float duration, Action onComplete)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return null;
	}
}
