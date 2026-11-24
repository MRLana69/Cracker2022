using Cpp2ILInjected;
using UnityEngine;

namespace UI.Leaderboard;

public class LeaderboardHeaderHelper : MonoBehaviour
{
	private UILabel _label;

	private UISprite _background;

	public void Setup(string text, Color backgroundColor)
	{
		//IL_0056: Invalid comparison between I and VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Leaderboard.LeaderboardHeaderHelper)+18]");
		if (0 != (nint)text)
		{
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Leaderboard.LeaderboardHeaderHelper)+1C]");
		if ((object)0 == (object)backgroundColor)
		{
		}
	}

	public LeaderboardHeaderHelper()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreens);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreens>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreens);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UIScreens>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 28;
		obj2 = UIScreens.POPUPS;
		object obj3 = this + 32;
		obj3 = UIScreens.SCREENS;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}
}
