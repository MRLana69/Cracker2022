using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class BragCelebrationHandler : MonoBehaviour
{
	public enum State
	{
		NotCalculated,
		BeatenOnlySelf,
		BeatenFriendsOnlyGcOnline,
		BeatenFriendsOnlineAll
	}

	private sealed class _003CUpdateUI_003Ed__7(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public BragCelebrationHandler _003C_003E4__this;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private unsafe bool MoveNext()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected I4, but got Unknown
			//IL_00bf: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 - 16;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					BragCelebrationHandler bragCelebrationHandler = _003C_003E4__this;
					_003C_003E1__state = -1;
					TMP_Text highScoreLabel = bragCelebrationHandler._highScoreLabel;
					PlayerInfo instance = PlayerInfo.Instance;
					_ = instance._highScore;
					int num = obj + 12;
					string text = ((int*)num)->ToString();
					nint num2 = (nint)highScoreLabel;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v83 @ S2_v5 (Il2CppClass<TMPro.TMP_Text>)+2CC] (should have been resolved before IL gen)");
					bragCelebrationHandler._highScoreLabel.alpha = 1f;
					bragCelebrationHandler._newHighScoreTopTitle.alpha = 1f;
					if (bragCelebrationHandler._socialState == State.NotCalculated)
					{
						bragCelebrationHandler._socialState = State.BeatenOnlySelf;
					}
				}
			}
			else
			{
				_003C_003E1__state = -1;
				_ = 1f;
				object obj3 = default;
				_003C_003E2__current = obj3;
				_003C_003E1__state = 1;
			}
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

	private TMP_Text _newHighScoreTopTitle;

	private TMP_Text _highScoreLabel;

	private State _socialState;

	public State state
	{
		get
		{
			State socialState = _socialState;
			if (_socialState == State.NotCalculated)
			{
				_socialState = State.BeatenOnlySelf;
				socialState = _socialState;
			}
			return socialState;
		}
	}

	private void OnEnable()
	{
		_newHighScoreTopTitle.alpha = 0f;
		_highScoreLabel.alpha = 0f;
		IEnumerator routine = UpdateUI();
		Coroutine coroutine = StartCoroutine(routine);
	}

	private IEnumerator UpdateUI()
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private void CalculateState()
	{
		_socialState = State.BeatenOnlySelf;
	}
}
