using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;
using WordHunt;

namespace UI.Screens.PauseScreenInternal;

public class DailyChallengeRewardHelper : MonoBehaviour
{
	private Layout _rewardLayout;

	private UISprite _coinIcon;

	private UISprite _checkmark;

	private UILabel _rewardLabel;

	private GameObject _3BagsReward;

	private GameObject _6BagsReward;

	private GameObject _mysteryBoxReward;

	private GameObject _superMysteryBoxReward;

	public void Refresh()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0019: Expected Obj, but got I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		object obj = this - -64;
		obj = 1;
		object obj2 = this + 84;
		obj2 = string.Empty;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<HoverboardThemes.ThemeIdentifier> list = default;
		list._002Ector();
		object obj3 = this + 88;
		obj3 = list;
		_ = -1;
	}

	public DailyChallengeRewardHelper()
	{
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0377: Expected Obj, but got I4
		//IL_038b: Expected I, but got Obj
		//IL_03a1: Expected Obj, but got I
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected Obj, but got Unknown
		//IL_045a: Expected Obj, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_007e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I4
		//IL_00e2: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_0145: Expected Obj, but got I4
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected Obj, but got Unknown
		//IL_0198: Expected Obj, but got I4
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected Obj, but got Unknown
		//IL_03cc: Expected I, but got Obj
		//IL_03e2: Expected Obj, but got I
		//IL_0498: Expected I4, but got Obj
		//IL_02f5: Expected I, but got Obj
		//IL_0267: Expected I, but got Obj
		//IL_027d: Expected Obj, but got I
		//IL_041c: Expected I4, but got Obj
		//IL_02a8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v59 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = (string)(obj2 + 24);
		WordHuntManager instance = WordHuntManager.instance;
		string msg = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v9 (WordHunt.WordHuntManager)+C]");
		WordHuntManager.LogError(msg, (Object)0);
		obj = text;
		_ = text.m_stringLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object[] array = default;
		object obj4 = array + 20;
		obj4 = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v9 (WordHunt.WordHuntManager)+C]");
		string text2 = StringExtensions.Populate((string)0, array);
		_mysteryBoxReward.tag = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v9 (WordHunt.WordHuntManager)+C]");
		bool flag = (nint)0 == 2;
		_3BagsReward.tag = (string)flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v9 (WordHunt.WordHuntManager)+C]");
		bool flag2 = (nint)0 == 3;
		_6BagsReward.tag = (string)flag2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v9 (WordHunt.WordHuntManager)+C]");
		bool flag3 = (nint)0 > (nint)3;
		_superMysteryBoxReward.tag = (string)flag3;
		string text3 = _checkmark.tag;
		bool flag4 = instance._lastRawData != null;
		((GameObject)(object)text3).tag = (string)flag4;
		string text4 = _coinIcon.tag;
		object obj5 = obj2 + 12;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		bool flag5 = obj5 == null;
		((GameObject)(object)text4).tag = (string)flag5;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		if (obj2 != null)
		{
			text = (string)obj;
			string text5 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			text5.m_stringLength = 0;
			if ((nint)text == 1)
			{
				text = (string)obj;
				string text6 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				text6.m_stringLength = 0;
				if (text.m_stringLength == 0)
				{
					nint num3 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S1_v70 (Il2CppClass<Strings>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num4 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S1_v77 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text7 = Strings.GetDefault("DAILY_CHALLENGE_MYSTERY_BOX");
					_rewardLabel.fontSize = (int)text7;
					goto IL_0421;
				}
			}
			nint num5 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v54 (Il2CppClass<Strings>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v61 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text8 = Strings.GetDefault("DAILY_CHALLENGE_SUPER_MYSTERY_BOX_SHORT");
			_rewardLabel.fontSize = (int)text8;
		}
		else
		{
			object obj8 = obj + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			int fontSize = default;
			_rewardLabel.fontSize = fontSize;
		}
		goto IL_0421;
		IL_0421:
		((RewardForVideoButton)(object)_rewardLayout).Init((VideoButtonPayload)null);
	}
}
