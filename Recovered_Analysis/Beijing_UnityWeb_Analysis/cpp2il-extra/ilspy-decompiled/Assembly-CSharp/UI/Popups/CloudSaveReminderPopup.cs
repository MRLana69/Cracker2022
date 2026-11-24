using System;
using Cloud;
using Cloud.Internal;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using UI.FreeStuff;
using UI.Generic;
using UI.Popups.BoardBundlePopupInternal;
using UI.Popups.CloudSaveConfirmationPopupInternal;
using UI.Screens;
using UnityEngine;

namespace UI.Popups;

public class CloudSaveReminderPopup : UIScreen
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__10_0;

		public static Action _003C_003E9__10_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudSavePromotionPopup._003C_003Ec obj = default;
			CloudSavePromotionPopup._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
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
			((UIScreenController)flag).DebugCloseAllPopups();
		}

		internal void _003CDisableClicked_003Eb__10_0()
		{
		}

		internal void _003CDisableClicked_003Eb__10_1()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a5: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
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
			((UIScreenController)flag).DebugCloseAllPopups();
		}
	}

	private UILabel _headline;

	private UILabel _subline;

	private UILabel _messageLabel;

	private UILabel _disableLabel;

	private UILabel _fixLabel;

	private UIWidget _skyline;

	private UISprite _background;

	public override void Init()
	{
		((UpgradeScreen)this).Start();
	}

	public override void Show()
	{
		ShowIfInactive();
		DisableClicked();
	}

	private void SetupBasic()
	{
		//IL_00ea: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got VT
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ae: Expected I4, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got VT
		//IL_00d5: Expected I4, but got Obj
		base.Hide();
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v18 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string format = Strings.GetDefault("CLOUDSAVE_REMINDER_LASTSYNCED");
		nint num3 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v4 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v15 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 8;
		DateTime lastCloudSaveReminderShownTime = UserSave.lastCloudSaveReminderShownTime;
		obj3 = lastCloudSaveReminderShownTime;
		UserData userData = (UserData)(obj4 + 16);
		userData = (UserData)obj3;
		string args = userData.AsString();
		string text = string.Format(format, (object[])(object)args);
		_messageLabel.fontSize = (int)text;
		DateTime today = CDateTime.Today;
		obj4 = today;
		userData = (UserData)obj4;
		UserSave.hasCloudSaveCelebrationBeenShown = (byte)(int)userData != 0;
	}

	public unsafe void DisableClicked()
	{
		//IL_0482: Expected I, but got Obj
		//IL_0498: Expected Obj, but got I
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_050a: Expected Obj, but got I4
		//IL_0528: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Expected I4, but got Unknown
		//IL_053a: Expected I4, but got Obj
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected Obj, but got Unknown
		//IL_0572: Expected Obj, but got I4
		//IL_0594: Expected I4, but got Obj
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
		//IL_01b7: Expected Obj, but got I4
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_01dc: Expected Obj, but got I4
		//IL_01fe: Expected I4, but got Obj
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0236: Expected Obj, but got I4
		//IL_0258: Expected I4, but got Obj
		//IL_026e: Expected Obj, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected Obj, but got Unknown
		//IL_029e: Expected Obj, but got I4
		//IL_02c0: Expected I4, but got Obj
		//IL_02e8: Expected Obj, but got I4
		//IL_030a: Expected I4, but got Obj
		//IL_03a0: Expected I, but got Obj
		//IL_03b6: Expected Obj, but got I
		//IL_04d2: Expected I4, but got Obj
		//IL_042f: Expected I4, but got Obj
		//IL_03e1: Expected I, but got Obj
		//IL_038d: Expected Obj, but got I4
		//IL_0451: Expected I4, but got Obj
		//IL_0473: Expected I4, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v53 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj3 = default;
		object obj2 = obj3 + 144;
		object obj4 = (flag ? 1 : 0) + 140;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v3+8]");
		_ = 0;
		UIWidget.Pivot pivot = (UIWidget.Pivot)(obj3 + 160);
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v5+8]");
		_ = 0;
		_headline.rawPivot = pivot;
		object obj5 = obj3 + 128;
		object obj6 = (flag ? 1 : 0) + 92;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v15+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v12+8]");
		_ = 0;
		_subline.rawPivot = pivot;
		object obj7 = obj3 + 112;
		object obj8 = (flag ? 1 : 0) + 572;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S2_v26+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v18+8]");
		_ = 0;
		_messageLabel.rawPivot = pivot;
		object obj9 = obj3 + 96;
		object obj10 = (flag ? 1 : 0) + 252;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v37+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v24+8]");
		_ = 0;
		Vector2 effectDistance = ((UILabel)pivot).effectDistance;
		object obj11 = obj3 + 80;
		object obj12 = (flag ? 1 : 0) + 604;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S2_v48+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v30+8]");
		_ = 0;
		_disableLabel.rawPivot = pivot;
		object obj13 = obj3 - -64;
		object obj14 = (flag ? 1 : 0) + 732;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S2_v59+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v36+8]");
		_ = 0;
		Vector2 effectDistance2 = ((UILabel)pivot).effectDistance;
		object obj15 = obj3 + 48;
		object obj16 = (flag ? 1 : 0) + 604;
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S2_v70+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v42+8]");
		_ = 0;
		_fixLabel.rawPivot = pivot;
		object obj17 = obj3 + 32;
		object obj18 = (flag ? 1 : 0) + 732;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S2_v81+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v48+8]");
		_ = 0;
		Vector2 effectDistance3 = ((UILabel)pivot).effectDistance;
		object obj19 = this - -64;
		object obj20 = obj3 + 16;
		object obj21 = (flag ? 1 : 0) + 492;
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S2_v92+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v55+8]");
		_ = 0;
		((UIWidget)obj19).rawPivot = pivot;
		object obj22 = (flag ? 1 : 0) + 508;
		obj3 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ S2_v102+8]");
		_ = 0;
		((UIWidget.Pivot*)(int)pivot)->value__ = (int)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		_skyline.rawPivot = pivot;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			string text = tag;
			((GameObject)(object)text).tag = null;
			string text2 = tag;
			((GameObject)(object)text2).tag = (string)1;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S1_v67 (Il2CppClass<Strings>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v83 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text3 = Strings.GetDefault("CLOUDSAVE_REMINDER_HEADER");
		_headline.fontSize = (int)text3;
		string text4 = Strings.GetDefault("CLOUDSAVE_REMINDER_SUBTITLE");
		_subline.fontSize = (int)text4;
		string text5 = Strings.GetDefault("CLOUDSAVE_REMINDER_BUTTON_DISABLE");
		_disableLabel.fontSize = (int)text5;
		string text6 = Strings.GetDefault("CLOUDSAVE_REMINDER_BUTTON_FIX");
		_fixLabel.fontSize = (int)text6;
	}

	public void FixClicked()
	{
		//IL_0264: Expected I, but got Obj
		//IL_027a: Expected Obj, but got I
		//IL_043b: Expected I4, but got Obj
		//IL_0498: Expected I, but got Obj
		//IL_04ae: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0457: Expected I, but got Obj
		//IL_046d: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_02bd: Expected Obj, but got I4
		//IL_02d4: Expected I, but got Obj
		//IL_02ea: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I4
		//IL_03bd: Expected I, but got Obj
		//IL_03d3: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0407: Expected Obj, but got I4
		//IL_01c9: Expected I, but got Obj
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected Obj, but got Unknown
		//IL_0376: Expected I, but got Obj
		//IL_038c: Expected Obj, but got I
		//IL_0216: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UI.Popups.CloudSaveReminderPopup+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v101 (Il2CppClass<UI.Popups.CloudSaveReminderPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__10_0 == null;
		bool flag2 = !flag;
		Boards.BoardId boardId = (Boards.BoardId)_003C_003Ec._003C_003E9__10_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v78 (Il2CppClass<UI.Popups.CloudSaveReminderPopup+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v95 (Il2CppClass<UI.Popups.CloudSaveReminderPopup+<>c>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v92 (Il2CppClass<UI.Popups.CloudSaveReminderPopup+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = boardId2;
			boardId = boardId2;
		}
		nint num7 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v16 (Il2CppClass<UI.Popups.CloudSaveReminderPopup+<>c>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v71 (Il2CppClass<UI.Popups.CloudSaveReminderPopup+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = _003C_003Ec._003C_003E9__10_1 == null;
		bool flag4 = !flag3;
		string price = (string)(object)_003C_003Ec._003C_003E9__10_1;
		if (!flag4)
		{
			nint num9 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v48 (Il2CppClass<UI.Popups.CloudSaveReminderPopup+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v65 (Il2CppClass<UI.Popups.CloudSaveReminderPopup+<>c>)+74]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v62 (Il2CppClass<UI.Popups.CloudSaveReminderPopup+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)8;
			obj8 = text;
			price = text;
		}
		nint num13 = (nint)typeof(CloudSaveConfirmationPopupPayload);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v26 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(CloudSaveConfirmationPopupPayload);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v43 (Il2CppClass<UI.Popups.CloudSaveConfirmationPopupInternal.CloudSaveConfirmationPopupPayload>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((BoardBundleItem)null).Init(boardId, price);
		nint num15 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v32 (Il2CppClass<UIScreenController>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num16 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v39 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag5).QueuePopup("CloudSaveConfirmationPopup");
		((ConsentPopup)null).PrivacyPolicyClicked((UILabel)(object)"Disconnect");
	}

	public void CloseClicked()
	{
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected Obj, but got Unknown
		//IL_04e8: Expected Obj, but got I4
		//IL_04f1: Expected Obj, but got I4
		//IL_04ff: Expected I, but got Obj
		//IL_0515: Expected Obj, but got I
		//IL_01de: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0648: Expected Obj, but got I4
		//IL_0274: Expected Obj, but got I
		//IL_0284: Expected Obj, but got I
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected Obj, but got Unknown
		//IL_02c0: Expected I, but got Obj
		//IL_02d6: Expected Obj, but got I
		//IL_021f: Expected I, but got Obj
		//IL_05fe: Expected I, but got Obj
		//IL_0614: Expected Obj, but got I
		//IL_0088: Expected I, but got Obj
		//IL_009e: Expected Obj, but got I
		//IL_0301: Expected I, but got Obj
		//IL_07ea: Expected Obj, but got I4
		//IL_0549: Expected I, but got Obj
		//IL_055f: Expected Obj, but got I
		//IL_0491: Expected I, but got Obj
		//IL_0597: Invalid comparison between I and F4
		//IL_00c9: Expected I, but got Obj
		//IL_0174: Invalid comparison between I and F4
		//IL_0116: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_019c: Expected Obj, but got I4
		//IL_05eb: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		obj2 = 0;
		nint num = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v103 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj4 = default;
		if ((nint)obj4 > 2)
		{
			if ((nint)obj4 == 3)
			{
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v93 (Il2CppClass<UIScreenController>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num4 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v99 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = UIScreenController.ShouldShowOnlineScreen();
				nint num5 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v46 (Il2CppClass<Cloud.CloudSave>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(CloudSave);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v65 (Il2CppClass<Cloud.CloudSave>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78EE");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v51+14]");
				object obj7;
				if (0f > 2f)
				{
					obj7 = 1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ S1_v51+14]");
					obj7 = ((!(0f < -2f)) ? ((object)0) : ((object)2));
				}
				string oldPopupName = (((nint)obj7 != 2) ? "CloudSaveComparisonPopup" : "CloudSavePromotionPopup");
				((UIScreenController)flag)._ActivateNextPopup(oldPopupName);
			}
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v21 (Il2CppClass<UIScreenController>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v29 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			((UIScreenController)flag2).DebugCloseAllPopups();
			((ConsentPopup)null).PrivacyPolicyClicked((UILabel)(object)"Fix");
			return;
		}
		nint num9 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v34 (Il2CppClass<UIScreenController>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num10 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v85 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag3)._ActivateNextPopup("CloudSaveStatusPopup");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S3_v3 (Il2CppMethodInfo)+C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S3_v4+60]");
		object obj11 = 0;
		object obj12 = obj11;
		object obj13 = obj12 & 0x1FFF;
		object obj14 = obj13 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v180 @ S4_v5 (should have been resolved before IL gen)");
		nint num12 = (nint)typeof(CloudSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v44 (Il2CppClass<Cloud.CloudSave>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num13 = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v81 (Il2CppClass<Cloud.CloudSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78ED");
		object obj16 = default;
		obj = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	private void FlurryLogOnButtonClicked(string buttonClicked)
	{
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02bb: Expected Obj, but got I4
		//IL_0010: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_004e: Expected I, but got Obj
		//IL_0064: Expected Obj, but got I
		//IL_0310: Expected Obj, but got I4
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_00ff: Expected Obj, but got I4
		//IL_008f: Expected I, but got Obj
		//IL_03d5: Expected I4, but got Obj
		//IL_03e0: Expected Obj, but got I4
		//IL_040b: Expected Obj, but got I4
		//IL_00dc: Expected Obj, but got I4
		//IL_0122: Expected Obj, but got I4
		//IL_0163: Expected I4, but got Obj
		//IL_0163: Expected Obj, but got I4
		//IL_017e: Expected Obj, but got I4
		//IL_026f: Expected Obj, but got I4
		//IL_023f: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I4
		//IL_01ec: Expected Obj, but got I4
		//IL_0253: Expected Obj, but got I4
		//IL_025f: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 0;
		_ = 0;
		((UILabel)(object)_footerHandler).fontSize = buttonClicked.m_firstChar;
		((UISprite)(object)_footerPrefab).fillCenter = (byte)buttonClicked.m_stringLength != 0;
		((FitSpriteToWidget)(object)screenName).FitStretch();
		string text = ((Component)_selectedFooterButton).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [buttonClicked @ L1 (System.String)+10]");
		bool flag = (nint)0 != 0;
		((GameObject)(object)text).tag = (string)flag;
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v21 (Il2CppClass<UI.ColorData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v65 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj4 = (flag2 ? 1 : 0) + 124;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S2_v6+8]");
		_ = 0;
		UILabel uILabel = (UILabel)(obj2 + 32);
		uILabel = (UILabel)obj2;
		UILabel uILabel2 = uILabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)uILabel2).m_CachedPtr = (IntPtr)0;
		Vector2 effectDistance = uILabel.effectDistance;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [buttonClicked @ L1 (System.String)+10]");
		if ((nint)0 != 0)
		{
			object obj5 = (flag2 ? 1 : 0) + 188;
			uILabel = (UILabel)obj5;
			object obj6 = obj5;
		}
		else
		{
			object obj7 = (flag2 ? 1 : 0) + 604;
			uILabel = (UILabel)obj7;
			object obj6 = obj7;
		}
		UILabel uILabel3 = uILabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ L7_v1+8]");
		((UnityEngine.Object)uILabel3).m_CachedPtr = (IntPtr)0;
		obj = uILabel;
		_ = ((UnityEngine.Object)uILabel).m_CachedPtr;
		uILabel = (UILabel)obj;
		UILabel uILabel4 = uILabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)uILabel4).m_CachedPtr = (IntPtr)0;
		((UIWidget)(object)_footerHandler).rawPivot = (UIWidget.Pivot)uILabel;
		string text2 = ((Component)showOldFooterSection).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [buttonClicked @ L1 (System.String)+11]");
		bool flag3 = (nint)0 != 0;
		((GameObject)(object)text2).tag = (string)flag3;
		object obj8 = (flag2 ? 1 : 0) + 76;
		obj2 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S2_v31+8]");
		_ = 0;
		uILabel = (UILabel)obj2;
		UILabel uILabel5 = uILabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)uILabel5).m_CachedPtr = (IntPtr)0;
		((UIWidget)showOldFooterSection).rawPivot = (UIWidget.Pivot)uILabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @76BC");
		((RewardForVideoButton)base._footerInited).Init(null);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [buttonClicked @ L1 (System.String)+14]");
		if ((nint)0 >= (nint)1)
		{
			UIWidget component = GetComponent<UIWidget>();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [buttonClicked @ L1 (System.String)+14]");
			component.height = 0;
			((UIRect)showOldFooterSection).ParentHasChanged();
			((RewardForVideoButton)base._footerInited).Init(null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [buttonClicked @ L1 (System.String)+1C]");
		if ((nint)0 >= (nint)1)
		{
			UIWidget component2 = GetComponent<UIWidget>();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [buttonClicked @ L1 (System.String)+1C]");
			Color color = ((UIWidget)0).color;
			((UIRect)showOldFooterSection).ParentHasChanged();
			((RewardForVideoButton)base._footerInited).Init(null);
		}
		UIWidget component3 = ((Component)base._footerInited).GetComponent<UIWidget>();
		UIRect.AnchorPoint leftAnchor = component3.leftAnchor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [buttonClicked @ L1 (System.String)+18]");
		leftAnchor.absolute = 0;
		((UIRect)component3).ParentHasChanged();
	}

	public CloudSaveReminderPopup()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
		((ConsentPopup)null).PrivacyPolicyClicked((UILabel)(object)"Close");
	}
}
