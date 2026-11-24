using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo.Common.Ads;
using Missions;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

namespace UI.SlideIns;

public class UISlideInMissionSetHelper : UISlideIn
{
	private UILabel line1;

	private UILabel lineReward;

	private UISprite superMysteryBox;

	private UISprite mysteryBox;

	private UISprite coinIcon;

	private UILabel coinLabel;

	private Layout _layout;

	private Layout _coinLayout;

	private int _missionsInStoryLineSet;

	private void Awake()
	{
		((UISlideInAdsRemoved)this)._002Ector();
	}

	public override void SetupSlideIn(SlideIn slideIn)
	{
		//IL_00cf: Expected Obj, but got I4
		//IL_00e3: Expected I4, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_0103: Expected I4, but got Obj
		//IL_005f: Expected I, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		line1.fontSize = (int)slideIn.stringValue;
		object obj = this - -64;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v8 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v18 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("SLIDE_IN_MISSION_LINE_2");
		((UILabel)obj).fontSize = (int)text2;
		((RewardForVideoButton)(object)superMysteryBox).Init((VideoButtonPayload)null);
		((RewardForVideoButton)(object)mysteryBox).Init((VideoButtonPayload)null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}

	public void NewCoinAmount(int coinAmount)
	{
		//IL_0306: Expected Obj, but got I4
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Obj, but got Unknown
		//IL_0043: Expected Obj, but got I4
		//IL_0051: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I
		//IL_033d: Expected I4, but got Obj
		//IL_0092: Expected I, but got Obj
		//IL_02c0: Expected Obj, but got I4
		//IL_02e9: Expected Obj, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0131: Expected Obj, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected Obj, but got Unknown
		//IL_014a: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_037e: Expected Obj, but got I4
		//IL_0113: Expected Obj, but got I4
		//IL_01d7: Expected I4, but got Obj
		//IL_018b: Expected I, but got Obj
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_03bc: Expected I4, but got Obj
		//IL_022b: Expected I, but got Obj
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		object obj = this - -64;
		((Component)obj).tag = null;
		superMysteryBox.tag = null;
		mysteryBox.tag = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [coinAmount @ L1 (System.Int32)+8]");
		bool flag = (nint)0 == 5;
		((UISlideInOfferPayoutHelper)this).SetupSlideIn((SlideIn)flag);
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v13 (Il2CppClass<Strings>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v66 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Strings.GetDefault("DAILY_CHALLENGE_COMPLETE");
		line1.fontSize = (int)text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [coinAmount @ L1 (System.Int32)+8]");
		if ((nint)0 == 2)
		{
			int missionsVersion = PlayerSave.missionsVersion;
			if (missionsVersion > _missionsInStoryLineSet)
			{
				superMysteryBox.tag = (string)1;
			}
			else
			{
				object obj3 = this - -64;
				((Component)obj3).tag = (string)1;
				object obj4 = this - -64;
				nint num3 = (nint)typeof(ScoreMultiplierInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v50 (Il2CppClass<Info.ScoreMultiplierInfo>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num4 = (nint)typeof(ScoreMultiplierInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v61 (Il2CppClass<Info.ScoreMultiplierInfo>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool allowSellConsumablesDuringRun = SellConsumable.allowSellConsumablesDuringRun;
				object obj6 = allowSellConsumablesDuringRun;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				string text4 = default;
				string text3 = "x" + text4;
				((UILabel)obj4).fontSize = (int)text3;
			}
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S1_v35 (Il2CppClass<Strings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v42 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text5 = Strings.GetDefault("MISSION_SET_COMPLETE");
			line1.fontSize = (int)text5;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [coinAmount @ L1 (System.Int32)+8]");
			if ((nint)0 == 4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [coinAmount @ L1 (System.Int32)+20]");
				bool flag2 = (nint)0 == 1;
				superMysteryBox.tag = (string)flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [coinAmount @ L1 (System.Int32)+20]");
				bool flag3 = (nint)0 != 1;
				mysteryBox.tag = (string)flag3;
			}
		}
		((RewardForVideoButton)(object)_layout).Init((VideoButtonPayload)null);
		((UISlideInAdsRemoved)this).SetupSlideIn((SlideIn)null);
	}

	private void NewCoinAmount(string coinAmount)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		bool enable = default;
		EnableCoinLabel(enable);
	}

	private void EnableCoinLabel(bool enable)
	{
		//IL_0018: Expected Obj, but got I4
		string text = tag;
		((GameObject)(object)text).tag = (string)1;
		coinLabel.fontSize = (enable ? 1 : 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		string text2 = tag;
		((GameObject)(object)text2).tag = null;
	}

	public UISlideInMissionSetHelper()
	{
		//IL_0012: Expected I4, but got Obj
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected I4, but got Unknown
		StayInOneLaneMission instance = StayInOneLaneMission.instance;
		AdLocationInfo currentLocationInfo = MissionsManager.GetCurrentLocationInfo((byte)(int)instance != 0);
		int missionsInStoryLineSet = currentLocationInfo + 1;
		_missionsInStoryLineSet = missionsInStoryLineSet;
	}
}
