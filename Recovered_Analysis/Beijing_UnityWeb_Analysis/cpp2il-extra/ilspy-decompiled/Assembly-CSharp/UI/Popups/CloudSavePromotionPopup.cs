using System;
using System.Collections.Generic;
using System.Linq;
using Cloud;
using Cloud.Internal;
using Cpp2ILInjected;
using Info;
using Kiloo.Common.HTTP;
using Kiloo.GameCenter;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Popups.BoardBundlePopupInternal;
using UI.Popups.CloudSaveConfirmationPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class CloudSavePromotionPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<CloudSaveComparisonRow, bool> _003C_003E9__14_0;

		public static Action _003C_003E9__16_2;

		public static Action _003C_003E9__16_0;

		public static Action _003C_003E9__16_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudSaveDisabledStatusPopup._003C_003Ec obj = default;
			CloudSaveDisabledStatusPopup._003C_003Ec._003C_003E9 = obj;
		}

		internal bool _003CSetupConflict_003Eb__14_0(CloudSaveComparisonRow r)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v6 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float value = r.localValue - r.onlineValue;
			float num3 = Math.Abs(value);
			return num3 > 0.5f;
		}

		internal void _003CButtonClicked_003Eb__16_0()
		{
		}

		internal void _003CButtonClicked_003Eb__16_2()
		{
			//IL_0188: Expected I, but got Obj
			//IL_019e: Expected Obj, but got I
			//IL_0266: Expected I, but got Obj
			//IL_027c: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0205: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Expected Obj, but got Unknown
			//IL_0221: Expected I, but got Obj
			//IL_0237: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v69 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78EE");
			CloudSaveConflictResolver cloudSaveConflictResolver = default;
			cloudSaveConflictResolver.DetermineRecommendation();
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v13 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v63 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_003C_003E9__16_2 == null)
			{
				nint num5 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v40 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v57 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num7 = 0;
				_ = 0;
				object obj5 = default;
				object obj4 = obj5 + 16;
				obj4 = _003C_003E9;
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v54 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+5C]");
				object obj6 = (nint)0 + (nint)8;
				obj6 = obj5;
			}
			throw new ArrayTypeMismatchException();
		}

		internal void _003CButtonClicked_003Eb__16_1()
		{
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_0141: Expected I, but got Obj
			//IL_0157: Expected Obj, but got I
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Expected Obj, but got Unknown
			//IL_0111: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			nint num = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = UIScreenController.ShouldShowOnlineScreen();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = default;
			text.m_stringLength = 20;
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v7 (Il2CppClass<Strings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v14 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = text + 12;
			string text2 = Strings.GetDefault("CLOUDSAVE_SLIDEIN_CONFLICT_RESOLVED_CLOUD");
			obj3 = text2;
			((UIScreenController)flag)._QueueMessage(text);
		}
	}

	private const float SLIDEIN_DELAY = 0.5f;

	private CloudSaveProgressCell _cellPrefab;

	private Layout _cellLayout;

	private UILabel _headline;

	private UILabel _subline;

	private UILabel _bannerTopLabel;

	private UILabel _bannerBottomLabel;

	private UILabel _subtext;

	private UILabel _buttonLabel;

	private UISprite _banner;

	private UITexture _skyline;

	public override void Init()
	{
		CancelInvoke();
	}

	public override void Show()
	{
		ShowIfInactive();
		SetupConflict();
	}

	private void SetupBasic()
	{
		//IL_00ba: Expected I, but got Obj
		//IL_00d0: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_0165: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		base.Hide();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v13 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("CLOUDSAVE_PROMOTION_DESCRIPTION");
		nint num3 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v11 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isAvailable = CloudSave.isAvailable;
		string text = string.Format(format, (object[])isAvailable);
		_subline.fontSize = (int)text;
		MoreInformationClicked();
	}

	private unsafe void SetupConflict()
	{
		//IL_0527: Expected I, but got Obj
		//IL_053d: Expected Obj, but got I
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected Obj, but got Unknown
		//IL_05af: Expected Obj, but got I4
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected I4, but got Unknown
		//IL_05df: Expected I4, but got Obj
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected Obj, but got Unknown
		//IL_0617: Expected Obj, but got I4
		//IL_0639: Expected I4, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0090: Expected I4, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_00ea: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0127: Expected Obj, but got I4
		//IL_0149: Expected I4, but got Obj
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected Obj, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_018c: Expected Obj, but got I4
		//IL_01ae: Expected I4, but got Obj
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected Obj, but got Unknown
		//IL_01e9: Expected Obj, but got I4
		//IL_020b: Expected I4, but got Obj
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected Obj, but got Unknown
		//IL_023e: Expected Obj, but got I4
		//IL_0260: Expected I4, but got Obj
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected Obj, but got Unknown
		//IL_0298: Expected Obj, but got I4
		//IL_02ba: Expected I4, but got Obj
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_0301: Expected Obj, but got I4
		//IL_0323: Expected I4, but got Obj
		//IL_034d: Expected Obj, but got I4
		//IL_036f: Expected I4, but got Obj
		//IL_0385: Expected Obj, but got I4
		//IL_0403: Expected I, but got Obj
		//IL_0419: Expected Obj, but got I
		//IL_0577: Expected I4, but got Obj
		//IL_0492: Expected I4, but got Obj
		//IL_0444: Expected I, but got Obj
		//IL_03f0: Expected Obj, but got I4
		//IL_04b4: Expected I4, but got Obj
		//IL_04d6: Expected I4, but got Obj
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e1: Expected Obj, but got Unknown
		//IL_0502: Expected I4, but got Obj
		//IL_0513: Expected I4, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v60 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 + 160;
		object obj4 = (flag ? 1 : 0) + 140;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 176);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_headline.rawPivot = pivot;
		object obj5 = obj3 + 144;
		object obj6 = (flag ? 1 : 0) + 92;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		_subline.rawPivot = pivot;
		object obj7 = obj3 + 128;
		object obj8 = (flag ? 1 : 0) + 284;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v18+8]");
		_ = 0;
		_banner.rawPivot = pivot;
		object obj9 = obj3 + 112;
		object obj10 = (flag ? 1 : 0) + 572;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v37+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v24+8]");
		_ = 0;
		_bannerTopLabel.rawPivot = pivot;
		object obj11 = obj3 + 96;
		object obj12 = (flag ? 1 : 0) + 556;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S2_v48+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v30+8]");
		_ = 0;
		_bannerBottomLabel.rawPivot = pivot;
		object obj13 = this - -64;
		object obj14 = obj3 + 80;
		object obj15 = (flag ? 1 : 0) + 92;
		obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S2_v59+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v37+8]");
		_ = 0;
		((UIWidget)obj13).rawPivot = pivot;
		object obj16 = obj3 - -64;
		object obj17 = (flag ? 1 : 0) + 124;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S2_v70+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v43+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A667");
		object obj18 = obj3 + 48;
		object obj19 = (flag ? 1 : 0) + 44;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S2_v81+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S1_v49+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A668");
		object obj20 = obj3 + 32;
		object obj21 = (flag ? 1 : 0) + 604;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S2_v92+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S1_v55+8]");
		_ = 0;
		_skyline.rawPivot = pivot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A665");
		object obj22 = obj3 + 16;
		object obj23 = (flag ? 1 : 0) + 604;
		obj22 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ S2_v104+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S1_v62+8]");
		_ = 0;
		_buttonLabel.rawPivot = pivot;
		object obj24 = (flag ? 1 : 0) + 732;
		obj3 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S2_v114+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)1;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S1_v74 (Il2CppClass<Strings>)+BA]");
		object obj25 = (nint)0 & (nint)0x200;
		if (obj25 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S1_v97 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("CLOUDSAVE_PROMOTION_TITLE");
		_headline.fontSize = (int)text3;
		string text4 = Strings.GetDefault("CLOUDSAVE_PROMOTION_LABELTITLE");
		_bannerTopLabel.fontSize = (int)text4;
		string text5 = Strings.GetDefault("CLOUDSAVE_PROMOTION_LABELSUBTITLE");
		_bannerBottomLabel.fontSize = (int)text5;
		string text6 = Strings.GetDefault("CLOUDSAVE_PROMOTION_BUTTON");
		_buttonLabel.fontSize = (int)text6;
		object obj26 = this - -64;
		string text7 = Strings.GetDefault("CLOUDSAVE_COMPARISON_INFOBUTTON");
		string text8 = string.ConcatArray((string[])(object)"[u]", (int)text7);
		((UILabel)obj26).fontSize = (int)text8;
	}

	public void MoreInformationClicked()
	{
		//IL_054e: Expected I, but got Obj
		//IL_0564: Expected Obj, but got I
		//IL_0709: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_0192: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected Obj, but got Unknown
		//IL_05f0: Expected I, but got Obj
		//IL_0606: Expected Obj, but got I
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_066d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected Obj, but got Unknown
		//IL_02a7: Expected Obj, but got I8
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_024b: Expected I, but got Obj
		//IL_02f4: Expected Obj, but got I4
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected Obj, but got Unknown
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected Obj, but got Unknown
		//IL_0356: Expected Obj, but got I4
		//IL_0381: Expected I, but got Obj
		//IL_0397: Expected Obj, but got I
		//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected Obj, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_03c2: Expected I, but got Obj
		//IL_045f: Expected Obj, but got I4
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected Obj, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c9: Expected Obj, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected Obj, but got Unknown
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v41 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78EE");
		CloudSaveConflictResolver cloudSaveConflictResolver = default;
		cloudSaveConflictResolver.AttemptAutoResolution();
		string source = CloudSaveDecorator.GetName((CloudSaveComparisonElement)cloudSaveConflictResolver);
		nint num3 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v7 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v96 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__14_0 == null;
		bool flag2 = !flag;
		Func<CloudSaveComparisonRow, bool> keySelector = _003C_003Ec._003C_003E9__14_0;
		if (!flag2)
		{
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v70 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v90 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			_ = 0;
			Func<CloudSaveComparisonRow, bool> func = default;
			object obj4 = func + 16;
			obj4 = _003C_003Ec._003C_003E9;
			nint num8 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v87 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+5C]");
			object obj5 = (nint)0 + (nint)4;
			obj5 = func;
			keySelector = func;
		}
		IOrderedEnumerable<CloudSaveComparisonRow> source2 = Enumerable.OrderByDescending((IEnumerable<CloudSaveComparisonRow>)(object)source, keySelector);
		List<CloudSaveComparisonRow> list = Enumerable.ToList(source2);
		GameObject obj6 = _cellLayout.gameObject;
		nint num9 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v21 (Il2CppClass<NGUITools>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v65 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.DestroyImmediate(obj6);
		UIWidget component = _cellLayout.GetComponent<UIWidget>();
		GameObject parent = _cellLayout.gameObject;
		nint num11 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S2_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num12 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S2_v69 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSaveProgressCell cloudSaveProgressCell = UnityEngine.Object.Instantiate(_cellPrefab, (Transform)(object)parent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		object obj9 = text + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
		object obj10 = default;
		obj9 = obj10;
		long scoreValue = ((GameCenterReportScoreRequest)(object)cloudSaveConflictResolver).scoreValue;
		object obj11 = scoreValue;
		UserData userData = (UserData)(obj11 + 8);
		userData = (UserData)obj11;
		object obj12 = text + 12;
		string text2 = userData.AsString();
		obj12 = text2;
		object obj13 = 1 / 2;
		object obj14 = obj13 * 2;
		object obj15 = 1 - obj14;
		bool flag3 = (nint)obj15 == 1;
		_ = 0;
		_ = 70;
		_ = component.mWidth;
		_ = 36;
		((CloudSaveReminderPopup)(object)cloudSaveProgressCell).FlurryLogOnButtonClicked(text);
		object obj16 = 1;
		int num13 = 0;
		string text3 = default;
		object obj19 = default;
		while (num13 <= 1)
		{
			GameObject parent2 = _cellLayout.gameObject;
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S2_v37 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num15 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S2_v65 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			CloudSaveProgressCell cloudSaveProgressCell2 = UnityEngine.Object.Instantiate(_cellPrefab, (Transform)(object)parent2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj18 = text3 + 8;
			CloudSaveComparisonRow cloudSaveComparisonRow = list.get_Item(num13);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7476");
			obj18 = obj19;
			object obj20 = text3 + 12;
			CloudSaveComparisonRow cloudSaveComparisonRow2 = list.get_Item(num13);
			CloudSaveComparisonRow cloudSaveComparisonRow3 = list.get_Item(num13);
			IRequest request = RequestExtensions.WithTimeout((IRequest)cloudSaveComparisonRow2.id, cloudSaveComparisonRow3.onlineValue);
			obj20 = request;
			CloudSaveComparisonRow cloudSaveComparisonRow4 = list.get_Item(num13);
			bool isOnlineImprovement = cloudSaveComparisonRow4.isOnlineImprovement;
			_ = 70;
			_ = component.mWidth;
			object obj21 = obj16 + 1;
			object obj22 = obj21 / 2;
			object obj23 = obj22 * 2;
			object obj24 = obj21 - obj23;
			bool flag4 = (nint)obj24 == 1;
			_ = 36;
			((CloudSaveReminderPopup)(object)cloudSaveProgressCell2).FlurryLogOnButtonClicked(text3);
			int num16 = num13 + 1;
			obj16 = obj21;
			num13 = num16;
		}
		((RewardForVideoButton)(object)_cellLayout).Init((VideoButtonPayload)null);
	}

	public void ButtonClicked()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I4
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v21 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).QueuePopup("CloudSaveAdvancedComparisonPopup");
		nint num3 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v13 (Il2CppClass<Flurry>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public CloudSavePromotionPopup()
	{
		//IL_0263: Expected I, but got Obj
		//IL_0279: Expected Obj, but got I
		//IL_042f: Expected I4, but got Obj
		//IL_048c: Expected I, but got Obj
		//IL_04a2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_044b: Expected I, but got Obj
		//IL_0461: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_02bc: Expected Obj, but got I4
		//IL_02d3: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_02f1: Expected Obj, but got I4
		//IL_03b2: Expected Obj, but got I4
		//IL_03c0: Expected I, but got Obj
		//IL_03d6: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_040a: Expected Obj, but got I4
		//IL_01c9: Expected I, but got Obj
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected Obj, but got Unknown
		//IL_0375: Expected I, but got Obj
		//IL_038b: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v100 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__16_0 == null;
		bool flag2 = !flag;
		Boards.BoardId boardId = (Boards.BoardId)_003C_003Ec._003C_003E9__16_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v77 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v94 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Boards.BoardId boardId2 = default;
			object obj3 = boardId2 + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v91 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)12;
			obj4 = boardId2;
			boardId = boardId2;
		}
		nint num7 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v16 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v70 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = _003C_003Ec._003C_003E9__16_1 == null;
		bool flag4 = !flag3;
		string price = (string)(object)_003C_003Ec._003C_003E9__16_1;
		if (!flag4)
		{
			nint num9 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v47 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v64 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num11 = 0;
			string text = default;
			text.m_stringLength = (int)num11;
			_ = 0;
			object obj7 = text + 16;
			obj7 = _003C_003Ec._003C_003E9;
			nint num12 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v61 (Il2CppClass<UI.Popups.CloudSavePromotionPopup+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)16;
			obj8 = text;
			price = text;
		}
		nint num13 = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v26 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v42 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((BoardBundleItem)3).Init(boardId, price);
		nint num15 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v32 (Il2CppClass<UIScreenController>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num16 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v38 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag5).QueuePopup("CloudSaveConfirmationPopup");
	}
}
