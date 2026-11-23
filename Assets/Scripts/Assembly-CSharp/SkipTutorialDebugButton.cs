using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class SkipTutorialDebugButton : MonoBehaviour
{
	private sealed class _003CResetTapsOnTimeOut_003Ed__4(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SkipTutorialDebugButton _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					SkipTutorialDebugButton skipTutorialDebugButton = _003C_003E4__this;
					skipTutorialDebugButton._taps = 0;
				}
				return false;
			}
			_003C_003E1__state = -1;
			_ = 1f;
			object obj = default;
			_003C_003E2__current = obj;
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

	private const int NUMBER_OF_CLICKS_TO_OPEN = 2;

	private const int TIME_TO_DOUBLE_CLICK = 1;

	private int _taps;

	private void OnClick()
	{
	}

	private IEnumerator ResetTapsOnTimeOut()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}
}
