using System;
using Cpp2ILInjected;
using Kiloo;
using TopRun;
using UnityEngine;

public class UITopRunTimer : MonoBehaviour
{
	private UILabel _currentTopRunWeek;

	private UILabel _timerLabel;

	private string _prefix = string.Empty;

	private PauseScreen pauseScreen;

	private bool _lessThanAdayLeft;

	private int _totalSeconds = -1;

	private IManager _tournamentManager;

	private ITournament _currentTournament;

	public void DoTimer()
	{
		_tournamentManager = TopRunRoot.manager__BackingField;
		if (_tournamentManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj = default;
			if (obj != null)
			{
				SetTextTopRunTimerLabels();
			}
			else
			{
				pauseScreen.FetchingTopRunDataTimedOut();
			}
		}
		else
		{
			pauseScreen.FetchingTopRunDataTimedOut();
		}
	}

	private unsafe void SetTextTopRunTimerLabels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I8
		//IL_020a: Expected Obj, but got I8
		//IL_0179: Expected Obj, but got I8
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected I4, but got Unknown
		//IL_0257: Expected Obj, but got I8
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected I4, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected I4, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_tournamentManager != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
			object obj3 = default;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				ITournament currentTournament = default;
				_currentTournament = currentTournament;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
				DateTime utcNow = CDateTime.UtcNow;
				DateTime dateTime = default;
				TimeSpan timeSpan = dateTime - utcNow;
				DateTime utcNow2 = CDateTime.UtcNow;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
				DateTime dateTime2 = default;
				if (utcNow2 > dateTime2)
				{
					_lessThanAdayLeft = false;
					string text = Strings.Get(StringID.TOPRUN_STATE_NEXT_SOON);
					_timerLabel.text = text;
					_timerLabel.fontSize = 15;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					object obj4 = 0 / 864000000000L;
					if ((nint)obj4 >= 2)
					{
						_lessThanAdayLeft = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						object obj5 = 0 / 864000000000L;
						int num = obj + 4;
						string text2 = ((int*)num)->ToString();
						string text3 = Strings.Get(StringID.TOPRUN_STATE_DAYS_LEFT);
						string text4 = text2 + " " + text3;
						_timerLabel.text = text4;
						_timerLabel.fontSize = 24;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
						object obj6 = 0 / 864000000000L;
						if ((nint)obj6 == 1)
						{
							_lessThanAdayLeft = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
							object obj7 = 0 / 864000000000L;
							int num2 = obj + 4;
							string text5 = ((int*)num2)->ToString();
							string text6 = Strings.Get(StringID.TOPRUN_STATE_DAYS_LEFT_SINGLE);
							string text7 = text5 + " " + text6;
							_timerLabel.text = text7;
							_timerLabel.fontSize = 24;
						}
						else
						{
							_timerLabel.fontSize = 24;
							_lessThanAdayLeft = true;
						}
					}
				}
				string text8 = Strings.Get(StringID.TOPRUN_STATE_WEEK);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22D");
				int num3 = obj + 4;
				string text9 = ((int*)num3)->ToString();
				string text10 = text8 + " " + text9;
				_currentTopRunWeek.text = text10;
				return;
			}
		}
		pauseScreen.FetchingTopRunDataTimedOut();
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ae: Expected F8, but got I4
		//IL_0319: Invalid comparison between F8 and I4
		//IL_00bd: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 - 32;
		if (~(_lessThanAdayLeft ? 1u : 0u) != 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A1");
		DateTime utcNow = CDateTime.UtcNow;
		DateTime dateTime = default;
		TimeSpan timeSpan = dateTime - utcNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		double num = 0.0 * 1E-07;
		double num2 = Math.Abs(num);
		if (!(num2 < 2147483648.0))
		{
			num = -2147483648.0;
		}
		if (num != (double)_totalSeconds)
		{
			_totalSeconds = (int)num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
			if ((nint)0 >= (nint)1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
			_lessThanAdayLeft = false;
			string text = Strings.Get(StringID.TOPRUN_STATE_NEXT_SOON);
			_timerLabel.text = text;
			_timerLabel.fontSize = 15;
		}
	}
}
