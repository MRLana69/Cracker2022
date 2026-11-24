using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.ModelCamera;
using UnityEngine;
using WordHunt;

namespace UI.Pages.DailyChallengePageInternal;

public class RegularDayHelper : DayHelper
{
	private UILabel _dayLabel;

	private UILabel _rewardLabel;

	private UISprite _checkMark;

	private UISprite _divider;

	private UISprite _backgroundActive;

	private Color _activeDayLabelColor;

	private Color _inactiveDayLabelColor;

	private UISprite _rewardCoinIcon;

	private Layout _rewardLayout;

	private GameObject[] _rewards;

	private int _dayIndex;

	public unsafe void SetIndex(int index)
	{
		//IL_05c2: Expected I, but got Obj
		//IL_05d8: Expected Obj, but got I
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected I4, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected Obj, but got Unknown
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected Obj, but got Unknown
		//IL_08f1: Expected I4, but got Obj
		//IL_08ff: Expected I, but got Obj
		//IL_0915: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_06e6: Expected I4, but got Obj
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected Obj, but got Unknown
		//IL_0713: Expected I4, but got Obj
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected Obj, but got Unknown
		//IL_02da: Expected I4, but got Obj
		//IL_02f0: Expected Obj, but got I4
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Expected Obj, but got Unknown
		//IL_0321: Expected I4, but got Obj
		//IL_026e: Expected I, but got Obj
		//IL_0612: Expected I4, but got Obj
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected Obj, but got Unknown
		//IL_063f: Expected I4, but got Obj
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		//IL_036f: Expected I4, but got Obj
		//IL_0385: Expected Obj, but got I4
		//IL_0397: Expected I, but got Obj
		//IL_03ad: Expected Obj, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected Obj, but got Unknown
		//IL_00f0: Expected I4, but got Obj
		//IL_0106: Expected Obj, but got I4
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected Obj, but got Unknown
		//IL_0137: Expected I4, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_074b: Expected Obj, but got I4
		//IL_076d: Expected I4, but got Obj
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_0185: Expected I4, but got Obj
		//IL_019b: Expected Obj, but got I4
		//IL_01ad: Expected I, but got Obj
		//IL_01c3: Expected Obj, but got I
		//IL_043e: Expected Obj, but got I4
		//IL_03d8: Expected I, but got Obj
		//IL_0677: Expected Obj, but got I4
		//IL_0699: Expected I4, but got Obj
		//IL_0459: Expected Obj, but got I
		//IL_0462: Expected Obj, but got I4
		//IL_01ee: Expected I, but got Obj
		//IL_0534: Expected I, but got Obj
		//IL_054a: Expected Obj, but got I
		//IL_0849: Expected Obj, but got I4
		//IL_086b: Expected I4, but got Obj
		//IL_088d: Expected Obj, but got I
		//IL_047d: Expected Obj, but got I
		//IL_04a6: Expected I, but got Obj
		//IL_04bc: Expected Obj, but got I
		//IL_0575: Expected I, but got Obj
		//IL_07b4: Expected Obj, but got I4
		//IL_07d6: Expected I4, but got Obj
		//IL_07f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected Obj, but got Unknown
		//IL_04e7: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v140 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj2 + 80);
		object obj3 = obj2 - -64;
		object obj4 = obj2 + 48;
		object obj5 = obj2 + 32;
		object obj6 = obj2 + 16;
		string text = Strings.GetDefault("DAILY_CHALLENGE_SUPER_MYSTERY_BOX");
		_rewardLabel.fontSize = (int)text;
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v13 (Il2CppClass<Strings>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		bool flag = obj7 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+C]");
		if ((nint)0 < (nint)4)
		{
			if (!flag)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v75 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text2 = Strings.GetDefault("DAILY_CHALLENGE_DAY_5");
			_dayLabel.fontSize = (int)text2;
			object obj8 = this + 60;
			obj3 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S2_v95+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			_ = 0;
			_dayLabel.rawPivot = pivot;
			object obj9 = this + 76;
			obj4 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S2_v105+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			_ = 0;
			Vector2 effectDistance = ((UILabel)pivot).effectDistance;
			object obj10 = this + 60;
			obj5 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S2_v115+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15+8]");
			_ = 0;
			_rewardLabel.rawPivot = pivot;
			object obj11 = this + 76;
			obj6 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S2_v125+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v17+8]");
			_ = 0;
			Vector2 effectDistance2 = ((UILabel)pivot).effectDistance;
			nint num5 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v125 (Il2CppClass<UI.ColorData>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num6 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v136 (Il2CppClass<UI.ColorData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj13 = (flag2 ? 1 : 0) + 284;
			obj2 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ S2_v137+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			_divider.rawPivot = pivot;
			string text3 = _checkMark.tag;
			((GameObject)(object)text3).tag = null;
		}
		else
		{
			if (!flag)
			{
				nint num7 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v54 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text4 = Strings.GetDefault("DAILY_CHALLENGE_TODAY_2");
			_dayLabel.fontSize = (int)text4;
			object obj14 = this + 28;
			obj3 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S2_v39+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			_ = 0;
			_dayLabel.rawPivot = pivot;
			object obj15 = this + 44;
			obj4 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S2_v49+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			_ = 0;
			Vector2 effectDistance3 = ((UILabel)pivot).effectDistance;
			object obj16 = this + 28;
			obj5 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S2_v59+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v15+8]");
			_ = 0;
			_rewardLabel.rawPivot = pivot;
			object obj17 = this + 44;
			obj6 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ S2_v69+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v17+8]");
			_ = 0;
			Vector2 effectDistance4 = ((UILabel)pivot).effectDistance;
			nint num8 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S1_v84 (Il2CppClass<UI.ColorData>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num9 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S1_v97 (Il2CppClass<UI.ColorData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj19 = (flag3 ? 1 : 0) + 204;
			obj2 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ S2_v81+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			_divider.rawPivot = pivot;
			string text5 = _checkMark.tag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [index @ L1 (System.Int32)+8]");
			bool flag4 = (nint)0 != 0;
			((GameObject)(object)text5).tag = (string)flag4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.DailyChallengePageInternal.RegularDayHelper)+5C]");
		object obj20 = (nint)0 + (nint)12;
		object obj21 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj21) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj20))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.DailyChallengePageInternal.RegularDayHelper)+5C]");
			object obj22 = (nint)0 + (nint)16;
			object obj23 = obj21 << 2;
			object obj24 = obj22 + obj23;
			nint num10 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ S1_v46 (Il2CppClass<UI.ColorData>)+BA]");
			object obj25 = (nint)0 & (nint)0x200;
			if (obj25 != null)
			{
				nint num11 = (nint)typeof(ColorData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ S1_v56 (Il2CppClass<UI.ColorData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag5 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
			object obj26 = (flag5 ? 1 : 0) + 796;
			obj3 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ S2_v27+8]");
			_ = 0;
			((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			_ = 0;
			((UIWidget)obj24).rawPivot = pivot;
			object obj27 = obj21 + 1;
			obj21 = obj27;
		}
		nint num12 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S1_v29 (Il2CppClass<UI.ColorData>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num13 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S1_v38 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag6 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj29 = (flag6 ? 1 : 0) + 812;
		obj3 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ S2_v14+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.Pages.DailyChallengePageInternal.RegularDayHelper)+60]");
		((UIWidget)0).rawPivot = pivot;
	}

	public override void Init()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724A");
	}

	public override void RefreshDay()
	{
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I4
		//IL_033f: Expected I, but got Obj
		//IL_0355: Expected Obj, but got I
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got I4
		//IL_0487: Expected I, but got Obj
		//IL_049d: Expected Obj, but got I
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0397: Expected Obj, but got I4
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected Obj, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ad: Expected Obj, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected Obj, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected Obj, but got Unknown
		//IL_02f8: Expected Obj, but got I4
		//IL_01ae: Expected I, but got Obj
		//IL_01c4: Expected Obj, but got I
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected Obj, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected Obj, but got Unknown
		//IL_0412: Expected I4, but got Obj
		//IL_01ef: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 60;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v65 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = (string)(obj2 + 48);
		WordHuntManager.LogError(text, (UnityEngine.Object)_dayIndex);
		obj = text;
		_ = text.m_stringLength;
		nint num3 = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v14 (Il2CppClass<UI.ColorData>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v80 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 32;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj6 = (flag ? 1 : 0) + 876;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S2_v6+8]");
		_ = 0;
		object obj7 = obj2 + 72;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v19+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A667");
		object obj8 = obj2 + 16;
		bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj9 = (flag2 ? 1 : 0) + 892;
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S2_v19+8]");
		_ = 0;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v26+8]");
		_ = 0;
		_ = _backgroundActive.border;
		object obj10 = this - -64;
		string text2 = ((Component)obj10).tag;
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		bool flag3 = obj7 == null;
		((GameObject)(object)text2).tag = (string)flag3;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		if (obj2 != null)
		{
			obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			_ = 0;
			if ((nint)obj7 == 1)
			{
				nint num5 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v69 (Il2CppClass<Strings>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num6 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v76 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text3 = Strings.GetDefault("DAILY_CHALLENGE_MYSTERY_BOX");
				_rewardLabel.fontSize = (int)text3;
			}
		}
		else
		{
			object obj12 = obj + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
			int fontSize = default;
			_rewardLabel.fontSize = fontSize;
		}
		object obj13 = 0;
		while (true)
		{
			GameObject[] rewards = _rewards;
			if ((nint)obj13 >= rewards.Length)
			{
				break;
			}
			object obj14 = _rewards + 16;
			object obj15 = obj13 << 2;
			object obj16 = obj14 + obj15;
			((GameObject)obj16).tag = null;
			object obj17 = obj13 + 1;
			obj13 = obj17;
		}
		object obj18 = _rewards + 16;
		int num7 = _dayIndex << 2;
		object obj19 = obj18 + num7;
		((GameObject)obj19).tag = (string)1;
		((RewardForVideoButton)(object)_rewardLayout).Init((VideoButtonPayload)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
	}

	private void CompleteToday()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(WordHuntManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<WordHunt.WordHuntManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(WordHuntManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<WordHunt.WordHuntManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		WordHuntManager instance = WordHuntManager.instance;
		((ModelScreenData)(object)this).characterModel = (CharacterModel)(object)instance;
	}

	private void ActivateToday()
	{
		//IL_001e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterModel characterModel = default;
		characterModel._rigPrefab = (GameObject)_dayIndex;
		((UnityEngine.Object)characterModel).m_CachedPtr = (IntPtr)1;
		((ModelScreenData)(object)this).characterModel = characterModel;
	}

	private void DeactivateToday()
	{
		//IL_001e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterModel characterModel = default;
		characterModel._rigPrefab = (GameObject)_dayIndex;
		((UnityEngine.Object)characterModel).m_CachedPtr = (IntPtr)0;
		((ModelScreenData)(object)this).characterModel = characterModel;
	}

	private bool ShouldActivateDivider(int dayIndex, int activeDayIndex)
	{
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_021c: Expected VT, but got I4
		//IL_0237: Expected Obj, but got I4
		//IL_0237: Expected Obj, but got I4
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected Obj, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I4
		//IL_0174: Expected I4, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v24 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = NGUITools.Round((Vector3)activeDayIndex);
		int layer = ((GameObject)(object)this).layer;
		((Transform)layer).parentInternal = (Transform)dayIndex;
		int layer2 = ((GameObject)(object)this).layer;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v30 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 24;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj4 + 36);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v14+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		int layer3 = ((GameObject)(object)this).layer;
		object obj5 = obj4 + 12;
		Vector3 one2 = Vector3.one;
		transform = (Transform)obj5;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v21+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 right = transform.right;
		int layer4 = ((GameObject)(object)this).layer;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj4;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)layer4).parent = transform;
		return (byte)(int)this != 0;
	}

	private void SetupDay(WordHuntManager.WordHuntPayload huntPayload)
	{
		//IL_000a: Expected I4, but got Obj
		_dayIndex = (int)huntPayload;
	}

	public RegularDayHelper()
	{
		//IL_001d: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		CharacterModel characterModel = default;
		characterModel._rigPrefab = (GameObject)1;
		((UnityEngine.Object)characterModel).m_CachedPtr = (IntPtr)0;
		((ModelScreenData)(object)this).characterModel = characterModel;
	}
}
