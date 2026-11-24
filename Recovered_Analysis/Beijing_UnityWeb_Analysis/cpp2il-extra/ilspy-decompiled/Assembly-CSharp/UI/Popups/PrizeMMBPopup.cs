using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Screens;

namespace UI.Popups;

public class PrizeMMBPopup : UIScreen
{
	private UILabel _titleLabel;

	private UILabel _subtitleLabel;

	private Layout _subtitleLayout;

	private UILabel _rareLabel;

	private UILabel _keyLabel;

	private UILabel _scoreBoosterLabel;

	private UILabel _commonLabel;

	private UILabel _boardsLabel;

	private UILabel _coinsLabel;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public PrizeMMBPopup()
	{
		//IL_01c8: Expected I, but got Obj
		//IL_01de: Expected Obj, but got I
		//IL_0218: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_008f: Expected I4, but got Obj
		//IL_00ac: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		//IL_00d5: Expected I4, but got Obj
		//IL_00f7: Expected I4, but got Obj
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0122: Expected I4, but got Obj
		//IL_013f: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_0168: Expected I4, but got Obj
		//IL_0185: Expected Obj, but got I4
		//IL_019b: Expected Obj, but got I4
		//IL_01ae: Expected I4, but got Obj
		ShowIfInactive();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v37 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("PRIZE_POPUP_TITLE");
		_titleLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("PRIZE_POPUP_SUBTITLE_MMB");
		_subtitleLabel.fontSize = (int)text2;
		((RewardForVideoButton)(object)_subtitleLayout).Init((VideoButtonPayload)null);
		string text3 = Strings.GetDefault("PRIZE_POPUP_CATEGORY_RARE");
		_rareLabel.fontSize = (int)text3;
		string format = Strings.GetDefault("PRIZE_POPUP_REWARD_UP_TO_KEYS");
		int autoRunLength = ((FPSLog)2).autoRunLength;
		string text4 = string.Format(format, (object[])autoRunLength);
		_keyLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("PRIZE_POPUP_REWARD_SCORE_BOOSTER_SINGULAR");
		_scoreBoosterLabel.fontSize = (int)text5;
		object obj2 = this - -64;
		string text6 = Strings.GetDefault("PRIZE_POPUP_CATEGORY_COMMON");
		((UILabel)obj2).fontSize = (int)text6;
		string format2 = Strings.GetDefault("PRIZE_POPUP_REWARD_UP_TO_BOARDS");
		int autoRunLength2 = ((FPSLog)3).autoRunLength;
		string text7 = string.Format(format2, (object[])autoRunLength2);
		_boardsLabel.fontSize = (int)text7;
		string format3 = Strings.GetDefault("PRIZE_POPUP_REWARD_UP_TO_COINS");
		int autoRunLength3 = ((FPSLog)200).autoRunLength;
		string text8 = string.Format(format3, (object[])autoRunLength3);
		_coinsLabel.fontSize = (int)text8;
	}
}
