using Cpp2ILInjected;
using Data.Save;
using TopRun;
using UI.Screens.RewardManagement;
using UnityEngine;

public class TopRunResultsButton : MonoBehaviour
{
	private UILabel _weekLabel;

	private UILabel _finishedLabel;

	private UILabel _buttonLabel;

	private void OnEnable()
	{
		//IL_000b: Expected Obj, but got F4
		_buttonLabel = (UILabel)1f;
		_ = -1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724B");
	}

	private void SetLabels()
	{
		OnClick();
	}

	private void OnClick()
	{
		//IL_00ca: Expected I, but got Obj
		//IL_00e0: Expected Obj, but got I
		//IL_011c: Expected Obj, but got I4
		//IL_0072: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0094: Expected I4, but got Obj
		//IL_00b6: Expected I4, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v18 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("TOPRUN_WEEK_TITLE");
		int lastWeekMedalWasShown = TopRunSave.lastWeekMedalWasShown;
		object obj2 = lastWeekMedalWasShown;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object[] args = default;
		string text = string.Format(format, args);
		_weekLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("TOPRUN_STATE_FINISHED");
		_finishedLabel.fontSize = (int)text2;
		string text3 = Strings.GetDefault("TOPRUN_BUTTON_GET_RESULT");
		_buttonLabel.fontSize = (int)text3;
	}

	private void SetBeatTopRunFriendsAwardProgression()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj != null)
		{
			nint num = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v11 (Il2CppClass<TopRunRewardHelper>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v31 (Il2CppClass<TopRunRewardHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CelebrationReward pendingReward = TopRunRewardHelper.GetPendingReward();
			if (pendingReward == null)
			{
				SDebug.LogFormat("Torunament is null or doesn't have a result. Please make sure this button is never shown unless tournament results are available.", null);
				return;
			}
			((TopRunResultsButton)null)._002Ector();
			nint num3 = (nint)typeof(TopRunRewardHelper);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v20 (Il2CppClass<TopRunRewardHelper>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(TopRunRewardHelper);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v25 (Il2CppClass<TopRunRewardHelper>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			TopRunRewardHelper.OverridePendingResults((IManager)null);
		}
		else
		{
			SDebug.LogFormat("TopRunManager is null. Please make sure this button is never shown unless maanger data is available.", null);
		}
	}

	public TopRunResultsButton()
	{
		//IL_003a: Expected Obj, but got I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected Obj, but got Unknown
		object obj = default;
		object obj2 = default;
		while ((nint)obj < (UserSave.hasMigratedPlayerInfo ? 1 : 0))
		{
			((NewMonoBehaviour)30)._002Ector();
			obj = obj2 + 1;
		}
	}
}
