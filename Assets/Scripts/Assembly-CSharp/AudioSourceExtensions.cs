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

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_0129;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				float volume = audioSource.volume;
				_003CstartingVolume_003E5__2 = volume;
			}
			float volume2 = audioSource.volume;
			if (!(volume2 > 0f))
			{
				Action action = onComplete;
				if (onComplete != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v59.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				goto IL_0129;
			}
			float volume3 = audioSource.volume;
			float deltaTime = Time.deltaTime;
			float num = deltaTime * _003CstartingVolume_003E5__2;
			float num2 = num / duration;
			float volume4 = volume3 - num2;
			audioSource.volume = volume4;
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
			IL_0129:
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

	public static IEnumerator fadeOut(AudioSource audioSource, float duration, Action onComplete)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
