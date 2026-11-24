using System;
using System.Collections.Generic;
using Cloud;
using Cloud.Internal;
using Cpp2ILInjected;
using Kiloo.GameCenter;
using UI.FreeStuff;
using UI.Generic.Layout;
using UI.Popups.CloudSaveAdvancedComparisonPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class CloudSaveAdvancedComparisonPopup : UIScreen
{
	private UILabel _localHeadline;

	private UILabel _onlineHeadline;

	private UISprite _headerBackground;

	private UISprite _contentBackground;

	private UISprite _localBannerBackground;

	private UISprite _onlineBannerBackground;

	private CloudSaveAdvancedComparisonRow _comparisonRowPrefab;

	private Layout _rowLayout;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		ShowIfInactive();
		SetupComparison();
	}

	private void SetupBasic()
	{
		base.Hide();
		this._002Ector();
	}

	private unsafe void SetupComparison()
	{
		//IL_0380: Expected I, but got Obj
		//IL_0396: Expected Obj, but got I
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_0408: Expected Obj, but got I4
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected I4, but got Unknown
		//IL_0438: Expected I4, but got Obj
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_0470: Expected Obj, but got I4
		//IL_0492: Expected I4, but got Obj
		//IL_04a8: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected Obj, but got I4
		//IL_0090: Expected I4, but got Obj
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected Obj, but got Unknown
		//IL_00c8: Expected Obj, but got I4
		//IL_00ea: Expected I4, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0125: Expected Obj, but got I4
		//IL_0147: Expected I4, but got Obj
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017f: Expected Obj, but got I4
		//IL_01a1: Expected I4, but got Obj
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01de: Expected Obj, but got I4
		//IL_0200: Expected I4, but got Obj
		//IL_022a: Expected Obj, but got I4
		//IL_024c: Expected I4, but got Obj
		//IL_02e2: Expected I, but got Obj
		//IL_02f8: Expected Obj, but got I
		//IL_03d0: Expected I4, but got Obj
		//IL_0371: Expected I4, but got Obj
		//IL_0323: Expected I, but got Obj
		//IL_02cf: Expected Obj, but got I4
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v44 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 + 112;
		object obj4 = (flag ? 1 : 0) + 604;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 128);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_localHeadline.rawPivot = pivot;
		object obj5 = obj3 + 96;
		object obj6 = (flag ? 1 : 0) + 124;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		object obj7 = obj3 + 80;
		object obj8 = (flag ? 1 : 0) + 604;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v18+8]");
		_ = 0;
		_onlineHeadline.rawPivot = pivot;
		object obj9 = obj3 - -64;
		object obj10 = (flag ? 1 : 0) + 124;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S2_v37+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v24+8]");
		_ = 0;
		Vector2 effectDistance2 = ((UILabel)pivot).effectDistance;
		object obj11 = obj3 + 48;
		object obj12 = (flag ? 1 : 0) + 44;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S2_v48+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v30+8]");
		_ = 0;
		_headerBackground.rawPivot = pivot;
		object obj13 = obj3 + 32;
		object obj14 = (flag ? 1 : 0) + 28;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S2_v59+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v36+8]");
		_ = 0;
		_contentBackground.rawPivot = pivot;
		object obj15 = obj3 + 16;
		object obj16 = (flag ? 1 : 0) + 220;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S2_v70+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v42+8]");
		_ = 0;
		_localBannerBackground.rawPivot = pivot;
		object obj17 = (flag ? 1 : 0) + 220;
		obj3 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ S2_v80+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_onlineBannerBackground.rawPivot = pivot;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)1;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S1_v54 (Il2CppClass<Strings>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v64 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("CLOUDSAVE_ADVANCED_LOCAL_HEADER");
		_localHeadline.fontSize = (int)text3;
		string text4 = Strings.GetDefault("CLOUDSAVE_ADVANCED_CLOUD_HEADER");
		_onlineHeadline.fontSize = (int)text4;
	}

	public CloudSaveAdvancedComparisonPopup()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected Obj, but got Unknown
		//IL_09bd: Expected Obj, but got I4
		//IL_09cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected Obj, but got Unknown
		//IL_09ed: Expected I, but got Obj
		//IL_0a03: Expected Obj, but got I
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Expected Obj, but got Unknown
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_008f: Expected I, but got Obj
		//IL_00a5: Expected Obj, but got I
		//IL_0a2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected Obj, but got Unknown
		//IL_0a51: Expected I, but got Obj
		//IL_0a67: Expected Obj, but got I
		//IL_0aad: Expected Obj, but got I4
		//IL_00d0: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I4
		//IL_017b: Expected Obj, but got I4
		//IL_0195: Expected Obj, but got I4
		//IL_019e: Expected Obj, but got I4
		//IL_011d: Expected I, but got Obj
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected Obj, but got Unknown
		//IL_020f: Expected Obj, but got I4
		//IL_022e: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got VT
		//IL_0255: Expected Obj, but got I4
		//IL_0273: Expected Obj, but got I4
		//IL_0284: Expected Obj, but got I8
		//IL_029a: Expected Obj, but got I4
		//IL_02ec: Expected Obj, but got I4
		//IL_0b16: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I4
		//IL_0ac9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected Obj, but got Unknown
		//IL_032a: Expected Obj, but got I4
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		//IL_034d: Expected Obj, but got I4
		//IL_0360: Expected I, but got Obj
		//IL_0376: Expected Obj, but got I
		//IL_0afe: Expected Obj, but got I4
		//IL_03fc: Expected Obj, but got I4
		//IL_03a1: Expected I, but got Obj
		//IL_0414: Expected Obj, but got I4
		//IL_0c35: Invalid comparison between I and F4
		//IL_0847: Expected Obj, but got I
		//IL_042c: Expected Obj, but got I4
		//IL_03e4: Expected Obj, but got I4
		//IL_0910: Invalid comparison between I and F4
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_045a: Expected Obj, but got I4
		//IL_0946: Expected Obj, but got I4
		//IL_08fa: Expected Obj, but got I4
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected Obj, but got Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected Obj, but got Unknown
		//IL_0488: Expected Obj, but got I4
		//IL_0b41: Expected Obj, but got I4
		//IL_0b61: Invalid comparison between I and F4
		//IL_0938: Expected Obj, but got I4
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected Obj, but got Unknown
		//IL_096a: Invalid comparison between I and F4
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected Obj, but got Unknown
		//IL_09a0: Expected Obj, but got I4
		//IL_0954: Expected Obj, but got I4
		//IL_0b9c: Expected Obj, but got I4
		//IL_0992: Expected Obj, but got I4
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected Obj, but got Unknown
		//IL_078e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected Obj, but got Unknown
		//IL_07bf: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 32;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v199 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UserData userData = (UserData)(obj2 + 16);
		object obj6 = obj2 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78EE");
		CloudSaveComparisonElement cloudSaveComparisonElement = default;
		if (cloudSaveComparisonElement == CloudSaveComparisonElement.Multiplier)
		{
			return;
		}
		string text = CloudSaveDecorator.GetName(cloudSaveComparisonElement);
		GameObject obj7 = _rowLayout.gameObject;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v17 (Il2CppClass<NGUITools>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v164 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.DestroyImmediate(obj7);
		object original = this - -64;
		GameObject parent = _rowLayout.gameObject;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S2_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v94 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CloudSaveAdvancedComparisonRow label = UnityEngine.Object.Instantiate((CloudSaveAdvancedComparisonRow)original, (Transform)(object)parent);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		bool flag = default;
		object obj10 = (flag ? 1 : 0) + 8;
		string iconName = CloudSaveDecorator.GetIconName(CloudSaveComparisonElement.DeviceSource);
		obj10 = iconName;
		object obj11 = (flag ? 1 : 0) + 12;
		string sourceTheirs = ((CloudSaveConflictResolver)cloudSaveComparisonElement).sourceTheirs;
		obj11 = sourceTheirs;
		object obj12 = (flag ? 1 : 0) + 16;
		List<CloudSaveComparisonRow> comparisonRows = ((CloudSaveConflictResolver)cloudSaveComparisonElement).GetComparisonRows();
		obj12 = comparisonRows;
		_ = 0;
		CloudSaveAdvancedComparisonRow.ColorTextField((UILabel)(object)label, flag);
		object original2 = this - -64;
		GameObject parent2 = _rowLayout.gameObject;
		CloudSaveAdvancedComparisonRow label2 = UnityEngine.Object.Instantiate((CloudSaveAdvancedComparisonRow)original2, (Transform)(object)parent2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		bool flag2 = default;
		object obj13 = (flag2 ? 1 : 0) + 8;
		string iconName2 = CloudSaveDecorator.GetIconName(CloudSaveComparisonElement.LastModifiedTime);
		obj13 = iconName2;
		DateTime lastModifiedTheirs = ((CloudSaveConflictResolver)cloudSaveComparisonElement).lastModifiedTheirs;
		obj6 = lastModifiedTheirs;
		userData = (UserData)obj6;
		object obj14 = (flag2 ? 1 : 0) + 12;
		string text2 = userData.AsString();
		obj14 = text2;
		long scoreValue = ((GameCenterReportScoreRequest)cloudSaveComparisonElement).scoreValue;
		obj2 = scoreValue;
		userData = (UserData)obj2;
		object obj15 = (flag2 ? 1 : 0) + 16;
		string text3 = userData.AsString();
		obj15 = text3;
		_ = 1;
		CloudSaveAdvancedComparisonRow.ColorTextField((UILabel)(object)label2, flag2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = userData;
		_ = userData.multiplier;
		object obj16 = 2;
		object obj18 = default;
		object obj22 = default;
		object obj23 = default;
		object obj25 = default;
		object obj17;
		object obj27 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj17 = 36;
			bool flag3 = obj18 == null;
			obj17 = 37;
			if (flag3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj17 = 19;
			object obj19 = this - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj17 = 20;
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ S0_v124 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ S0_v191 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj17 = 20;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj17 = 30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj17 = 31;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj17 = 31;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj17 = 32;
			object obj21 = obj22 + 8;
			obj21 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
			obj17 = 33;
			object obj24 = obj22 + 12;
			obj24 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
			obj17 = 34;
			object obj26 = obj22 + 16;
			obj26 = obj27;
			object obj28 = obj16 + 1;
			object obj29 = obj28 & 1;
			bool flag4 = obj29 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v108+15]");
			bool flag5 = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v108+14]");
			bool flag6 = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj16 = obj28;
		}
		object obj30 = obj17 - 19;
		if ((nint)obj17 != 19 && (nint)obj30 != 1)
		{
			if ((nint)obj30 != 2 && (nint)obj30 != 3 && (nint)obj30 != 4 && (nint)obj30 != 5 && (nint)obj30 != 6 && (nint)obj30 != 7 && (nint)obj30 != 8 && (nint)obj30 != 9 && (nint)obj30 != 10)
			{
				if ((nint)obj30 == 11 || (nint)obj30 == 12 || (nint)obj30 == 13 || (nint)obj30 == 14 || (nint)obj30 == 15 || (nint)obj30 == 16 || (nint)obj30 == 17)
				{
					goto IL_07c4;
				}
				if ((nint)obj30 == 18)
				{
					object obj31 = obj4 + 4;
					object obj32 = obj31 + 1;
					obj31 = obj32;
					object obj33 = obj32 << 2;
					object obj34 = obj4 + obj33;
					obj34 = 396;
				}
			}
			goto IL_0be4;
		}
		goto IL_07c4;
		IL_0c09:
		((RewardForVideoButton)(object)_rowLayout).Init((VideoButtonPayload)null);
		string text4 = _onlineBannerBackground.tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (Cloud.Internal.CloudSaveComparisonElement)+14]");
		object obj35;
		if (0f > 2f)
		{
			obj35 = 1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (Cloud.Internal.CloudSaveComparisonElement)+14]");
			obj35 = ((!(0f < -2f)) ? ((object)0) : ((object)2));
		}
		bool flag7 = (nint)obj35 == 2;
		((GameObject)(object)text4).tag = (string)flag7;
		string text5 = _localBannerBackground.tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (Cloud.Internal.CloudSaveComparisonElement)+14]");
		object obj36;
		if (0f > 2f)
		{
			obj36 = 1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (Cloud.Internal.CloudSaveComparisonElement)+14]");
			obj36 = ((!(0f < -2f)) ? ((object)0) : ((object)2));
		}
		bool flag8 = (nint)obj36 == 1;
		((GameObject)(object)text5).tag = (string)flag8;
		return;
		IL_0be4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj37 = (nint)0 << 2;
			object obj38 = obj4 + obj37;
			if ((nint)obj38 == 396)
			{
				object obj39 = obj4 + 4;
				if ((nint)obj39 > -1)
				{
					object obj40 = obj39 + -1;
					obj39 = obj40;
				}
				goto IL_0c09;
			}
		}
		object obj41 = default;
		if (obj41 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0c09;
		IL_07c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj42 = default;
		object obj43 = default;
		if (obj42 == obj43)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0be4;
	}
}
